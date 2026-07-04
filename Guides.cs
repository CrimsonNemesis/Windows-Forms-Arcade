using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arcade_Game
{
    public partial class Guides : Form
    {
        public Guides()
        {
            InitializeComponent();
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


}
