using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WCup_Data.DataFetching;
using WCup_Data.Settings;

namespace WCup_WPF
{
    /// <summary>
    /// Interaction logic for RepresentationWindow.xaml
    /// </summary>
    public partial class RepresentationWindow : Window
    {
        private IDataFetcher _fetcher;
        private Settings _settings;
        public string team { get; set; }
        public string rteam { get; set; }
        public RepresentationWindow(string team, string rteam)
        {
            _settings = SettingsController.GetSettings();
            _fetcher = FetchFactory.FetchData(_settings.DataFetchType);
            InitializeComponent();
            this.team = team;
            this.rteam = rteam;
            LoadInfo();
        }

        public async void LoadInfo()
        {
            var matches =await _fetcher.fetchMatchesByCountry(team);
            var match = matches
                .Where(m => m.HomeTeam.Code == rteam || m.AwayTeam.Code == rteam)
                .FirstOrDefault();
            if (rteam == match.HomeTeam.Code)
            {
                lblRepresentationName.Content = match.AwayTeam.Country;
                lblRepresentationFIFAcode.Content = match.AwayTeam.Code;
                lblRepresentationGoalsGiven.Content = match.AwayTeam.Goals;
                lblRepresentationGoalsTaken.Content = match.HomeTeam.Goals;
            }
            else
            {
                lblRepresentationName.Content = match.HomeTeam.Country;
                lblRepresentationFIFAcode.Content = match.HomeTeam.Code;
                lblRepresentationGoalsGiven.Content = match.HomeTeam.Goals;
                lblRepresentationGoalsTaken.Content = match.AwayTeam.Goals;
            }
            if (match.WinnerCode == team)
            {
                lblRepresentationGamesWon.Content = 1;
            } else
            {
                   lblRepresentationGamesLost.Content = 1;
            }
            
        }

    }
}
