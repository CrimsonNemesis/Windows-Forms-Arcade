namespace Arcade_Game;

public static class NavigationManager
{
    public static SelectProfile SelectProfileForm { get; } = new SelectProfile();
    public static MainMenu MainMenuForm { get; } = new MainMenu();
    public static ChooseMode ChooseModeForm { get; } = new ChooseMode();
    public static Options OptionsForm { get; } = new Options();
    public static Shop ShopForm { get; } = new Shop();
    public static Guide GuideForm { get; } = new Guide();
    public static Sounds SoundsForm { get; } = new Sounds();
    public static About About { get; } = new About();

    private static Form _activeForm;

    public static void ShowForm(Form targetForm)
    {
        Form oldForm = _activeForm;

        _activeForm = targetForm;

        targetForm.Show();

        targetForm.Refresh();

        if (oldForm != null && oldForm != targetForm)
            oldForm.Hide();
    }

    public static void StartGame(bool pixelMode)
    {
        GameSettings.PixelMode = pixelMode;

        Game newGame = new Game();
        ShowForm(newGame);
    }

    public static void LeaveGameAndGoToMenu(Game gameForm)
    {
        ShowForm(MainMenuForm);

        gameForm.Close();
        gameForm.Dispose();
    }
}