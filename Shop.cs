using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arcade_Game
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private readonly ShopManager shopManager = new ShopManager();

        private const int AsteroidTheme = 3;
        private const int GreenBullet = 2;
        private const int SpaceShip2 = 1;
        private const int ExtraLife = 4;


        private void RefreshShop()
        {
            using (var db = new GameDbContext())
            {
                var profile = db.PlayerProfiles
                    .First(p => p.Id == GameSession.CurrentPlayerId);

                goldCoinlbl.Text = profile.TotalGoldCoinValues.ToString();
                silverCoinlbl.Text = profile.TotalSilverCoinValues.ToString();

                var items = db.ShopItems.ToList();

                foreach (var item in items)
                {
                    switch (item.Id)
                    {
                        case SpaceShip2:
                            SpePlaySkinBuybtn.Checked = item.IsPurchased;
                            SpePlaySkinEqubtn.Checked = item.IsEquipped;
                            SpePlaySkinEqubtn.Enabled = item.IsPurchased;
                            break;

                        case GreenBullet:
                            SpePlaBullBuybtn.Checked = item.IsPurchased;
                            SpePlaBullEqubtn.Checked = item.IsEquipped;
                            SpePlaBullEqubtn.Enabled = item.IsPurchased;
                            break;

                        case AsteroidTheme:
                            AstBackBuybtn.Checked = item.IsPurchased;
                            AstBackEquipbtn.Checked = item.IsEquipped;
                            AstBackEquipbtn.Enabled = item.IsPurchased;
                            break;

                        case ExtraLife:
                            OneExLifeBuybtn.Enabled = profile.ExtraLives == 0;
                            OneExLifeEqubtn.Enabled = profile.ExtraLives > 0;
                            OneExLifeEqubtn.Checked = profile.ExtraLifeEquipped;
                            break;
                    }
                }
            }
        }
        private void ShopForm_Load(object sender, EventArgs e)
        {
             RefreshShop();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
        



        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm hello = new MenuForm();
            hello.Show();
            this.Hide();
        }

        private void AstBackBuybtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!AstBackBuybtn.Checked)
                return;

            if (!shopManager.BuyItem(AsteroidTheme))
                AstBackBuybtn.Checked = false;

            RefreshShop();
        }

        private void AstBackEquipbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!AstBackEquipbtn.Checked)
                return;

            shopManager.EquipItem(AsteroidTheme);

            RefreshShop();
        }

        private void SpePlaBullBuybtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!SpePlaBullBuybtn.Checked)
                return;

            if (!shopManager.BuyItem(GreenBullet))
                SpePlaBullBuybtn.Checked = false;

            RefreshShop();
        }

        private void SpePlaBullEqubtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!SpePlaBullEqubtn.Checked)
                return;

            shopManager.EquipItem(GreenBullet);

            RefreshShop();
        }

        private void SpePlaySkinBuybtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!SpePlaySkinBuybtn.Checked)
                return;

            if (!shopManager.BuyItem(SpaceShip2))
                SpePlaySkinBuybtn.Checked = false;

            RefreshShop();
        }

        private void SpePlaySkinEqubtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!SpePlaySkinEqubtn.Checked)
                return;

            shopManager.EquipItem(SpaceShip2);

            RefreshShop();
        }

        private void OneExLifeBuybtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!OneExLifeBuybtn.Checked)
                return;

            if (!shopManager.BuyItem(ExtraLife))
                OneExLifeBuybtn.Checked = false;

            RefreshShop();
        }

        private void OneExLifeEqubtn_CheckedChanged(object sender, EventArgs e)
        {
            using (var db = new GameDbContext())
            {
                var profile = db.PlayerProfiles
                                .First(p => p.Id == GameSession.CurrentPlayerId);

                if (OneExLifeEqubtn.Checked)
                {
                    if (profile.ExtraLives <= 0)
                    {
                        OneExLifeEqubtn.Checked = false;
                        return;
                    }

                    profile.ExtraLifeEquipped = true;
                }
                else
                {
                    profile.ExtraLifeEquipped = false;
                }

                db.SaveChanges();
                RefreshShop();
            }
        }
    }
}
