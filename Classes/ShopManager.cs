using Microsoft.EntityFrameworkCore;

namespace Arcade_Game;

public class ShopManager
{
    public List<ShopMenuViewModel> GetShopMenu()
    {
        using (var db = new GameDbContext())
        {
            var profile = db.PlayerProfiles.FirstOrDefault(p => p.Id == GameSession.CurrentPlayerId);
            if (profile == null) return new List<ShopMenuViewModel>();

            var allShopItems = db.ShopItems.ToList();
            var playerInventory = db.PlayerItems.Where(pi => pi.PlayerProfileId == profile.Id).ToList();

            var menuList = new List<ShopMenuViewModel>();

            foreach (var item in allShopItems)
            {
                var inventoryEntries = playerInventory.Where(inv => inv.ShopItemId == item.Id).ToList();
                bool isOwned = inventoryEntries.Any();
                int ownedQuantity = inventoryEntries.Count;
                int equippedQuantity = inventoryEntries.Count(inv => inv.IsEquipped);

                bool canAfford = (item.CurrencyType == CoinKind.Gold && profile.TotalGoldCoinValues >= item.Price) ||
                                 (item.CurrencyType == CoinKind.Silver && profile.TotalSilverCoinValues >= item.Price);

                menuList.Add(new ShopMenuViewModel
                {
                    ShopItemId = item.Id,
                    Name = item.Name,
                    Category = item.Category,
                    Price = item.Price,
                    CurrencyType = item.CurrencyType,
                    IsPurchased = isOwned,
                    IsEquipped = isOwned && inventoryEntries.Any(inv => inv.IsEquipped),
                    CanAfford = canAfford,
                    OwnedQuantity = ownedQuantity,
                    EquippedQuantity = equippedQuantity
                });
            }
            return menuList;
        }
    }

    public bool BuyItem(int itemId, out string message)
    {
        message = "";
        using (var db = new GameDbContext())
        {
            var item = db.ShopItems.FirstOrDefault(i => i.Id == itemId);
            var profile = db.PlayerProfiles.FirstOrDefault(p => p.Id == GameSession.CurrentPlayerId);

            if (item == null || profile == null) return false;

            // Block multiple purchases ONLY for non-consumables
            bool alreadyOwned = db.PlayerItems.Any(pi => pi.PlayerProfileId == profile.Id && pi.ShopItemId == item.Id);
            if (alreadyOwned && item.Category != "Consumable")
            {
                message = "You already own this item!";
                return false;
            }

            bool purchaseSuccessful = false;

            if (item.CurrencyType == CoinKind.Gold && profile.TotalGoldCoinValues >= item.Price)
            {
                profile.TotalGoldCoinValues -= item.Price;
                Player.TotalGoldCoinValues = profile.TotalGoldCoinValues;
                purchaseSuccessful = true;
            }
            else if (item.CurrencyType == CoinKind.Silver && profile.TotalSilverCoinValues >= item.Price)
            {
                profile.TotalSilverCoinValues -= item.Price;
                Player.TotalSilverCoinValues = profile.TotalSilverCoinValues;
                purchaseSuccessful = true;
            }

            if (purchaseSuccessful)
            {
                db.PlayerItems.Add(new PlayerItem
                {
                    PlayerProfileId = profile.Id,
                    ShopItemId = item.Id,
                    IsEquipped = false
                });

                db.SaveChanges();
                message = "Item Bought Successfully!";
                return true;
            }

            message = "Not Enough Coins!";
            return false;
        }
    }

    public void ToggleEquipItem(int itemId)
    {
        using (var db = new GameDbContext())
        {
            var itemDefinition = db.ShopItems.FirstOrDefault(i => i.Id == itemId);
            if (itemDefinition == null || itemDefinition.Category == "Consumable") return;

            var inventoryItems = db.PlayerItems
                .Where(pi => pi.PlayerProfileId == GameSession.CurrentPlayerId && pi.ShopItemId == itemId)
                .ToList();

            if (!inventoryItems.Any()) return;

            bool isCurrentlyEquipped = inventoryItems.Any(i => i.IsEquipped);

            if (isCurrentlyEquipped)
            {
                // Unequip logic
                foreach (var invItem in inventoryItems) invItem.IsEquipped = false;
            }
            else
            {
                // Equip logic: First unequip everything else in the same category
                var itemsInSameCategory = db.PlayerItems
                    .Include(pi => pi.ShopItem)
                    .Where(pi => pi.PlayerProfileId == GameSession.CurrentPlayerId && pi.ShopItem.Category == itemDefinition.Category)
                    .ToList();

                foreach (var item in itemsInSameCategory) item.IsEquipped = false;

                // Equip the target item
                inventoryItems.First().IsEquipped = true;
            }
            db.SaveChanges();
        }
    }

    public void AdjustConsumableEquip(int itemId, int amount)
    {
        using (var db = new GameDbContext())
        {
            var inventoryItems = db.PlayerItems
                .Where(pi => pi.PlayerProfileId == GameSession.CurrentPlayerId && pi.ShopItemId == itemId)
                .ToList();

            if (amount > 0) // Try to equip one more
            {
                var unequipped = inventoryItems.FirstOrDefault(i => !i.IsEquipped);
                if (unequipped != null) unequipped.IsEquipped = true;
            }
            else if (amount < 0) // Try to unequip one
            {
                var equipped = inventoryItems.FirstOrDefault(i => i.IsEquipped);
                if (equipped != null) equipped.IsEquipped = false;
            }
            db.SaveChanges();
        }
    }
}