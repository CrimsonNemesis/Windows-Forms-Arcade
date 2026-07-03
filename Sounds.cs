using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arcade_Game
{
    public partial class Sounds : Form
    {
        public Sounds()
        {
            InitializeComponent();
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            Options gerdy = new Options();
            gerdy.Show();
            this.Hide();
        }
    }
}
