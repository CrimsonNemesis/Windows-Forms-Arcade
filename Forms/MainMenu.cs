namespace Arcade_Game;

public partial class MainMenu : Base
{
    public MainMenu()
    {
        InitializeComponent();
        this.FullScreen();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        NavigationManager.ShowForm(NavigationManager.ChooseModeForm);
    }

    private void Exit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void about_Click(object sender, EventArgs e)
    {
        NavigationManager.ShowForm(NavigationManager.About);
    }

    private void option_Click(object sender, EventArgs e)
    {
        NavigationManager.ShowForm(NavigationManager.OptionsForm);
    }

    private void Shop_Click(object sender, EventArgs e)
    {
        NavigationManager.ShowForm(NavigationManager.ShopForm);
    }

    private void Back_Click(object sender, EventArgs e)
    {
        NavigationManager.ShowForm(NavigationManager.SelectProfileForm);
    }

    private void MainMenu_VisibleChanged(object sender, EventArgs e)
    {
        if (this.Visible)
            MusicPlayer.Play(@"Resources\Musics&Sounds\MenuMusic.wav");
    }

    private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();

    }
}

