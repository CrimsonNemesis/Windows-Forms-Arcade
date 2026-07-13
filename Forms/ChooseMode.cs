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
        NavigationManager.ShowForm(NavigationManager.MainMenuForm);
    }

    private void NormMode_Click(object sender, EventArgs e)
    {
        NavigationManager.StartGame(pixelMode: false);
    }

    private void PixMode_Click(object sender, EventArgs e)
    {
        NavigationManager.StartGame(pixelMode: true);
    }

    private void ChooseMode_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();

    }
}