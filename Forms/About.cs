namespace Arcade_Game;

public partial class About : Base
{
    public About()
    {
        InitializeComponent();
        this.FullScreen();
    }

    private void Form_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        MainMenu menu = new MainMenu();
        this.Hide();
        menu.Show();
    }
}

