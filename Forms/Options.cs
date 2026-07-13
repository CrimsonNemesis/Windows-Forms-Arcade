namespace Arcade_Game;

public partial class Options : Base
{
    public Options()
    {
        InitializeComponent();
        this.FullScreen();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        NavigationManager.ShowForm(NavigationManager.MainMenuForm);
    }

    private void Guidesbtn_Click(object sender, EventArgs e)
    {
        NavigationManager.ShowForm(NavigationManager.GuideForm);
    }

    private void Soundsbtn_Click(object sender, EventArgs e)
    {
        NavigationManager.ShowForm(NavigationManager.SoundsForm);
    }
}
