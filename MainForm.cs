namespace Arcade_Game;

public partial class MainForm : Form
{
    Player player;
    public static MainForm Instance { get; private set; }

    public MainForm()
    {
        Instance = this;
        InitializeComponent();
        this.DoubleBuffered = true;



        SetupGame();
        Timer.Start();
    }

    private void SetupGame()
    {
        this.KeyDown += MainFormKeyDown;
        this.KeyUp += MainFormKeyUp;
        this.Paint += MainFormPaint;

        LoadPlayerDataFromDb();

        player = new Player(GameAssets.NormalPlayer);

        // test
        Enemy.enemies.Add(new StandardEnemy(100, new(5, CoinKind.Gold)));
        Enemy.enemies.Add(new TankEnemy(100, 50, new(1, CoinKind.Gold)));
        Enemy.enemies.Add(new ShooterEnemy(30, 400, new(5, CoinKind.Silver)));
        Enemy.enemies.Add(new ScoutEnemy(60, 60, new(1, CoinKind.Silver)));
        Enemy.enemies.Add(new TerroristEnemy(100, 200));
    }

    private void LoadPlayerDataFromDb()
    {
        using (var db = new GameDbContext())
        {
            var activeProfile = db.PlayerProfiles.FirstOrDefault(p => p.Id == GameSession.CurrentPlayerId);
            if (activeProfile != null)
            {
                Player.TotalGoldCoinValues = 0;
                Player.TotalSilverCoinValues = 0;
                Player.CurrentScore = 0;
                Player.HighScore = activeProfile.HighScore;
            }
        }
    }

    private void TimerEvent(object sender, EventArgs e)
    {
        if (player == null || player.HealthPoint <= 0) return;

        player.Move();

        UpdatePlayerBullets();
        UpdateEnemyBullets();
        UpdateEnemies();
        UpdateCoins();

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
                bullet.Dispose();
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
                bullet.Dispose();
                Enemy.bullets.RemoveAt(i);
                continue;
            }

            if (bullet.Bounds.IntersectsWith(player.Bounds))
            {
                player.HealthPoint--;
                bullet.Dispose();
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
                currentEnemy.HealthPoint--;
                CheckEnemyDeath(currentEnemy, i);
                continue;
            }

            for (int j = Player.bullets.Count - 1; j >= 0; j--)
            {
                Bullet currentBullet = Player.bullets[j];

                if (currentBullet.Bounds.IntersectsWith(currentEnemy.Bounds))
                {
                    currentBullet.Dispose();
                    Player.bullets.RemoveAt(j);
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
            enemy.Dispose();
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
                currentCoin.Dispose();
            }
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
}