namespace Arcade_Game;

public enum CoinKind { Silver, Gold }

public record CoinSpecification(int Value, CoinKind Kind) : IDropSpecification;

internal class Coin : Collectable
{
    public CoinKind Kind { get; }
    public int Value { get; }

    public Coin(int value, CoinKind kind, int startX, int startY)
        : base(startX, startY)
    {
        this.Value = value;
        this.Kind = kind;

        if (value == 1 && kind == CoinKind.Silver) this.Image = AssetManager.Silver1Coin;
        else if (value == 5 && kind == CoinKind.Silver) this.Image = AssetManager.Silver5Coin;
        else if (value == 1 && kind == CoinKind.Gold) this.Image = AssetManager.Gold1Coin;
        else if (value == 5 && kind == CoinKind.Gold) this.Image = AssetManager.Gold5Coin;
    }

    public override void ApplyEffect()
    {
        if (Kind == CoinKind.Silver)
        {
            Player.TotalSilverCoinValues += Value;
            Player.MatchSilverCoins += Value;
        }
        else if (Kind == CoinKind.Gold)
        {
            Player.TotalGoldCoinValues += Value;
            Player.MatchGoldCoins += Value;
        }
    }
}