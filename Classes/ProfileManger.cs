namespace Arcade_Game;

public class ProfileManager
{
    public PlayerProfile CreateNewProfile(string profileName)
    {
        using (var db = new GameDbContext())
        {
            var newProfile = new PlayerProfile
            {
                ProfileName = profileName,
                TotalGoldCoinValues = 0,
                TotalSilverCoinValues = 0,
                HighScore = 0
            };

            db.PlayerProfiles.Add(newProfile);
            db.SaveChanges();

            return newProfile;
        }
    }

    public bool SelectProfile(int profileId)
    {
        using (var db = new GameDbContext())
        {
            var profileExists = db.PlayerProfiles.Any(p => p.Id == profileId);

            if (profileExists)
            {
                GameSession.CurrentPlayerId = profileId;
                return true;
            }
            return false;
        }
    }

    public List<PlayerProfile> GetAllProfiles()
    {
        using (var db = new GameDbContext())
        {
            return db.PlayerProfiles.ToList();
        }
    }
}