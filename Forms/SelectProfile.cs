namespace Arcade_Game;

public partial class SelectProfile : Base
{
    private ProfileManager pM = new ProfileManager();

    public SelectProfile()
    {
        InitializeComponent();
        this.FullScreen();
    }

    private void Form_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }
    private void RefreshProfilesList()
    {
        lstProfiles.DataSource = pM.GetAllProfiles();
        lstProfiles.DisplayMember = "ProfileName";
        lstProfiles.ValueMember = "Id";
    }

    private void SelectForm_Load(object sender, EventArgs e)
    {
        MusicPlayer.Play(@"Resources\Musics&Sounds\TheTheme.wav");
        RefreshProfilesList();
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show("Enter a name in the label between two buttons first!");
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
            MainMenu menu = new MainMenu();
            this.Hide();
            menu.Show();
        }
    }
}
