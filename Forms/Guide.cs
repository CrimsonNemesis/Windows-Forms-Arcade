namespace Arcade_Game;

public partial class Guide : Base
{
    public Guide()
    {
        InitializeComponent();
        this.FullScreen();
    }

    private void Form_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private void Backbtn_Click(object sender, EventArgs e)
    {
        Options miowmiow = new Options();
        miowmiow.Show();
        this.Hide();
    }
}