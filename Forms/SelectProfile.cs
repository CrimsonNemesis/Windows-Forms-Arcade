namespace Arcade_Game;

public partial class SelectProfile : Base
{
    private ProfileManager pM = new ProfileManager();

    public SelectProfile()
    {
        InitializeComponent();

        typeof(TableLayoutPanel).GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance)
            ?.SetValue(tableLayoutPanel1, true, null);

        this.FullScreen();
    }

    private void RefreshProfilesList()
    {
        lstProfiles.DataSource = pM.GetAllProfiles();
        lstProfiles.DisplayMember = "ProfileName";
        lstProfiles.ValueMember = "Id";
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show("Enter a name in the label between two buttons first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        PlayerProfile theNewProfile = pM.CreateNewProfile(txtName.Text);
        txtName.Clear();
        RefreshProfilesList();
    }

    private void btnLoad_Click(object sender, EventArgs e)
    {
        if (lstProfiles.SelectedItem == null)
        {
            MessageBox.Show("Please choose a Profile from the list first!");
            return;
        }

        PlayerProfile selectedProfile = (PlayerProfile)lstProfiles.SelectedItem;
        if (pM.SelectProfile(selectedProfile.Id))
        {
            NavigationManager.ShowForm(NavigationManager.MainMenuForm);
        }
    }

    private void SelectProfile_VisibleChanged(object sender, EventArgs e)
    {
        if (this.Visible)
        {
            MusicPlayer.Play(@"Resources\Musics&Sounds\TheTheme.wav");
            RefreshProfilesList();
        }
    }

    private void SelectProfile_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();

    }
}
