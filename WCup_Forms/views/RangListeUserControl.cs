using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCup_Data.DataFetching;
using WCup_Data.Models;
using WCup_Data.Models.Enums;
using WCup_Data.Settings;
using WCup_Forms.components;

namespace WCup_Forms.views
{
    public partial class RangListeUserControl : UserControl
    {
        private IDataFetcher _fetcher;
        private Settings _settings;
        string representation = null;

        public RangListeUserControl()
        {
            InitializeComponent();
            _settings = SettingsController.GetSettings();
            _fetcher = FetchFactory.FetchData(_settings.DataFetchType);
            LoadAtendance();
        }

        private async void LoadAtendance()
        {
            flpNumberOfAtendees.Controls.Clear();
            var matches = await _fetcher.FetchMatches();
            List<string> strings = matches
                .OrderByDescending(m => m.Attendance)
                .Where(m => m.HomeTeam.Code == representation || m.AwayTeam.Code == representation)
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

        public void setRep(string rep)
        {
            representation = rep;
            LoadAtendance();
        }

        private async Task LoadPlayers(string fifaCode, bool isGoal)
        {
            if (fifaCode == null)
            {
                MessageBox.Show("Please select a representation");
                return;
            }
            flpPlayersFilterList.Controls.Clear();
            var matchesAll = await _fetcher.fetchMatchesByCountry(fifaCode);
            var matchesTeam = matchesAll.Where(m => m.HomeTeam.Code == fifaCode || m.AwayTeam.Code == fifaCode);
            List<TeamEvent> events = new List<TeamEvent>();
            foreach (var m in matchesTeam)
            {
                events.AddRange(m.HomeTeamEvents);
                events.AddRange(m.AwayTeamEvents);
            }

            List<Player> players = null;

            var match = matchesTeam.First();
            if (match.AwayTeam.Code == fifaCode)
            {
                players = match.AwayTeamStatistics.StartingEleven.Union(match.AwayTeamStatistics.Substitutes).DistinctBy(p => p.Name).ToList();
            }
            else if (match.HomeTeam.Code == fifaCode)
            {
                players = match.HomeTeamStatistics.StartingEleven.Union(match.HomeTeamStatistics.Substitutes).DistinctBy(p => p.Name).ToList();
            }
            if (players == null) throw new Exception("Kako ne postoji tim u utakmici koju su igrali");

            List<KeyValuePair<string, int>> igraci = new List<KeyValuePair<string, int>>();

            TypeOfEvent ev;

            if (isGoal)
            {
                ev = TypeOfEvent.Goal;
            }
            else
            {
                ev = TypeOfEvent.YellowCard;
            }

            foreach (var player in players)
            {
                igraci.Add(new KeyValuePair<string, int>(player.Name, events
                    .Where(e => e.Player == player.Name)
                    .Count(e => e.TypeOfEvent == ev))
                    );
            }
            igraci = igraci.OrderByDescending(i => i.Value).ToList();


            List<Label> plylbl = new List<Label>();

            foreach (var i in igraci)
            {
                Label l = new Label();
                l.Text = $"{i.Key} {i.Value}";
                l.Width = 200;
                plylbl.Add(l);
            }

            flpPlayersFilterList.Controls.AddRange(plylbl.ToArray());

        }

        private async void btnSortByGoalNumber_Click(object sender, EventArgs e)
        {
            LoadPlayers(representation, true);
        }

        private async void btnSortByYellowCards_Click(object sender, EventArgs e)
        {
            LoadPlayers(representation, false);
        }
    }
}
