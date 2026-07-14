using System.ComponentModel;

namespace Arcade_Game;

internal class Player : GameObject
{
    private double exactX;
    private double exactY;
    public static List<PlayerBullet> bullets = new();

    public static int TotalSilverCoinValues = 0;
    public static int TotalGoldCoinValues = 0;
    public static int CurrentScore = 0;
    public static int MatchGoldCoins = 0;
    public static int MatchSilverCoins = 0;
    public static int HighScore { get; set; }

    public static bool HasSpecialTheme = false;
    public static bool HasSpecialBullet = false;
    public static bool HasSpecialSkin = false;
    public static bool tripleShoot = false;

    public DateTime TripleShotEndTime { get; private set; } = DateTime.MinValue;
    public DateTime ShieldEndTime { get; private set; } = DateTime.MinValue;
    public DateTime FireRateEndTime { get; private set; } = DateTime.MinValue;
    public bool IsShielded => DateTime.Now < ShieldEndTime;
    public static Player Instance { get; private set; }

    private DateTime lastTimeShot = DateTime.MinValue;
    private const int CoolDown = 500;

    private DateTime lastTimeImpactWithEnemy = DateTime.MinValue;
    private const int DelayAfterImpact = 500;

    bool goLeft, goRight, goUp, goDown, isShooting;
    int windowWidth, windowHeight;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Speed { get; set; } = 10;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int HealthPoint;

    public Player(Image skin)
    {
        Instance = this;
        windowWidth = Game.Instance.ClientSize.Width;
        windowHeight = Game.Instance.ClientSize.Height;

        this.Image = skin;
        this.Size = new Size(90, 90);
        this.Location = new Point(windowWidth / 2 - 45, windowHeight - 90 - 15);
        this.exactX = this.Left;
        this.exactY = this.Top;
        int extraLivesCount = ConsumeEquippedExtraLives();
        HealthPoint = 3 + extraLivesCount;
    }

    private int ConsumeEquippedExtraLives()
    {
        using (var db = new GameDbContext())
        {
            var equippedLives = db.PlayerItems.Where(pi =>
                pi.PlayerProfileId == GameSession.CurrentPlayerId &&
                pi.ShopItemId == 4 &&
                pi.IsEquipped).ToList();

            int count = equippedLives.Count;

            if (count > 0)
            {
                db.PlayerItems.RemoveRange(equippedLives);
                db.SaveChanges();
            }

            return count;
        }
    }

    public static void SavePlayerDataToDb()
    {
        using (var db = new GameDbContext())
        {
            var activeProfile = db.PlayerProfiles.FirstOrDefault(p => p.Id == GameSession.CurrentPlayerId);
            if (activeProfile != null)
            {
                activeProfile.TotalGoldCoinValues = Player.TotalGoldCoinValues;
                activeProfile.TotalSilverCoinValues = Player.TotalSilverCoinValues;

                activeProfile.HighScore = Math.Max(Player.HighScore, activeProfile.HighScore);

                db.SaveChanges();
            }
        }
    }

    public void KeyDown(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Left) goLeft = true;
        if (e.KeyCode == Keys.Right) goRight = true;
        if (e.KeyCode == Keys.Up) goUp = true;
        if (e.KeyCode == Keys.Down) goDown = true;
        if (e.KeyCode == Keys.Space) isShooting = true;
    }

    public void KeyUp(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Left) goLeft = false;
        if (e.KeyCode == Keys.Right) goRight = false;
        if (e.KeyCode == Keys.Up) goUp = false;
        if (e.KeyCode == Keys.Down) goDown = false;
        if (e.KeyCode == Keys.Space) isShooting = false;
    }

    public void Update(double deltaTime)
    {
        double moveAmount = Speed * deltaTime * 60.0;

        if (goLeft && exactX >= 15) exactX -= moveAmount;
        if (goRight && exactX <= windowWidth - 90 - 15) exactX += moveAmount;
        if (goUp && exactY >= 15) exactY -= moveAmount;
        if (goDown && exactY <= windowHeight - 90 - 15) exactY += moveAmount;

        this.Left = (int)Math.Round(exactX);
        this.Top = (int)Math.Round(exactY);

        if (isShooting && this.CanShoot()) Shoot(0, 1);
        if (isShooting && this.CanShoot() && tripleShoot)
        {
            Shoot(-1, 1);
            Shoot(1, 1);
        }
    }

    public void ResetControls()
    {
        goLeft = false;
        goRight = false;
        goUp = false;
        goDown = false;
        isShooting = false;
    }

    public bool CanShoot()
    {
        int currentCooldown = (DateTime.Now < FireRateEndTime) ? (CoolDown / 2) : CoolDown;

        if ((DateTime.Now - this.lastTimeShot).TotalMilliseconds >= currentCooldown)
        {
            this.lastTimeShot = DateTime.Now;
            return true;
        }
        return false;
    }

    public bool CanGetHitByImpact()
    {
        if ((DateTime.Now - this.lastTimeImpactWithEnemy).TotalMilliseconds >= DelayAfterImpact)
        {
            this.lastTimeImpactWithEnemy = DateTime.Now;
            return true;
        }
        return false;
    }

    private void Shoot(int dirX, int dirY)
    {
        SoundEffects.Play(GameAssets.Shoot);

        if (DateTime.Now < TripleShotEndTime)
        {
            bullets.Add(new PlayerBullet(this, dirX, dirY, 15));
            bullets.Add(new PlayerBullet(this, -1, 1, 15));
            bullets.Add(new PlayerBullet(this, 1, 1, 15));
        }
        else
        {
            bullets.Add(new PlayerBullet(this, dirX, dirY, 15));
        }
    }

    public static void ActivatePowerUp(PowerUpType type)
    {
        if (Instance == null) return;

        switch (type)
        {
            case PowerUpType.TripleShot:
                Instance.TripleShotEndTime = DateTime.Now.AddSeconds(10);
                break;
            case PowerUpType.Shield:
                Instance.ShieldEndTime = DateTime.Now.AddSeconds(5);
                break;
            case PowerUpType.HealthPack:
                Instance.HealthPoint++;
                break;
            case PowerUpType.FireRateBooster:
                Instance.FireRateEndTime = DateTime.Now.AddSeconds(10);
                break;
        }
    }

    public static void LoadPlayerDataFromDb()
    {
        using (var db = new GameDbContext())
        {
            var activeProfile = db.PlayerProfiles.FirstOrDefault(p => p.Id == GameSession.CurrentPlayerId);
            if (activeProfile != null)
            {
                Player.TotalGoldCoinValues = activeProfile.TotalGoldCoinValues;
                Player.TotalSilverCoinValues = activeProfile.TotalSilverCoinValues;
                Player.HighScore = activeProfile.HighScore;
                Player.MatchGoldCoins = 0;
                Player.MatchSilverCoins = 0;
                Player.CurrentScore = 0;
            }

            var equippedItems = db.PlayerItems
                .Where(pi => pi.PlayerProfileId == GameSession.CurrentPlayerId && pi.IsEquipped)
                .Select(pi => pi.ShopItemId)
                .ToList();

            HasSpecialTheme = equippedItems.Contains(1);
            HasSpecialBullet = equippedItems.Contains(2);
            HasSpecialSkin = equippedItems.Contains(3);
        }
    }
}