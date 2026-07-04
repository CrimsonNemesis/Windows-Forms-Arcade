using System.ComponentModel;

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

    public Enemy(CoinSpecification? loot = null)
    {
        this.Size = new Size(60, 60);
        this.Loot = loot;
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

    public new abstract void Move();
    public virtual void Shoot() { }

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
    private int speed { get; set; } = 2;

    public StandardEnemy(int startX, CoinSpecification? loot = null) : base(loot)
    {
        this.Image = GameAssets.NormalEnemyStandard;
        this.Location = new Point(startX - this.Width / 2, 100);
        Score = 5;
    }

    public override void Move() => this.Top += speed;
}

class ShooterEnemy : Enemy
{
    private int speed { get; set; } = 2;
    private const int CoolDown = 2000;

    public ShooterEnemy(int startX, int startY, CoinSpecification? loot = null) : base(loot)
    {
        this.Location = new Point(startX - this.Width / 2, startY - this.Height / 2);
        this.Image = GameAssets.NormalEnemyShooter;
        Score = 15;
    }

    public override void Move() => this.Top += speed;

    public override void Shoot()
    {
        if (!base.CanShoot(CoolDown)) return;
        EnemyBullet bullet = new(this, 0, -1, 5);
        bullets.Add(bullet);
    }
}

class ScoutEnemy : Enemy
{
    private int speed { get; set; } = 3;
    private int invert = 1;
    private static readonly Random rand = new();
    private DateTime lastInvertTime = DateTime.Now;

    public ScoutEnemy(int startX, int startY, CoinSpecification? loot = null) : base(loot)
    {
        this.Image = GameAssets.NormalEnemyScout;
        this.Location = new Point(startX - this.Width / 2, startY - this.Height / 2);
        Score = 10;
    }

    public override void Move()
    {
        if ((DateTime.Now - lastInvertTime).TotalMilliseconds >= 1000)
        {
            invert = rand.Next(0, 2) == 0 ? 1 : -1;
            lastInvertTime = DateTime.Now;
        }

        if (this.Right > MainForm.Instance.ClientSize.Width) invert = -1;
        else if (this.Left < 0) invert = 1;

        int step = (int)Math.Round(speed / Math.Sqrt(2));
        this.Top += step;
        this.Left += invert * step;
    }
}

class TerroristEnemy : Enemy
{
    private int speed { get; set; } = 2;
    public override int HealthPoint { get; set; } = 1;

    public TerroristEnemy(int startX, int startY, CoinSpecification? loot = null) : base(loot)
    {
        this.Location = new Point(startX - this.Width / 2, startY - this.Height / 2);
        this.Image = GameAssets.NormalEnemyTerrorist;
        Score = 10;
    }

    public override void Move()
    {
        int diffX = Player.Instance.Left - this.Left;
        int diffY = Player.Instance.Top - this.Top;

        double diagonal = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
        if (diagonal == 0) return;

        double k = speed / diagonal;
        this.Left += (int)Math.Round(diffX * k);
        this.Top += (int)Math.Round(diffY * k);
    }
}

class TankEnemy : Enemy
{
    private int speed { get; set; } = 2;
    public override int HealthPoint { get; set; } = 6;
    private const int CoolDown = 2000;
    private int invert = 1;

    public TankEnemy(int startX, int startY, CoinSpecification? loot = null) : base(loot)
    {
        this.Image = GameAssets.NormalEnemyTank;
        this.Size = new Size(125, 75);
        this.Location = new Point(startX - this.Width / 2, startY - this.Height / 2);
        Score = 25;
    }

    public override void Move()
    {
        if (this.Right > MainForm.Instance.ClientSize.Width) invert = -1;
        else if (this.Left < 0) invert = 1;

        this.Left += speed * invert;
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