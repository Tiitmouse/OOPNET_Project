using QuickType;
using WCup_Data.DataFetching;
using WCup_Data.Models;
using WCup_Data.Settings;

namespace WCup_Forms
{
    public partial class Form1 : Form
    {
        private IDataFetcher _fetcher;
        private Settings _settings;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _settings = SettingsController.GetSettings();
            _fetcher = FetchFactory.FetchData(_settings.DataFetchType);
            loadDataAsync();

        }

        private async Task loadDataAsync()
        {
            List<Match> matches = await _fetcher.FetchMatches();
            List<Group> groups = await _fetcher.FetchGroups();
            List<Result> results = await _fetcher.FetchResults();
            List<TeamDetails> teams = await _fetcher.FetchTeamDetails();
            //SettingsController.SaveSettings();        }
        }

        private void btnOpenSettings_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
        }
    }
}