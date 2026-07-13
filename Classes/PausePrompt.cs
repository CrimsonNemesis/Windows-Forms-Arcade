namespace Arcade_Game;

internal class PausePrompt
{
    private TaskDialogPage page;
    public TaskDialogButton backBtn = new TaskDialogButton("Back");
    public TaskDialogButton ResumeBtn = new TaskDialogButton("Resume");

    public PausePrompt()
    {
        page = new()
        {
            Caption = "UPWEGO",
            Heading = "Paused",
            AllowCancel = true
        };

        page.Buttons.Add(backBtn);
        page.Buttons.Add(ResumeBtn);
    }

    public TaskDialogButton Show()
    {
        return TaskDialog.ShowDialog(Game.Instance, page);
    }
}