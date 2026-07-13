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
}

