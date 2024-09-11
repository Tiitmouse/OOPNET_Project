using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WCup_Data.DataFetching;
using WCup_Data.Models;
using WCup_Data.Models.Enums;
using WCup_Data.Settings;

namespace WCup_WPF
{
    /// <summary>
    /// Interaction logic for PlayerWindow.xaml
    /// </summary>
    public partial class PlayerWindow : Window
    {
        private IDataFetcher _fetcher;
        private Settings _settings;

        public Player player { get; set; }
        public string team { get; set; }
        public string rteam { get; set; }
        public PlayerWindow(Player player, string team, string rteam)
        {
            _settings = SettingsController.GetSettings();
            _fetcher = FetchFactory.FetchData(_settings.DataFetchType);
            InitializeComponent();
            this.player = player;
            this.team = team;
            this.rteam = rteam;
            LoadInfo();
            this.rteam = rteam;
        }

        private async void LoadInfo()
        {
            lblPlayerShirtNumber.Content = player.ShirtNumber;
            lblPlayerName.Content = player.Name;
            lblPlayerPosition.Content = player.Position;
            if (player.Captain) { lblICapetan.Content = "C"; }

            var matches = await _fetcher.fetchMatchesByCountry(team);
            var match = matches
                .Where(m => m.HomeTeam.Code == team || m.AwayTeam.Code == team)
                .FirstOrDefault(m => m.HomeTeam.Code == rteam || m.AwayTeam.Code == rteam);
            var plEvents = match.HomeTeamEvents
                .Union(match.AwayTeamEvents)
                .Where(ev => ev.Player == player.Name);
            int goalCount = plEvents
                .Count(ev => ev.TypeOfEvent == TypeOfEvent.Goal);

            lblGoalCount.Content = goalCount.ToString();

            int yellowCardCount = plEvents.Count(ev => ev.TypeOfEvent == TypeOfEvent.YellowCard || ev.TypeOfEvent == TypeOfEvent.YellowCardSecond);

            lblYellowCards.Content = yellowCardCount.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DoubleAnimation opacityAnimation = new DoubleAnimation
            {
                From = 0.1,
                To = 0.9,
                Duration = new Duration(TimeSpan.FromSeconds(1))
            };

            playerPicture.BeginAnimation(UIElement.OpacityProperty, opacityAnimation);
        }
    }
}
