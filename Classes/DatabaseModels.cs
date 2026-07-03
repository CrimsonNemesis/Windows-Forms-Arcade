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
    public int ExtraLives { get; set; }
}

public class ShopItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; } // Skin, Bullet, Theme, Consumable
    public int Price { get; set; }
    public bool IsPurchased { get; set; }
    public bool IsEquipped { get; set; }
    public CoinKind CurrencyType { get; set; }
}

public class GameDbContext : DbContext
{
    public DbSet<PlayerProfile> PlayerProfiles { get; set; }
    public DbSet<ShopItem> ShopItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=GameData.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ShopItem>().HasData(
            new ShopItem { Id = 1, Name = "Spaceship 2", Category = "Skin", Price = 500, IsPurchased = false, IsEquipped = false, CurrencyType = CoinKind.Gold },
            new ShopItem { Id = 2, Name = "Green Bullets", Category = "Bullet", Price = 300, IsPurchased = false, IsEquipped = false, CurrencyType = CoinKind.Silver },
            new ShopItem { Id = 3, Name = "Neon Background", Category = "Theme", Price = 400, IsPurchased = false, IsEquipped = false, CurrencyType = CoinKind.Gold },
            new ShopItem { Id = 4, Name = "Extra Life", Category = "Consumable", Price = 150, IsPurchased = false, IsEquipped = false, CurrencyType = CoinKind.Silver }
        );
    }
}