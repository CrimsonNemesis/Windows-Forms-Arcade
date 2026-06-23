using System.ComponentModel;

namespace Arcade_Game;

internal class Player : PictureBox
{
    bool goLeft;
    bool goRight;
    bool goUp;
    bool goDown;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Speed { get; set; } = 10;

    public Player(Image skin)
    {
        this.Image = skin;
        this.SizeMode = PictureBoxSizeMode.StretchImage;

        this.Location = new Point(554, 751);
        this.Size = new Size(90, 90);
        this.BackColor = Color.Transparent;
        this.Name = "Player";
        this.Tag = "Player";
    }

    public void keyDown( KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Left) goLeft = true;
        if (e.KeyCode == Keys.Right) goRight = true;
        if (e.KeyCode == Keys.Up) goUp = true;
        if (e.KeyCode == Keys.Down) goDown = true;
    }

    public void keyUp( KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Left) goLeft = false;
        if (e.KeyCode == Keys.Right) goRight = false;
        if (e.KeyCode == Keys.Up) goUp = false;
        if (e.KeyCode == Keys.Down) goDown = false;
    }

    public void movePlayer()
    {
        if (goLeft) this.Left -= Speed;
        if (goRight) this.Left += Speed;
        if (goUp) this.Top -= Speed;
        if (goDown) this.Top += Speed;
    }
}