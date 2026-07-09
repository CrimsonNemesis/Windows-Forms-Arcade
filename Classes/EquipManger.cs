using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Arcade_Game;

public class EquipmentManager
{
    private readonly Dictionary<int, Action> _itemActions;

    public EquipmentManager()
    {
        _itemActions = new Dictionary<int, Action>
        {
            { 1, ApplyNeonBackground },
            { 2, EquipGreenBullets },
            { 3, EquipSpaceship2 },
            { 4, EquipExtraLife }
        };
    }

    public void TriggerEquipAction(int itemId)
    {
        if (_itemActions.ContainsKey(itemId))
        {
            _itemActions[itemId].Invoke();
        }
    }


    private void EquipSpaceship2()
    {
        UpdateEquipmentInDatabase(3, "Skin");
    }

    private void EquipGreenBullets()
    {
        UpdateEquipmentInDatabase(2, "Bullet");
    }

    private void ApplyNeonBackground()
    {
        UpdateEquipmentInDatabase(1, "Theme");
    }

    private void EquipExtraLife()
    {
        using (var db = new GameDbContext())
        {
            int currentPlayerId = GameSession.CurrentPlayerId;

            var playerItem = db.PlayerItems
                .FirstOrDefault(pi => pi.PlayerProfileId == currentPlayerId && pi.ShopItemId == 4);

            if (playerItem != null)
            {
                playerItem.IsEquipped = true;
                db.SaveChanges();
            }
        }
    }

    private void UpdateEquipmentInDatabase(int shopItemId, string category)
    {
        using (var db = new GameDbContext())
        {
            int currentPlayerId = GameSession.CurrentPlayerId;

            var equippedItemsInSubcategory = db.PlayerItems
                .Include(pi => pi.ShopItem)
                .Where(pi => pi.PlayerProfileId == currentPlayerId && pi.ShopItem.Category == category);

            foreach (var item in equippedItemsInSubcategory)
            {
                item.IsEquipped = false;
            }

            var targetItem = db.PlayerItems
                .FirstOrDefault(pi => pi.PlayerProfileId == currentPlayerId && pi.ShopItemId == shopItemId);

            if (targetItem != null)
            {
                targetItem.IsEquipped = true;
            }

            db.SaveChanges();
        }
    }
}