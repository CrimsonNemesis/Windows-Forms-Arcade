namespace Arcade_Game;

public static class NavigationManager
{
    private static SelectProfile _selectProfileForm;
    private static MainMenu _mainMenuForm;
    private static ChooseMode _chooseModeForm;
    private static Options _optionsForm;
    private static Shop _shopForm;
    private static Guide _guideForm;
    private static Sounds _soundsForm;
    private static About _aboutForm;

    private static Form _activeForm;

    public static SelectProfile SelectProfileForm => _selectProfileForm ??= new SelectProfile();
    public static MainMenu MainMenuForm => _mainMenuForm ??= new MainMenu();
    public static ChooseMode ChooseModeForm => _chooseModeForm ??= new ChooseMode();
    public static Options OptionsForm => _optionsForm ??= new Options();
    public static Shop ShopForm => _shopForm ??= new Shop();
    public static Guide GuideForm => _guideForm ??= new Guide();
    public static Sounds SoundsForm => _soundsForm ??= new Sounds();
    public static About About => _aboutForm ??= new About();

    public static void ShowForm(Form targetForm)
    {
        if (_activeForm != null && _activeForm != targetForm)
            _activeForm.Hide();

        _activeForm = targetForm;
        targetForm.Show();
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