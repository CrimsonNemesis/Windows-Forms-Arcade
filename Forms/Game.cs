namespace Arcade_Game;

public partial class Game : Base
{
    Player player;
    public static Game Instance { get; private set; }
    private PausePrompt pausePrmpt = new PausePrompt();

    public Game()
    {
        Instance = this;

        InitializeComponent();
        this.FullScreen();

        this.KeyPreview = true;
        this.ActiveControl = null;

        SetupGame();
        Timer.Start();
    }

    private void SetupGame()
    {
        WaveManager.CurrentWave = 1;
        WaveManager.EnemyHealthBonus = 0;
        WaveManager.EnemySpeedBonus = 0;

        Player.bullets.Clear();
        Enemy.enemies.Clear();
        Enemy.bullets.Clear();
        Collectable.collectables.Clear();

        this.KeyDown += MainFormKeyDown;
        this.KeyUp += MainFormKeyUp;
        this.Paint += MainFormPaint;

        Player.LoadPlayerDataFromDb();
        Player.CurrentScore = 0;

        if (Player.HasSpecialTheme)
            this.BackgroundImage = GameAssets.AsteroidBeltBackGround;
        else
            this.BackgroundImage = GameAssets.SpaceBackGround2;

        player = new Player(AssetManager.Player);
        WaveManager.LoadWave();
    }

    private void TimerEvent(object sender, EventArgs e)
    {
        if (player == null) return;

        player.Update();

        UpdatePlayerBullets();
        UpdateEnemyBullets();
        UpdateEnemies();
        UpdateCollectables();
        UpdatePowerUpUI();

        healthBar.Width = player.HealthPoint * 10;

        playerScore.Text = $"Score : {Player.CurrentScore}";
        theCoins.Text = $"{Player.TotalGoldCoinValues} : Gold Coins";
        silCoins.Text = $"{Player.TotalSilverCoinValues} : Silver Coins";
        wavey.Text = $"Wave {WaveManager.CurrentWave}";

        if (player.HealthPoint <= 0)
        {
            Player.HighScore = Math.Max(Player.CurrentScore, Player.HighScore);

            Player.SavePlayerDataToDb();

            GameOverPrompt prompt = new("You lost!");
            prompt.Show();

            return;
        }

        if (Enemy.enemies.Count == 0)
            WaveManager.NextWave();

        this.Invalidate();
    }

    private void UpdatePlayerBullets()
    {
        for (int i = Player.bullets.Count - 1; i >= 0; i--)
        {
            PlayerBullet bullet = Player.bullets[i];
            bullet.Move();

            if (bullet.IsOutOfBounds())
            {
                Player.bullets.RemoveAt(i);
            }
        }
    }

    private void UpdateEnemyBullets()
    {
        for (int i = Enemy.bullets.Count - 1; i >= 0; i--)
        {
            EnemyBullet bullet = Enemy.bullets[i];
            bullet.Move();

            if (bullet.IsOutOfBounds())
            {
                Enemy.bullets.RemoveAt(i);
                continue;
            }

            if (bullet.Bounds.IntersectsWith(player.Bounds))
            {
                if (!player.IsShielded)
                {
                    player.HealthPoint--;
                    SoundEffects.Play(GameAssets.hitHurt);
                }
                Enemy.bullets.RemoveAt(i);
            }
        }
    }

    private void UpdateEnemies()
    {
        for (int i = Enemy.enemies.Count - 1; i >= 0; i--)
        {
            Enemy currentEnemy = Enemy.enemies[i];
            currentEnemy.Move();
            currentEnemy.Shoot();

            if (currentEnemy.Bounds.IntersectsWith(player.Bounds) && player.CanGetHitByImpact())
            {
                if (!player.IsShielded)
                {
                    player.HealthPoint--;
                    SoundEffects.Play(GameAssets.hitHurt);
                }

                currentEnemy.HealthPoint--;
                CheckEnemyDeath(currentEnemy, i);
                continue;
            }

            for (int j = Player.bullets.Count - 1; j >= 0; j--)
            {
                Bullet currentBullet = Player.bullets[j];

                if (currentBullet.Bounds.IntersectsWith(currentEnemy.Bounds))
                {
                    Player.bullets.RemoveAt(j);

                    SoundEffects.Play(GameAssets.hitHurt);

                    currentEnemy.HealthPoint--;

                    if (CheckEnemyDeath(currentEnemy, i))
                        break;
                }
            }
        }
    }

