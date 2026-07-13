namespace Arcade_Game;

public partial class Guide : Base
{
    public Guide()
    {
        InitializeComponent();
        this.FullScreen();
    }

    private void Backbtn_Click(object sender, EventArgs e)
    {
        NavigationManager.ShowForm(NavigationManager.OptionsForm);
    }

    private void Guide_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();

    }
}