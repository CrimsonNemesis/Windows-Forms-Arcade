using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arcade_Game
{
    public partial class SelectForm : Form
    {
        private ProfileManager pM = new ProfileManager();

        public SelectForm()
        {
            InitializeComponent();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void RefreshProfilesList()
        {
            lstProfiles.DataSource = pM.GetAllProfiles();
            lstProfiles.DisplayMember = "ProfileName";
            lstProfiles.ValueMember = "Id";
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            MusicPlayer.Play(@"Resources\Musics&Sounds\TheTheme.wav");
            RefreshProfilesList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter a Name in the label between two buttons first !");
                return;
            }

            PlayerProfile theNewProfile = pM.CreateNewProfile(txtName.Text);
            txtName.Clear();
            RefreshProfilesList();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (lstProfiles.SelectedItem == null)
            {
                MessageBox.Show("Please Choose a Profile from the list first !");
                return;
            }

            PlayerProfile selectedProfile = (PlayerProfile)lstProfiles.SelectedItem;
            if (pM.SelectProfile(selectedProfile.Id))
            {
                MenuForm menu = new MenuForm();
                menu.Show();
                this.Hide();
            }
        }
    }
}