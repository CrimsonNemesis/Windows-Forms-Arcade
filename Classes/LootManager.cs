namespace Arcade_Game;

public static class LootManager
{
    private class LootEntry
    {
        public IDropSpecification? Drop { get; }
        public int Weight { get; }

        public LootEntry(IDropSpecification? drop, int weight)
        {
            Drop = drop;
            Weight = weight;
        }
    }

    private static readonly List<LootEntry> lootEntries = new List<LootEntry>
    {
        new LootEntry(new PowerUpSpecification(PowerUpType.TripleShot), 1),
        new LootEntry(new PowerUpSpecification(PowerUpType.Shield), 1),
        new LootEntry(new PowerUpSpecification(PowerUpType.HealthPack), 1),
        new LootEntry(new PowerUpSpecification(PowerUpType.FireRateBooster), 1),
        new LootEntry(new CoinSpecification(5, CoinKind.Gold), 2),
        new LootEntry(new CoinSpecification(1, CoinKind.Gold), 3),
        new LootEntry(new CoinSpecification(5, CoinKind.Silver), 4),
        new LootEntry(new CoinSpecification(1, CoinKind.Silver), 5),
        new LootEntry(null, 7)
    };

    private static readonly int totalWeight = lootEntries.Sum(e => e.Weight);

    public static IDropSpecification? GetRandomDrop()
    {
        int roll = Random.Shared.Next(0, totalWeight);
        int currentWeight = 0;

        foreach (var entry in lootEntries)
        {
            currentWeight += entry.Weight;

            if (roll < currentWeight)
                return entry.Drop;
        }

        return null;
    }
}