namespace Arcade_Game;

public class ShopManager
{
    public bool BuyItem(int itemId)
    {
        using (var db = new GameDbContext())
        {
            var item = db.ShopItems.FirstOrDefault(i => i.Id == itemId);
            var profile = db.PlayerProfiles.FirstOrDefault(p => p.Id == GameSession.CurrentPlayerId);

            if (item == null || profile == null) return false;

            if (item.IsPurchased && item.Category != "Consumable") return false;

            bool purchaseSuccessful = false;

            if (item.CurrencyType == CoinKind.Gold && profile.TotalGoldCoinValues >= item.Price)
            {
                profile.TotalGoldCoinValues -= item.Price;
                purchaseSuccessful = true;
            }
            else if (item.CurrencyType == CoinKind.Silver && profile.TotalSilverCoinValues >= item.Price)
            {
                profile.TotalSilverCoinValues -= item.Price;
                purchaseSuccessful = true;
            }

            if (purchaseSuccessful)
            {
                if (item.Category == "Consumable")
                    profile.ExtraLives += 1;
                else
                    item.IsPurchased = true;

                db.SaveChanges();
                return true;
            }

            return false;
        }
    }

    public void EquipItem(int itemId)
    {
        using (var db = new GameDbContext())
        {
            var itemToEquip = db.ShopItems.FirstOrDefault(i => i.Id == itemId);

            if (itemToEquip != null && itemToEquip.IsPurchased && itemToEquip.Category != "Consumable")
            {
                var sameCategoryItems = db.ShopItems.Where(i => i.Category == itemToEquip.Category).ToList();
                foreach (var item in sameCategoryItems)
                    item.IsEquipped = false;

                itemToEquip.IsEquipped = true;
                db.SaveChanges();
            }
        }
    }
}