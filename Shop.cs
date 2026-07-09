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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private readonly ShopManager shopManager = new ShopManager();

        private const int NeonTheme = 1;
        private const int GreenBullet = 2;
        private const int SpaceShip2 = 3;
        private const int ExtraLife = 4;

        private bool isUpdatingUi = false;

        private void ShopForm_Load(object sender, EventArgs e)
        {
            Player.LoadPlayerDataFromDb();

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

        private void RefreshShop()
        {
            List<ShopMenuViewModel> shopMenu = shopManager.GetShopMenu();

            UpdateItemUi(shopMenu, NeonTheme, AstBackBuybtn, AstBackEquipbtn);
            UpdateItemUi(shopMenu, GreenBullet, SpePlaBullBuybtn, SpePlaBullEqubtn);
            UpdateItemUi(shopMenu, SpaceShip2, SpePlaySkinBuybtn, SpePlaySkinEqubtn);
            UpdateItemUi(shopMenu, ExtraLife, OneExLifeBuybtn, OneExLifeEqubtn);

            goldCoinlbl.Text = $"{Player.TotalGoldCoinValues}";
            silverCoinlbl.Text = $"{Player.TotalSilverCoinValues}";
        }

        private void UpdateItemUi(List<ShopMenuViewModel> menuList, int itemId, CheckBox buyBox, CheckBox equipBox)
        {
            var itemStatus = menuList.FirstOrDefault(i => i.ShopItemId == itemId);
            if (itemStatus == null) return;

            if (itemStatus.IsPurchased)
            {
                buyBox.Checked = true;
                buyBox.Enabled = false;

                equipBox.Enabled = true;
                equipBox.Checked = itemStatus.IsEquipped;
            }
            else
            {
                buyBox.Enabled = true;
                buyBox.Checked = false;

                equipBox.Enabled = false;
                equipBox.Checked = false;
            }
        }





        private void HandleBuyAction(int itemId, CheckBox currentBox)
        {
            if (shopManager.BuyItem(itemId))
            {
                MessageBox.Show("Item Bought Successfully !");
                RefreshShop();
            }
            else
            {
                isUpdatingUi = true;
                currentBox.Checked = false;
                isUpdatingUi = false;
                MessageBox.Show("Not Enough Coins !");
            }
        }

        private void HandleEquipAction(int itemId)
        {
            shopManager.EquipItem(itemId);
            RefreshShop();
        }

        private void AstBackBuybtn_CheckedChanged(object sender, EventArgs e)
        {
            if (isUpdatingUi || !AstBackBuybtn.Checked) return;
            HandleBuyAction(NeonTheme, AstBackBuybtn);
        }

        private void AstBackEquipbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (isUpdatingUi || !AstBackEquipbtn.Checked) return;
            HandleEquipAction(NeonTheme);
        }

        private void SpePlaBullBuybtn_CheckedChanged(object sender, EventArgs e)
        {
            if (isUpdatingUi || !SpePlaBullBuybtn.Checked) return;
            HandleBuyAction(GreenBullet, SpePlaBullBuybtn);
        }

        private void SpePlaBullEqubtn_CheckedChanged(object sender, EventArgs e)
        {
            if (isUpdatingUi || !SpePlaBullEqubtn.Checked) return;
            HandleEquipAction(GreenBullet);
        }

        private void SpePlaySkinBuybtn_CheckedChanged(object sender, EventArgs e)
        {
            if (isUpdatingUi || !SpePlaySkinBuybtn.Checked) return;
            HandleBuyAction(SpaceShip2, SpePlaySkinBuybtn);
        }

        private void SpePlaySkinEqubtn_CheckedChanged(object sender, EventArgs e)
        {
            if (isUpdatingUi || !SpePlaySkinEqubtn.Checked) return;
            HandleEquipAction(SpaceShip2);
        }

        private void OneExLifeBuybtn_CheckedChanged(object sender, EventArgs e)
        {
            if (isUpdatingUi || !OneExLifeBuybtn.Checked) return;
            HandleBuyAction(ExtraLife, OneExLifeBuybtn);
        }

        private void OneExLifeEqubtn_CheckedChanged(object sender, EventArgs e)
        {
            if (isUpdatingUi || !OneExLifeEqubtn.Checked) return;
            HandleEquipAction(ExtraLife);
        }
    }
}