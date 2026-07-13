namespace Arcade_Game;

public partial class MainMenu : Base
{
    public MainMenu()
    {
        InitializeComponent();
        this.FullScreen();
    }

    private void MenuForm_Load(object sender, EventArgs e)
    {
        MusicPlayer.Play(@"Resources\Musics&Sounds\MenuMusic.wav");
    }

    private void Form_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        ChooseMode game = new ChooseMode();
        this.Hide();
        game.Show();
    }

    private void Exit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void about_Click(object sender, EventArgs e)
    {
        About page = new About();
        this.Hide();
        page.Show();
    }

    private void option_Click(object sender, EventArgs e)
    {
        Options options = new Options();
        this.Hide();
        options.Show();
    }

    private void Shop_Click(object sender, EventArgs e)
    {
        Shop menu = new Shop();
        this.Hide();
        menu.Show();
    }

    private void Back_Click(object sender, EventArgs e)
    {
        SelectProfile menu = new();
        this.Hide();
        menu.Show();
    }
}

