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
        MainMenu menu = new MainMenu();
        this.Hide();
        menu.Show();
    }

    private void Form_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private void Guidesbtn_Click(object sender, EventArgs e)
    {
        Guide hello = new Guide();
        this.Hide();
        hello.Show();
    }

    private void Soundsbtn_Click(object sender, EventArgs e)
    {
        Sounds theSound = new Sounds();
        this.Hide();
        theSound.Show();
    }
}
