using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arcade_Game
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm miow = new MenuForm();
            miow.Show();
            this.Hide();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Guidesbtn_Click(object sender, EventArgs e)
        {
            Guides hello = new Guides();
            hello.Show();
            this.Hide();
        }

        private void Soundsbtn_Click(object sender, EventArgs e)
        {
            Sounds theSound = new Sounds();
            theSound.Show();
            this.Hide();
        }
    }
}
