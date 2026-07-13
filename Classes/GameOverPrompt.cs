namespace Arcade_Game;

internal class GameOverPrompt
{
    private TaskDialogPage page;
    private TaskDialogButton button = new TaskDialogButton("Back to main menu");

    public GameOverPrompt(string heading)
    {
        page = new()
        {
            Caption = "Game Over",
            Heading = heading,
            Text = $"Current Score: {Player.CurrentScore}\n" + $"Highest Score: {Player.HighScore}\n" + $"Gold Coins Collected: {Player.MatchGoldCoins}\n" + $"Silver Coins Collected: {Player.MatchSilverCoins}"
        };

        page.Buttons.Add(button);
    }

    public void Show()
    {
        Game.Instance.Timer.Stop();

        TaskDialogButton result = TaskDialog.ShowDialog(Game.Instance, page);

        if (result == button)
        {
            MainMenu menu = new MainMenu();
            Game.Instance.Hide();
            menu.Show();
        }
    }
}