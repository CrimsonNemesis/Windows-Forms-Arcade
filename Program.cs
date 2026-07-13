namespace Arcade_Game;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        Form rootForm = NavigationManager.SelectProfileForm;

        NavigationManager.ShowForm(rootForm);

        Application.Run(rootForm);
    }
}