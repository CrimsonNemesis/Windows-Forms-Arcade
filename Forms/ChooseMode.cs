namespace Arcade_Game;

public partial class ChooseMode : Base
{
    public ChooseMode()
    {
        InitializeComponent();
        this.FullScreen();
    }

    private void backBtn_Click(object sender, EventArgs e)
    {
        MainMenu game2 = new MainMenu();
        this.Hide();
        game2.Show();
    }

    private void NormMode_Click(object sender, EventArgs e)
    {
        GameSettings.PixelMode = false;

        Game game3 = new Game();
        this.Hide();
        game3.Show();
    }

    private void PixMode_Click(object sender, EventArgs e)
    {
        GameSettings.PixelMode = true;

        Game game3 = new Game();
        this.Hide();
        game3.Show();
    }

    private void Form_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }
}