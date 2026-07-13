namespace Arcade_Game;

public partial class Guide : Base
{
    public Guide()
    {
        InitializeComponent();

        typeof(TableLayoutPanel).GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance)
            ?.SetValue(tableLayoutPanel1, true, null);

        this.FullScreen();
    }

    private void Backbtn_Click(object sender, EventArgs e)
    {
        NavigationManager.ShowForm(NavigationManager.OptionsForm);
    }
}