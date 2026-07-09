using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.AxHost;

namespace Arcade_Game;

internal abstract class Enemy : GameObject
{
    public static List<Enemy> enemies = new();
    public static List<EnemyBullet> bullets = new();

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual int HealthPoint { get; set; } = 2;

    public CoinSpecification? Loot { get; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Score { get; protected set; }

    protected DateTime lastTimeShot = DateTime.MinValue;

    protected int Speed { get; set; }

    protected Point Invert = new Point(1, 1);

    public Enemy(Point startLocation, CoinSpecification? loot = null)
    {
        this.Size = new Size(60, 60);
        this.Loot = loot;
        this.Location = new Point(startLocation.X - this.Width / 2, startLocation.Y - this.Height / 2);
    }

    protected bool CanShoot(int cooldownMilliseconds)
    {
        if ((DateTime.Now - lastTimeShot).TotalMilliseconds >= cooldownMilliseconds)
        {
            lastTimeShot = DateTime.Now;
            return true;
        }

        return false;
    }

    public virtual void Shoot() { }

    public virtual void Move()
    {
        if (this.Top <= 0) Invert.Y = 1;
        else if (this.Bottom >= MainForm.Instance.ClientSize.Height) Invert.Y = -1;

        this.Top += Speed * Invert.Y;
    }

    public void DropCoin()
    {
        if (Loot != null)
        {
            int centerX = this.Left + this.Width / 2;
            int centerY = this.Top + this.Height / 2;
            Coin.coins.Add(new Coin(Loot.Value, Loot.Kind, centerX, centerY));
        }
    }
}

class StandardEnemy : Enemy
{
    
    public StandardEnemy(Point startLocation, CoinSpecification? loot = null) : base(startLocation, loot)
    {
        this.Image = AssetManager.StandardEnemy;
        this.HealthPoint = HealthPoint + WaveManager.EnemyHealthBonus;
        this.Speed = Speed * WaveManager.EnemySpeedBonus;


        Score = 5;
        Speed = 3;
    }
}

class ShooterEnemy : Enemy
{
    private const int CoolDown = 3500;

    public ShooterEnemy(Point startLocation, CoinSpecification? loot = null) : base(startLocation, loot)
    {
        this.Image = AssetManager.ShooterEnemy;
        this.HealthPoint = HealthPoint + WaveManager.EnemyHealthBonus;


        Score = 15;
        Speed = 2;
    }

    public override void Shoot()
    {
        if (!base.CanShoot(CoolDown)) return;
        EnemyBullet bullet = new(this, 0, -1, 5);
        bullets.Add(bullet);
    }
}

class ScoutEnemy : Enemy
{
    private static readonly Random rand = new();
    private DateTime lastInvertTime = DateTime.Now;

    public ScoutEnemy(Point startLocation, CoinSpecification? loot = null) : base(startLocation, loot)
    {
        this.Image = AssetManager.ScoutEnemy;
        this.HealthPoint = HealthPoint + WaveManager.EnemyHealthBonus;
        this.Speed = Speed * WaveManager.EnemySpeedBonus;


        Score = 10;
        Speed = 3;
    }

    public override void Move()
    {
        if ((DateTime.Now - lastInvertTime).TotalMilliseconds >= 1000)
        {
            Invert.X = rand.Next(0, 2) == 0 ? 1 : -1;
            lastInvertTime = DateTime.Now;
        }

        if (this.Right > MainForm.Instance.ClientSize.Width) Invert.X = -1;
        else if (this.Left < 0) Invert.X = 1;

        if (this.Top <= 0) Invert.Y = 1;
        else if (this.Bottom >= MainForm.Instance.ClientSize.Height) Invert.Y = -1;

        int step = (int)Math.Round(Speed / Math.Sqrt(2));
        this.Left += step * Invert.X;
        this.Top += step * Invert.Y;
    }
}

class TerroristEnemy : Enemy
{
    public override int HealthPoint { get; set; } = 1;

    public TerroristEnemy(Point startLocation, CoinSpecification? loot = null) : base(startLocation, loot)
    {
        this.Image = AssetManager.TerroristEnemy;
        this.HealthPoint = HealthPoint + WaveManager.EnemyHealthBonus;
        this.Speed = Speed * WaveManager.EnemySpeedBonus;


        Score = 10;
        Speed = 2;
    }

    public override void Move()
    {
        int diffX = Player.Instance.Left - this.Left;
        int diffY = Player.Instance.Top - this.Top;

        double diagonal = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
        if (diagonal == 0) return;

        double k = Speed / diagonal;
        this.Left += (int)Math.Round(diffX * k);
        this.Top += (int)Math.Round(diffY * k);
    }
}

class TankEnemy : Enemy
{
    public override int HealthPoint { get; set; } = 200;
    private const int CoolDown = 3500;

    public TankEnemy(Point startLocation, CoinSpecification? loot = null) : base(startLocation, loot)
    {
        this.Image = AssetManager.TankEnemy;
        this.Size = new Size(200, 120);
        Score = 25;
        Speed = 2;
    }

    public override void Move()
    {
        if (this.Right > MainForm.Instance.ClientSize.Width) Invert.X = -1;
        else if (this.Left < 0) Invert.X = 1;

        this.Left += Speed * Invert.X;
    }

    public override void Shoot()
    {
        if (!base.CanShoot(CoolDown)) return;

        List<EnemyBullet> tankBullets = new List<EnemyBullet> {
            new EnemyBullet(this, 0, 1, 5), new EnemyBullet(this, 0, -1, 5),
            new EnemyBullet(this, 1, 0, 5), new EnemyBullet(this, -1, 0, 5),
            new EnemyBullet(this, 1, 1, 5), new EnemyBullet(this, 1, -1, 5),
            new EnemyBullet(this, -1, -1, 5), new EnemyBullet(this, -1, 1, 5)
        };

        foreach (var bullet in tankBullets) bullets.Add(bullet);
    }
}