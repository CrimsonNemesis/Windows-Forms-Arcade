namespace Arcade_Game;

public partial class MainForm : Form
{
    Player player;
    public static MainForm Instance { get; private set; }

    public MainForm()
    {
        Instance = this;
        InitializeComponent();
        this.KeyPreview = true;
        this.ActiveControl = null;
        this.Focus();
        this.DoubleBuffered = true;

        SetupGame();
        Timer.Start();
    }

    private void SetupGame()
    {
        this.KeyDown += MainFormKeyDown;
        this.KeyUp += MainFormKeyUp;
        this.Paint += MainFormPaint;

        Player.LoadPlayerDataFromDb();
        Player.CurrentScore = 0;

        player = new Player(AssetManager.Player);
        

        WaveManager.LoadWave();
    }

    

    private void TimerEvent(object sender, EventArgs e)
    {
        if (player == null || player.HealthPoint <= 0) return;

        player.Update();

        UpdatePlayerBullets();
        UpdateEnemyBullets();
        UpdateEnemies();
        UpdateCoins();

        pH.Text = $"Health Point : {player.HealthPoint}";
        playerScore.Text = $"Score : {Player.CurrentScore}";
        theCoins.Text = $"{Player.TotalGoldCoinValues} : Gold Coins";
        silCoins.Text = $"{Player.TotalSilverCoinValues} : Silver Coins";
        wavey.Text = $"Wave {WaveManager.CurrentWave}";

        if (Enemy.enemies.Count == 0)
        {
            WaveManager.NextWave();
        }

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
                player.HealthPoint--;
                SoundEffects.Play(GameAssets.hitHurt);
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

                player.HealthPoint--;
                SoundEffects.Play(GameAssets.hitHurt);
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

    private bool CheckEnemyDeath(Enemy enemy, int enemyIndex)
    {
        if (enemy.HealthPoint <= 0)
        {
            SoundEffects.Play(GameAssets.Explosion);
            enemy.DropCoin();
            Player.CurrentScore += enemy.Score;
            Enemy.enemies.RemoveAt(enemyIndex);
            return true;
        }

        return false;
    }

    private void UpdateCoins()
    {
        for (int i = Coin.coins.Count - 1; i >= 0; i--)
        {
            Coin currentCoin = Coin.coins[i];

            if (player.Bounds.IntersectsWith(currentCoin.Bounds))
            {
                SoundEffects.Play(GameAssets.CoinPickup);

                if (currentCoin.kind == CoinKind.Silver) Player.TotalSilverCoinValues += currentCoin.value;
                else if (currentCoin.kind == CoinKind.Gold) Player.TotalGoldCoinValues += currentCoin.value;

                Coin.coins.RemoveAt(i);
            }

            currentCoin.Top += 1;

            if (currentCoin.Top >= MainForm.Instance.ClientSize.Height)
                Coin.coins.RemoveAt(i);
        }
    }

    private void Form_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private void MainFormKeyDown(object sender, KeyEventArgs e) => player.KeyDown(e);
    private void MainFormKeyUp(object sender, KeyEventArgs e) => player.KeyUp(e);

    private void MainFormPaint(object sender, PaintEventArgs e)
    {
        e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

        if (player != null && player.HealthPoint > 0) e.Graphics.DrawImage(player.Image, player.Bounds);
        foreach (var enemy in Enemy.enemies) e.Graphics.DrawImage(enemy.Image, enemy.Bounds);
        foreach (var bullet in Player.bullets) e.Graphics.DrawImage(bullet.Image, bullet.Bounds);
        foreach (var bullet in Enemy.bullets) e.Graphics.DrawImage(bullet.Image, bullet.Bounds);
        foreach (var coin in Coin.coins) e.Graphics.DrawImage(coin.Image, coin.Bounds);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        MusicPlayer.Play(@"Resources\Musics&Sounds\GameMusic.wav");
    }

    private void backBTN_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Back Clicked");
    }

    
}