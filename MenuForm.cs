using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arcade_Game
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
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
            Choose game = new Choose();

            game.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void about_Click(object sender, EventArgs e)
        {
            About page = new About();

            page.Show();
            this.Hide();
        }

        private void option_Click(object sender, EventArgs e)
        {
            Options superbeje = new Options();
            superbeje.Show();
            this.Hide();
        }

        private void Shop_Click(object sender, EventArgs e)
        {
            Shop miow = new Shop();
            miow.Show();
            this.Hide();
        }
    }
}
