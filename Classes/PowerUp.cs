namespace Arcade_Game;

public enum PowerUpType { TripleShot, Shield, HealthPack, FireRateBooster }
public record PowerUpSpecification(PowerUpType Type) : IDropSpecification;

internal class PowerUp : Collectable
{
    public PowerUpType Type { get; }

    public PowerUp(PowerUpType type, int startX, int startY)
        : base(startX, startY)
    {
        this.Type = type;
        this.Image = GameAssets.QuestionMark;
    }

    public override void ApplyEffect()
    {
        Player.ActivatePowerUp(this.Type);
    }
}
