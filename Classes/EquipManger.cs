using System;
using System.Collections.Generic;

namespace Arcade_Game;

public class EquipmentManager
{
    private readonly Dictionary<int, Action> _itemActions;

    public EquipmentManager()
    {
        // Map Database IDs to C# Functions
        _itemActions = new Dictionary<int, Action>
        {
            { 1, EquipSpaceship2 },
            { 2, EquipGreenBullets },
            { 3, ApplyNeonBackground },
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

    // --- GAMEPLAY LOGIC ---
    private void EquipSpaceship2()
    {
        Console.WriteLine("Spaceship 2 active: Updating player sprite.");
    }

    private void EquipGreenBullets()
    {
        Console.WriteLine("Green Bullets active: Setting damage type to toxic.");
    }

    private void ApplyNeonBackground()
    {
        Console.WriteLine("Neon Theme active: Changing level background.");
    }

    private void EquipExtraLife()
    {
        Console.WriteLine("Extra Life Perk active: Player will revive once upon dying.");
    }
}