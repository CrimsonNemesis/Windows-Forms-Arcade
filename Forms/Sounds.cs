namespace Arcade_Game;

public partial class Sounds : Base
{
    public Sounds()
    {
        InitializeComponent();
        this.FullScreen();
    }

    private void trackBarMusic_Scroll(object sender, EventArgs e)
    {
        lblMusicVolume.Text = "Music : " + trackBarMusic.Value + " %";

        MusicPlayer.SetVolume(trackBarMusic.Value / 100f);
    }

    private void SettingsForm_Load(object sender, EventArgs e)
    {
        lblMusicVolume.Text = $"{trackBarMusic.Value}%";
        MusicPlayer.SetVolume(trackBarMusic.Value / 100f);
    }

    private void trackBarSfx_Scroll(object sender, EventArgs e)
    {
        lblSfxVolume.Text = $"Sound : {trackBarSfx.Value} %";

        SoundEffects.SetVolume(trackBarSfx.Value / 100f);
    }

    private void Backbtn_Click(object sender, EventArgs e)
    {
        NavigationManager.ShowForm(NavigationManager.OptionsForm);
    }

    private void Sounds_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();

    }
}
