using QuickType;
using System.Windows.Forms;
using WCup_Data.DataFetching;
using WCup_Data.Models;
using WCup_Data.Settings;
using WCup_Forms.components;

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
            LoadTeams();
            LoadAtendance();
        }

        private async void LoadAtendance()
        {
            var matches = await _fetcher.FetchMatches();
            List<string> strings = matches
                .OrderByDescending(m => m.Attendance)
                .Select(m => $"{m.Location}    {m.Attendance} attendees")
                .ToList();

            List<Label> labels = new List<Label>();
            foreach (var match in strings)
            {
                var label = new Label()
                {
                    Text = match,
                    Width = 300
                };
                labels.Add(label);
            }
            flpNumberOfAtendees.Controls.AddRange(labels.ToArray());

        }

        private async Task LoadTeams()
        {
            var rep = await _fetcher.FetchTeamDetails();
            var teams = rep.Select(m => m.FifaCode)
                .Order()
                .ToArray();
            cbRepresentation.Items.AddRange(teams);
        }

        private async Task LoadPlayers(string fifaCode)
        {
            flpPlayersList.Controls.Clear();
            var matches = await _fetcher.fetchMatchesByCountry(fifaCode);
            var match = matches.First();
            List<Player> players = null;

            if (match.AwayTeam.Code == fifaCode)
            {
                players = match.AwayTeamStatistics.StartingEleven.Union(match.AwayTeamStatistics.Substitutes).DistinctBy(p => p.Name).ToList();
            }
            else if (match.HomeTeam.Code == fifaCode)
            {
                players = match.HomeTeamStatistics.StartingEleven.Union(match.HomeTeamStatistics.Substitutes).DistinctBy(p => p.Name).ToList();
            }
            if (players == null) throw new Exception("Kako ne postoji tim u utakmici koju su igrali");

            List<PlayerControl> pControls = new List<PlayerControl>();

            foreach (var player in players)
            {
                pControls.Add(new PlayerControl(player));
            }

            flpPlayersList.Controls.AddRange(pControls.ToArray());

        }



        private void btnOpenSettings_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm(_settings);
            sf.ShowDialog();
            _settings = SettingsController.GetSettings();
        }

        private void cbRepresentation_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            var fifaCode = (string)cbRepresentation.SelectedItem;
            LoadPlayers(fifaCode);

        }
    }
}