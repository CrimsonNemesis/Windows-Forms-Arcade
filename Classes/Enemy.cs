using System.ComponentModel;

namespace Arcade_Game;

internal abstract class Enemy : PictureBox
{
    public static List<Enemy> enemies = new();
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int HealthPoint { get; set; } = 2;

    public Enemy(int startX)
    {
        this.Size = new Size(60, 60);
        this.SizeMode = PictureBoxSizeMode.StretchImage;
        this.BackColor = Color.Transparent;
        this.Location = new Point(startX - this.Width / 2, 100);
    }

    public new abstract void Move();
}

class StandardEnemy : Enemy
{
    public StandardEnemy(int startX): base(startX)
    {
        this.Image = Properties.Resources.Enemy_Standard;
    }

    public override void Move()
    {
        this.Top += 2;
    }
}

class ShooterEnemy : Enemy
{
    public ShooterEnemy(int startX, int startY) : base(startX)
    {
        this.Location = new Point(startX - this.Width / 2, startY - this.Height / 2);
        this.Image = Properties.Resources.Enemy_Standard;
    }

    public override void Move()
    {
        this.Top += 2;
    }

    public void Shoot()
    {

    }
}

//class ScoutEnemy : Enemy
//{

//}

//class TerroristEnemy : Enemy
//{

//}