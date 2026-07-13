namespace Arcade_Game;

public class Base : Form
{
    public void FullScreen()
    {
        this.DoubleBuffered = true;
        this.FormBorderStyle = FormBorderStyle.None;
        this.WindowState = FormWindowState.Normal;

        Screen currentScreen = Screen.FromControl(this);

        this.Width = currentScreen.Bounds.Width;
        this.Height = currentScreen.Bounds.Height;
        this.Location = currentScreen.Bounds.Location;
    }
}