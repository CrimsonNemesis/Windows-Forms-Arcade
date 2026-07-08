using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Arcade_Game;

public class ShopManager
{
    // Generates a complete list of items, merging catalog data with the current player's inventory
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
                var inventoryEntry = playerInventory.FirstOrDefault(inv => inv.ShopItemId == item.Id);
                bool isOwned = inventoryEntry != null;

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
                    IsEquipped = isOwned && inventoryEntry.IsEquipped,
                    CanAfford = canAfford
                });
            }
            return menuList;
        }
    }

    public bool BuyItem(int itemId)
    {
        using (var db = new GameDbContext())
        {
            var item = db.ShopItems.FirstOrDefault(i => i.Id == itemId);
            var profile = db.PlayerProfiles.FirstOrDefault(p => p.Id == GameSession.CurrentPlayerId);

            if (item == null || profile == null) return false;

            bool alreadyOwned = db.PlayerItems.Any(pi => pi.PlayerProfileId == profile.Id && pi.ShopItemId == item.Id);
            if (alreadyOwned) return false;

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
                db.PlayerItems.Add(new PlayerItem
                {
                    PlayerProfileId = profile.Id,
                    ShopItemId = item.Id,
                    IsEquipped = false
                });

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
            var inventoryItem = db.PlayerItems
                .Include(pi => pi.ShopItem)
                .FirstOrDefault(pi => pi.PlayerProfileId == GameSession.CurrentPlayerId && pi.ShopItemId == itemId);

            if (inventoryItem != null)
            {
                var categoryToEquip = inventoryItem.ShopItem.Category;

                // Unequip any currently equipped item in the SAME category for this player
                var itemsInSameCategory = db.PlayerItems
                    .Include(pi => pi.ShopItem)
                    .Where(pi => pi.PlayerProfileId == GameSession.CurrentPlayerId && pi.ShopItem.Category == categoryToEquip)
                    .ToList();

                foreach (var item in itemsInSameCategory)
                {
                    item.IsEquipped = false;
                }

                // Equip the selected item
                inventoryItem.IsEquipped = true;
                db.SaveChanges();
            }
        }
    }
}