    private void UpdatePowerUpUI()
    {
        if (player == null || player.HealthPoint <= 0) return;

        DateTime now = DateTime.Now;

        PowerUpPicBox.Visible = false;
        PowerUpTimer.Visible = false;

        if (player.ShieldEndTime > now)
        {
            PowerUpPicBox.Image = Properties.Resources.ShieldPowerUp;

            int secondsLeft = (int)Math.Ceiling((player.ShieldEndTime - now).TotalSeconds);
            PowerUpTimer.Text = $"{secondsLeft}s";

            PowerUpPicBox.Visible = true;
            PowerUpTimer.Visible = true;
        }
        else if (player.FireRateEndTime > now)
        {
            PowerUpPicBox.Image = Properties.Resources.FireRateBulletPowerUp;
            int secondsLeft = (int)Math.Ceiling((player.FireRateEndTime - now).TotalSeconds);
            PowerUpTimer.Text = $"{secondsLeft}s";

            PowerUpPicBox.Visible = true;
            PowerUpTimer.Visible = true;
        }
        else if (player.TripleShotEndTime > now)
        {
            PowerUpPicBox.Image = Properties.Resources.TrippleShotBulletPowerUp;
            int secondsLeft = (int)Math.Ceiling((player.TripleShotEndTime - now).TotalSeconds);
            PowerUpTimer.Text = $"{secondsLeft}s";

            PowerUpPicBox.Visible = true;
            PowerUpTimer.Visible = true;
        }
    }

    private bool CheckEnemyDeath(Enemy enemy, int enemyIndex)
    {
        if (enemy.HealthPoint <= 0)
        {
            SoundEffects.Play(GameAssets.Explosion);
            enemy.DropLoot();
            Player.CurrentScore += enemy.Score;
            Enemy.enemies.RemoveAt(enemyIndex);
            return true;
        }

        return false;
    }

    private void UpdateCollectables()
    {
        for (int i = Collectable.collectables.Count - 1; i >= 0; i--)
        {
            Collectable drop = Collectable.collectables[i];
            drop.Move();

            if (player.Bounds.IntersectsWith(drop.Bounds))
            {
                SoundEffects.Play(GameAssets.CoinPickup);
                drop.ApplyEffect();
                Collectable.collectables.RemoveAt(i);
                continue;
            }

            if (drop.Top >= Game.Instance.ClientSize.Height)
            {
                Collectable.collectables.RemoveAt(i);
            }
        }
    }

    private void MainFormKeyDown(object sender, KeyEventArgs e) => player.KeyDown(e);
    private void MainFormKeyUp(object sender, KeyEventArgs e) => player.KeyUp(e);

    private void MainFormPaint(object sender, PaintEventArgs e)
    {
        e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

        if (player != null && player.HealthPoint > 0)
        {
            e.Graphics.DrawImage(player.Image, player.Bounds);

            if (player.IsShielded)
            {
                using (Pen shieldPen = new Pen(Color.Cyan, 3))
                {
                    e.Graphics.DrawEllipse(shieldPen, player.Bounds.X - 5, player.Bounds.Y - 5, player.Bounds.Width + 10, player.Bounds.Height + 10);
                }
            }
        }

        foreach (var enemy in Enemy.enemies) e.Graphics.DrawImage(enemy.Image, enemy.Bounds);
        foreach (var bullet in Player.bullets) e.Graphics.DrawImage(bullet.Image, bullet.Bounds);
        foreach (var bullet in Enemy.bullets) e.Graphics.DrawImage(bullet.Image, bullet.Bounds);
        foreach (var drop in Collectable.collectables) e.Graphics.DrawImage(drop.Image, drop.Bounds);
    }

    private void backBTN_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Back Clicked");
    }

    private void Game_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            Timer.Stop();

            TaskDialogButton result = pausePrmpt.Show();

            if (result == pausePrmpt.backBtn)
                NavigationManager.LeaveGameAndGoToMenu(this);
            else
                Timer.Start();
        }
    }

    private void Game_VisibleChanged(object sender, EventArgs e)
    {
        if (this.Visible)
            MusicPlayer.Play(@"Resources\Musics&Sounds\GameMusic.wav");
    }
}