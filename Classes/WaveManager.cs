namespace Arcade_Game;

internal static class WaveManager
{
    public static int CurrentWave = 1;

    public static int EnemyHealthBonus = 0;
    public static int EnemySpeedBonus = 1;

    public static void LoadWave()
    {
        Enemy.enemies.Clear();

        switch (CurrentWave)
        {
            case 1:
                Enemy.enemies.Add(new StandardEnemy(new(50, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(1100, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(600, 200)));
                break;

            case 2:
                Enemy.enemies.Add(new StandardEnemy(new(100, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(400, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(700, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(250, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(550, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(850, 100)));
                break;

            case 3:
                Enemy.enemies.Add(new StandardEnemy(new(125, 150)));
                Enemy.enemies.Add(new StandardEnemy(new(325, 150)));
                Enemy.enemies.Add(new StandardEnemy(new(525, 150)));
                Enemy.enemies.Add(new StandardEnemy(new(725, 150)));
                Enemy.enemies.Add(new ScoutEnemy(new(225, 150)));
                Enemy.enemies.Add(new ScoutEnemy(new(425, 150)));
                Enemy.enemies.Add(new ScoutEnemy(new(625, 150)));
                Enemy.enemies.Add(new ScoutEnemy(new(825, 150)));
                Enemy.enemies.Add(new TerroristEnemy(new(250, 300)));
                Enemy.enemies.Add(new TerroristEnemy(new(750, 300)));
                break;

            case 4:
                Enemy.enemies.Add(new StandardEnemy(new(100, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(300, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(500, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(700, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(900, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(200, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(400, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(600, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(800, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(1000, 100)));
                Enemy.enemies.Add(new TerroristEnemy(new(350, 200)));
                Enemy.enemies.Add(new TerroristEnemy(new(700, 200)));
                Enemy.enemies.Add(new TerroristEnemy(new(1050, 200)));
                break;

            case 5:
                Enemy.enemies.Add(new StandardEnemy(new(100, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(350, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(600, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(850, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(1100, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(600, 150)));
                Enemy.enemies.Add(new StandardEnemy(new(900, 150)));
                Enemy.enemies.Add(new ScoutEnemy(new(225, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(475, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(725, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(975, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(450, 150)));
                Enemy.enemies.Add(new ScoutEnemy(new(750, 150)));
                Enemy.enemies.Add(new ScoutEnemy(new(1050, 150)));
                Enemy.enemies.Add(new TerroristEnemy(new(450, 200)));
                Enemy.enemies.Add(new TerroristEnemy(new(600, 200)));
                Enemy.enemies.Add(new TerroristEnemy(new(750, 200)));
                Enemy.enemies.Add(new TerroristEnemy(new(750, 300)));
                Enemy.enemies.Add(new TerroristEnemy(new(750, 300)));
                break;

            case 6:
                Enemy.enemies.Add(new StandardEnemy(new(100, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(300, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(500, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(700, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(900, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(200, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(400, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(600, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(800, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(1000, 100)));
                Enemy.enemies.Add(new TerroristEnemy(new(450, 200)));
                Enemy.enemies.Add(new TerroristEnemy(new(750, 200)));
                Enemy.enemies.Add(new ShooterEnemy(new(300, 150)));
                Enemy.enemies.Add(new ShooterEnemy(new(600, 150)));
                Enemy.enemies.Add(new ShooterEnemy(new(900, 150)));
                break;

            case 7:
                Enemy.enemies.Add(new StandardEnemy(new(100, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(300, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(500, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(700, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(900, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(200, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(400, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(600, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(800, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(1000, 100)));
                Enemy.enemies.Add(new ShooterEnemy(new(100, 200)));
                Enemy.enemies.Add(new ShooterEnemy(new(300, 200)));
                Enemy.enemies.Add(new ShooterEnemy(new(500, 200)));
                Enemy.enemies.Add(new ShooterEnemy(new(700, 200)));
                Enemy.enemies.Add(new ShooterEnemy(new(900, 200)));
                Enemy.enemies.Add(new TerroristEnemy(new(200, 200)));
                Enemy.enemies.Add(new TerroristEnemy(new(400, 200)));
                Enemy.enemies.Add(new TerroristEnemy(new(600, 200)));
                Enemy.enemies.Add(new TerroristEnemy(new(800, 200)));
                Enemy.enemies.Add(new TerroristEnemy(new(1000, 200)));
                break;

            case 8:
                Enemy.enemies.Add(new StandardEnemy(new(100, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(400, 100)));
                Enemy.enemies.Add(new StandardEnemy(new(700, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(250, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(550, 100)));
                Enemy.enemies.Add(new ScoutEnemy(new(850, 100)));
                Enemy.enemies.Add(new ShooterEnemy(new(100, 200)));
                Enemy.enemies.Add(new ShooterEnemy(new(200, 200)));
                Enemy.enemies.Add(new ShooterEnemy(new(300, 200)));
                Enemy.enemies.Add(new ShooterEnemy(new(400, 200)));
                Enemy.enemies.Add(new ShooterEnemy(new(800, 200)));
                Enemy.enemies.Add(new ShooterEnemy(new(900, 200)));
                Enemy.enemies.Add(new ShooterEnemy(new(1000, 200)));
                Enemy.enemies.Add(new TerroristEnemy(new(200, 150)));
                Enemy.enemies.Add(new TerroristEnemy(new(400, 150)));
                Enemy.enemies.Add(new TerroristEnemy(new(600, 150)));
                Enemy.enemies.Add(new TerroristEnemy(new(800, 150)));
                Enemy.enemies.Add(new TerroristEnemy(new(1000, 150)));
                break;

            case 9:
                Enemy.enemies.Add(new ShooterEnemy(new(75, 100)));
                Enemy.enemies.Add(new ShooterEnemy(new(150, 100)));
                Enemy.enemies.Add(new ShooterEnemy(new(225, 100)));
                Enemy.enemies.Add(new ShooterEnemy(new(300, 100)));
                Enemy.enemies.Add(new ShooterEnemy(new(375, 100)));
                Enemy.enemies.Add(new ShooterEnemy(new(450, 100)));
                Enemy.enemies.Add(new ShooterEnemy(new(525, 100)));
                Enemy.enemies.Add(new TerroristEnemy(new(100, 150)));
                Enemy.enemies.Add(new TerroristEnemy(new(200, 150)));
                Enemy.enemies.Add(new TerroristEnemy(new(300, 150)));
                Enemy.enemies.Add(new TerroristEnemy(new(400, 150)));
                Enemy.enemies.Add(new TerroristEnemy(new(500, 150)));
                Enemy.enemies.Add(new ShooterEnemy(new(900, 100)));
                Enemy.enemies.Add(new ShooterEnemy(new(975, 100)));
                Enemy.enemies.Add(new ShooterEnemy(new(1050, 100)));
                Enemy.enemies.Add(new ShooterEnemy(new(1125, 100)));
                Enemy.enemies.Add(new TerroristEnemy(new(600, 150)));
                Enemy.enemies.Add(new TerroristEnemy(new(700, 150)));
                Enemy.enemies.Add(new TerroristEnemy(new(800, 150)));
                Enemy.enemies.Add(new TerroristEnemy(new(900, 150)));
                Enemy.enemies.Add(new TerroristEnemy(new(1000, 150)));
                break;

            case 10:
                Enemy.enemies.Add(new TankEnemy(new(580, 250)));
                break;
        }
    }

    public static void NextWave()
    {
        CurrentWave++;

        if (CurrentWave % 3 == 1 && CurrentWave > 1)
            EnemyHealthBonus++;
        if (CurrentWave % 5 == 0)
            EnemySpeedBonus++;
        if (CurrentWave <= 10)
            LoadWave();
        else
        {
            GameOverPrompt prompt = new("You have beaten the game!");
            prompt.Show();
        }
    }
}