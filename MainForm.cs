namespace Arcade_Game;

public partial class MainForm : System.Windows.Forms.Form
{
    Player player = new(Properties.Resources.Player_1);

    public MainForm()
    {
        InitializeComponent();
        this.DoubleBuffered = true;

        SetupGame();

        this.KeyDown += MainFormKeyDown;
        this.KeyUp += MainFormKeyUp;
    }

    private void SetupGame()
    {
        this.Controls.Add(player);
    }

    private void TimerEvent(object sender, EventArgs e)
    {
        player.movePlayer();
    }

    private void MainFormKeyDown(object sender, KeyEventArgs e)
    {
        player.keyDown(e);
    }

    private void MainFormKeyUp(object sender, KeyEventArgs e)
    {
        player.keyUp(e);
    }
}