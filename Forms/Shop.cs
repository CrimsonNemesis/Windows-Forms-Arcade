namespace Arcade_Game;

public partial class Shop : Base
{
    public Shop()
    {
        InitializeComponent();
        this.FullScreen();
    }

    private readonly ShopManager shopManager = new ShopManager();

    private const int NeonTheme = 1;
    private const int GreenBullet = 2;
    private const int SpaceShip2 = 3;
    private const int ExtraLife = 4;

    private void ShopForm_Load(object sender, EventArgs e)
    {
        Player.LoadPlayerDataFromDb();
        RefreshShop();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        NavigationManager.ShowForm(NavigationManager.MainMenuForm);
    }

    private void RefreshShop()
    {
        List<ShopMenuViewModel> shopMenu = shopManager.GetShopMenu();

        UpdateNormalItemUi(shopMenu, NeonTheme, AstBackBtn);
        UpdateNormalItemUi(shopMenu, GreenBullet, SpePlaBullBtn);
        UpdateNormalItemUi(shopMenu, SpaceShip2, SpePlaySkinBtn);
        UpdateConsumableUi(shopMenu, ExtraLife, OneExLifeBuyBtn, OneExLifePlusBtn, OneExLifeMinusBtn, ExLivesBoughtLbl, ExLivesEquippedLbl);

        goldCoinlbl.Text = $"{Player.TotalGoldCoinValues}";
        silverCoinlbl.Text = $"{Player.TotalSilverCoinValues}";
    }

    private void UpdateNormalItemUi(List<ShopMenuViewModel> menuList, int itemId, Button actionBtn)
    {
        var item = menuList.FirstOrDefault(i => i.ShopItemId == itemId);
        if (item == null) return;

        if (!item.IsPurchased)
        {
            actionBtn.Text = "Buy";
            actionBtn.BackColor = Color.LightGray;
            actionBtn.ForeColor = Color.Black;
        }
        else if (!item.IsEquipped)
        {
            actionBtn.Text = "Equip";
            actionBtn.BackColor = Color.DodgerBlue;
            actionBtn.ForeColor = Color.White;
        }
        else
        {
            actionBtn.Text = "Unequip";
            actionBtn.BackColor = Color.Crimson;
            actionBtn.ForeColor = Color.White;
        }
    }

    private void UpdateConsumableUi(List<ShopMenuViewModel> menuList, int itemId, Button buyBtn, Button plusBtn, Button minusBtn, Label boughtLbl, Label equippedLbl)
    {
        var item = menuList.FirstOrDefault(i => i.ShopItemId == itemId);
        if (item == null) return;

        boughtLbl.Text = $"Bought: {item.OwnedQuantity}";
        equippedLbl.Text = $"Equipped: {item.EquippedQuantity}";

        plusBtn.Enabled = item.EquippedQuantity < item.OwnedQuantity;
        minusBtn.Enabled = item.EquippedQuantity > 0;
    }

    private void HandleNormalItemClick(int itemId)
    {
        var item = shopManager.GetShopMenu().FirstOrDefault(i => i.ShopItemId == itemId);
        if (item == null) return;

        if (!item.IsPurchased)
        {
            if (shopManager.BuyItem(itemId, out string message))
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(message, "Purchase Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
            shopManager.ToggleEquipItem(itemId);
        }
        RefreshShop();
    }

    private void AstBackBtn_Click(object sender, EventArgs e)
    {
        HandleNormalItemClick(NeonTheme);
    }

    private void SpePlaBullBtn_Click(object sender, EventArgs e)
    {
        HandleNormalItemClick(GreenBullet);
    }

    private void SpePlaySkinBtn_Click(object sender, EventArgs e)
    {
        HandleNormalItemClick(SpaceShip2);
    }

    private void OneExLifeBuyBtn_Click(object sender, EventArgs e)
    {
        if (!shopManager.BuyItem(ExtraLife, out string message))
            MessageBox.Show(message, "Purchase Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        RefreshShop();
    }

    private void OneExLifePlusBtn_Click(object sender, EventArgs e)
    {
        shopManager.AdjustConsumableEquip(ExtraLife, 1);
        RefreshShop();
    }

    private void OneExLifeMinusBtn_Click(object sender, EventArgs e)
    {
        shopManager.AdjustConsumableEquip(ExtraLife, -1);
        RefreshShop();
    }
}