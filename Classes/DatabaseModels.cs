using Microsoft.EntityFrameworkCore;

namespace Arcade_Game;

public static class GameSession
{
    public static int CurrentPlayerId { get; set; } = 1;
}

public class PlayerProfile
{
    public int Id { get; set; }
    public string ProfileName { get; set; }
    public int TotalGoldCoinValues { get; set; }
    public int TotalSilverCoinValues { get; set; }
    public int HighScore { get; set; }

    public List<PlayerItem> Inventory { get; set; } = new();
}

public class ShopItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public int Price { get; set; }
    public CoinKind CurrencyType { get; set; }
}

public class PlayerItem
{
    public int Id { get; set; }
    public int PlayerProfileId { get; set; }
    public PlayerProfile PlayerProfile { get; set; }

    public int ShopItemId { get; set; }
    public ShopItem ShopItem { get; set; }

    public bool IsEquipped { get; set; }
}

public class ShopMenuViewModel
{
    public int ShopItemId { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public int Price { get; set; }
    public CoinKind CurrencyType { get; set; }
    public bool IsPurchased { get; set; }
    public bool IsEquipped { get; set; }
    public bool CanAfford { get; set; }
    public int OwnedQuantity { get; set; }
    public int EquippedQuantity { get; set; }
}

public class GameDbContext : DbContext
{
    public DbSet<PlayerProfile> PlayerProfiles { get; set; }
    public DbSet<ShopItem> ShopItems { get; set; }
    public DbSet<PlayerItem> PlayerItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=..\..\..\GameData.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ShopItem>().HasData(
            new ShopItem { Id = 3, Name = "Spaceship 2", Category = "Skin", Price = 500, CurrencyType = CoinKind.Gold },
            new ShopItem { Id = 2, Name = "Green Bullets", Category = "Bullet", Price = 300, CurrencyType = CoinKind.Silver },
            new ShopItem { Id = 1, Name = "Neon Background", Category = "Theme", Price = 400, CurrencyType = CoinKind.Gold },
            new ShopItem { Id = 4, Name = "Extra Life", Category = "Consumable", Price = 150, CurrencyType = CoinKind.Silver }
        );
    }
}