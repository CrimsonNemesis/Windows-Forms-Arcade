using System.ComponentModel;

namespace Arcade_Game;

internal abstract class Enemy : GameObject
{
    public static List<Enemy> enemies = new();
    public static List<EnemyBullet> bullets = new();
    protected double exactX;
    protected double exactY;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual int HealthPoint { get; set; } = 2;

    public IDropSpecification? Loot { get; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Score { get; protected set; }

    protected DateTime lastTimeShot = DateTime.MinValue;

    protected int Speed { get; set; }

    protected Point Invert = new Point(1, 1);

    public Enemy(Point startLocation)
    {
        this.Size = new Size(60, 60);
        this.Loot = LootManager.GetRandomDrop();
        this.Location = new Point(startLocation.X - this.Width / 2, startLocation.Y - this.Height / 2);
        this.exactX = this.Left;
        this.exactY = this.Top;
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

    public virtual void Move(double deltaTime)
    {
        if (this.Top <= 0) Invert.Y = 1;
        else if (this.Bottom >= Game.Instance.ClientSize.Height) Invert.Y = -1;

        this.exactY += Speed * Invert.Y * deltaTime * 60.0;
        this.Top = (int)Math.Round(this.exactY);
    }

    public void DropLoot()
    {
        if (Loot != null)
        {
            int centerX = this.Left + this.Width / 2;
            int centerY = this.Top + this.Height / 2;

            if (Loot is CoinSpecification coinSpec)
            {
                Collectable.collectables.Add(new Coin(coinSpec.Value, coinSpec.Kind, centerX, centerY));
            }
            else if (Loot is PowerUpSpecification powerSpec)
            {
                Collectable.collectables.Add(new PowerUp(powerSpec.Type, centerX, centerY));
            }
        }
    }
}

class StandardEnemy : Enemy
{
    public StandardEnemy(Point startLocation) : base(startLocation)
    {
        this.Image = AssetManager.StandardEnemy;

        Score = 5;
        this.HealthPoint = 2 + WaveManager.EnemyHealthBonus;
        this.Speed = 3 + WaveManager.EnemySpeedBonus;
    }
}

class ShooterEnemy : Enemy
{
    private const int CoolDown = 3500;

    public ShooterEnemy(Point startLocation) : base(startLocation)
    {
        this.Image = AssetManager.ShooterEnemy;

        Score = 15;
        this.HealthPoint = 2 + WaveManager.EnemyHealthBonus;
        this.Speed = 2;
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

    public ScoutEnemy(Point startLocation) : base(startLocation)
    {
        this.Image = AssetManager.ScoutEnemy;

        Score = 10;
        this.HealthPoint = 2 + WaveManager.EnemyHealthBonus;
        this.Speed = 3 + WaveManager.EnemySpeedBonus;
    }

    public override void Move(double deltaTime)
    {
        if ((DateTime.Now - lastInvertTime).TotalMilliseconds >= 1000)
        {
            Invert.X = rand.Next(0, 2) == 0 ? 1 : -1;
            lastInvertTime = DateTime.Now;
        }

        if (this.exactX + this.Width > Game.Instance.ClientSize.Width) Invert.X = -1;
        else if (this.exactX < 0) Invert.X = 1;

        if (this.exactY <= 0) Invert.Y = 1;
        else if (this.exactY + this.Height >= Game.Instance.ClientSize.Height) Invert.Y = -1;

        double step = (Speed / Math.Sqrt(2)) * deltaTime * 60.0;

        this.exactX += step * Invert.X;
        this.exactY += step * Invert.Y;

        this.Left = (int)Math.Round(this.exactX);
        this.Top = (int)Math.Round(this.exactY);
    }
}

class TerroristEnemy : Enemy
{
    public override int HealthPoint { get; set; } = 1;

    public TerroristEnemy(Point startLocation) : base(startLocation)
    {
        this.Image = AssetManager.TerroristEnemy;

        Score = 10;
        this.HealthPoint = 1 + WaveManager.EnemyHealthBonus;
        this.Speed = 2 + WaveManager.EnemySpeedBonus;
    }

    public override void Move(double deltaTime)
    {
        int diffX = Player.Instance.Left - (int)Math.Round(exactX);
        int diffY = Player.Instance.Top - (int)Math.Round(exactY);

        double diagonal = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
        if (diagonal == 0) return;

        double speedForFrame = Speed * deltaTime * 60.0;
        double k = speedForFrame / diagonal;

        this.exactX += diffX * k;
        this.exactY += diffY * k;

        this.Left = (int)Math.Round(exactX);
        this.Top = (int)Math.Round(exactY);
    }
}

class TankEnemy : Enemy
{
    public override int HealthPoint { get; set; } = 80;
    private const int CoolDown = 3500;

    public TankEnemy(Point startLocation) : base(startLocation)
    {
        this.Image = AssetManager.TankEnemy;
        this.Size = new Size(200, 120);
        this.Speed = 2;

        Score = 25;
    }

    public override void Move(double deltaTime)
    {
        if (this.exactX + this.Width > Game.Instance.ClientSize.Width) Invert.X = -1;
        else if (this.exactX < 0) Invert.X = 1;

        this.exactX += Speed * Invert.X * deltaTime * 60.0;
        this.Left = (int)Math.Round(this.exactX);
    }

    public override void Shoot()
    {
        if (!base.CanShoot(CoolDown)) return;

        List<EnemyBullet> tankBullets = new List<EnemyBullet> {
            new EnemyBullet(this, 0, 1, 5), new EnemyBullet(this, 0, -1, 5),
            new EnemyBullet(this, 1, 0, 5), new EnemyBullet(this, -1, 0, 5),
            new EnemyBullet(this, 1, 1, 5), new EnemyBullet(this, 1, -1, 5),
            new EnemyBullet(this, 1, -1, 5), new EnemyBullet(this, -1, -1, 5),
            new EnemyBullet(this, -1, 1, 5)
        };

        foreach (var bullet in tankBullets) bullets.Add(bullet);
    }
}