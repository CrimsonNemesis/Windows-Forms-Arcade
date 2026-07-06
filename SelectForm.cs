using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arcade_Game
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
                return;

            using (var db = new GameDbContext())
            {
                var profile = new PlayerProfile
                {
                    ProfileName = txtName.Text,
                    HighScore = 0,
                    TotalGoldCoinValues = 0,
                    TotalSilverCoinValues = 0,
                    ExtraLives = 0
                };

                db.PlayerProfiles.Add(profile);
                db.SaveChanges();
            }

            using (var db = new GameDbContext())
            {
                lstProfiles.DataSource = db.PlayerProfiles.ToList();
                lstProfiles.DisplayMember = "ProfileName";
            }
        }





        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (lstProfiles.SelectedItem == null)
                return;

            PlayerProfile profile = (PlayerProfile)lstProfiles.SelectedItem;

            GameSession.CurrentPlayerId = profile.Id;

            MenuForm menu = new MenuForm();
            menu.Show();

            this.Hide();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            MusicPlayer.Play(@"Resources\Musics&Sounds\TheTheme.wav");
            using (var db = new GameDbContext())
            {
                lstProfiles.DataSource = db.PlayerProfiles.ToList();
                lstProfiles.DisplayMember = "ProfileName";
            }
        }

        
    }
}
