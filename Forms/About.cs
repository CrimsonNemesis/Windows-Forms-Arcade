namespace Arcade_Game;

public partial class About : Base
{
    public About()
    {
        InitializeComponent();
        this.FullScreen();
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        NavigationManager.ShowForm(NavigationManager.MainMenuForm);
    }

    private void About_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }
}

