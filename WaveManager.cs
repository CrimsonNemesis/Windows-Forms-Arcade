namespace Arcade_Game;

internal static class WaveManager
{
    public static int CurrentWave = 1;

    public static void LoadWave()
    {
        Enemy.enemies.Clear();

        switch (CurrentWave)
        {
            case 1:

                Enemy.enemies.Add(new StandardEnemy(new(50, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(1100, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new ScoutEnemy(new(600, 200), new(1, CoinKind.Gold)));



                break;

            case 2:

                Enemy.enemies.Add(new StandardEnemy(new(100, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(400, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(700, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new ScoutEnemy(new(250, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(550, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(850, 100), new(1, CoinKind.Gold)));




                break;

            case 3:

                Enemy.enemies.Add(new StandardEnemy(new(25, 150), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(225, 150), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(425, 150), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(625, 150), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new ScoutEnemy(new(125, 150), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(325, 150), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(525, 150), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(725, 150), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new TerroristEnemy(new(250, 300), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(750, 300), new(5, CoinKind.Silver)));





                break;

            case 4:

                Enemy.enemies.Add(new StandardEnemy(new(100, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(300, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(500, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(700, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(900, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new ScoutEnemy(new(200, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(400, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(600, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(800, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(1000, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new TerroristEnemy(new(350, 200), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(700, 200), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(1050, 200), new(5, CoinKind.Silver)));





                break;



            case 5:

                Enemy.enemies.Add(new StandardEnemy(new(100, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(350, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(600, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(850, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(1100, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(600, 150), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(900, 150), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new ScoutEnemy(new(225, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(475, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(725, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(975, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(450, 150), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(750, 150), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(1050, 150), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new TerroristEnemy(new(450, 200), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(600, 200), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(750, 200), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(750, 300), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(750, 300), new(5, CoinKind.Silver)));





                break;






            case 6:

                Enemy.enemies.Add(new StandardEnemy(new(100, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(300, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(500, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(700, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(900, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new ScoutEnemy(new(200, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(400, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(600, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(800, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(1000, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new TerroristEnemy(new(450, 200), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(750, 200), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new ShooterEnemy(new(300, 150), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(600, 150), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(900, 150), new(5, CoinKind.Gold)));






                break;







            case 7:

                Enemy.enemies.Add(new StandardEnemy(new(100, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(300, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(500, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(700, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(900, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new ScoutEnemy(new(200, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(400, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(600, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(800, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(1000, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(100, 200), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(300, 200), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(500, 200), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(700, 200), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(900, 200), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new TerroristEnemy(new(200, 200), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(400, 200), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(600, 200), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(800, 200), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(1000, 200), new(5, CoinKind.Silver)));





                break;










            case 8:

                Enemy.enemies.Add(new StandardEnemy(new(100, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(400, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new StandardEnemy(new(700, 100), new(1, CoinKind.Silver)));
                Enemy.enemies.Add(new ScoutEnemy(new(250, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(550, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ScoutEnemy(new(850, 100), new(1, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(100, 200), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(200, 200), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(300, 200), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(400, 200), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(800, 200), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(900, 200), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(1000, 200), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new TerroristEnemy(new(200, 150), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(400, 150), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(600, 150), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(800, 150), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(1000, 150), new(5, CoinKind.Silver)));




                break;







            case 9:

                Enemy.enemies.Add(new ShooterEnemy(new(75, 100), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(150, 100), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(225, 100), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(300, 100), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(375, 100), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(450, 100), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(525, 100), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new TerroristEnemy(new(100, 150), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(200, 150), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(300, 150), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(400, 150), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(500, 150), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new ShooterEnemy(new(900, 100), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(975, 100), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(1050, 100), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new ShooterEnemy(new(1125, 100), new(5, CoinKind.Gold)));
                Enemy.enemies.Add(new TerroristEnemy(new(600, 150), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(700, 150), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(800, 150), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(900, 150), new(5, CoinKind.Silver)));
                Enemy.enemies.Add(new TerroristEnemy(new(1000, 150), new(5, CoinKind.Silver)));


                break;











            case 10:

                Enemy.enemies.Add(new TankEnemy(new(580, 250)));





                break;
        }
    }

    public static void NextWave()
    {
        CurrentWave++;

        if (CurrentWave % 3 == 1)
        {
            
        }
        if (CurrentWave <= 10)
        {
            LoadWave();
        }
        else
        {
            MainForm.Instance.Timer.Stop();
        }
    }
}