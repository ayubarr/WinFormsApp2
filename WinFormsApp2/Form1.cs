namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            MainMenuLabel.Visible = false;
            StartGameButton.Visible = false;
            ExitButton.Visible = false;
            SettingsButton.Visible = false;

            SettingsMenuLabel.Visible = true;
            BackButton.Visible = true;
            PlayersCountPlus.Visible = true;
            PlayersCountMinus.Visible = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenuLabel.Visible = true;
            StartGameButton.Visible = true;
            ExitButton.Visible = true;
            SettingsButton.Visible = true;

            SettingsMenuLabel.Visible = false;
            BackButton.Visible = false;
            PlayersCountPlus.Visible = false;
            PlayersCountMinus.Visible = false;

        }
    }
}