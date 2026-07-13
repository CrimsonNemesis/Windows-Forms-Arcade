using Arcade_Game;

internal static class AssetManager
{
    public static Image Player
    {
        get
        {
            if (Arcade_Game.Player.HasSpecialSkin)
            {
                return GameSettings.PixelMode ? GameAssets.PixelSpecialPlayer : GameAssets.NormalSpecialPlayer;
            }
            return GameSettings.PixelMode ? GameAssets.PixelPlayer : GameAssets.NormalPlayer;
        }
    }

    public static Image SpecialPlayer =>
        GameSettings.PixelMode
        ? GameAssets.PixelSpecialPlayer
        : GameAssets.NormalSpecialPlayer;

    public static Image StandardEnemy =>
        GameSettings.PixelMode
        ? GameAssets.PixelEnemyStandard
        : GameAssets.NormalEnemyStandard;

    public static Image ShooterEnemy =>
        GameSettings.PixelMode
        ? GameAssets.PixelEnemyShooter
        : GameAssets.NormalEnemyShooter;

    public static Image ScoutEnemy =>
        GameSettings.PixelMode
        ? GameAssets.PixelEnemyScout
        : GameAssets.NormalEnemyScout;

    public static Image TerroristEnemy =>
        GameSettings.PixelMode
        ? GameAssets.PixelEnemyTerrorist
        : GameAssets.NormalEnemyTerrorist;

    public static Image TankEnemy =>
        GameSettings.PixelMode
        ? GameAssets.PixelEnemyTank
        : GameAssets.NormalEnemyTank;

    public static Image PlayerBullet
    {
        get
        {
            if (Arcade_Game.Player.HasSpecialBullet)
            {
                return GameSettings.PixelMode ? GameAssets.SpecialPixelPlayerBullet : GameAssets.SpecialNormalPlayerBullet;
            }
            return GameSettings.PixelMode ? GameAssets.PixelBulletPlayer : GameAssets.NormalBulletPlayer;
        }
    }

    public static Image EnemyBullet =>
        GameSettings.PixelMode
        ? GameAssets.PixelBulletEnemy
        : GameAssets.NormalBulletEnemy;

    public static Image Gold1Coin =>
        GameSettings.PixelMode
        ? GameAssets.PixelGolden1Coin
        : GameAssets.NormalGolden1Coin;

    public static Image Gold5Coin =>
        GameSettings.PixelMode
        ? GameAssets.PixelGolden5Coin
        : GameAssets.NormalGolden5Coin;

    public static Image Silver1Coin =>
        GameSettings.PixelMode
        ? GameAssets.PixelSilver1Coin
        : GameAssets.NormalSilver1Coin;

    public static Image Silver5Coin =>
        GameSettings.PixelMode
        ? GameAssets.PixelSilver5Coin
        : GameAssets.NormalSilver5Coin;
}