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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WCup_Data.DataFetching;
using WCup_Data.Models;
using WCup_Data.Settings;

namespace WCup_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary> 

    public partial class MainWindow : Window
    {
        private IDataFetcher _fetcher;
        private Settings _settings;

        public MainWindow()
        {
            InitializeComponent();
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.ShowDialog();
            settingsWindow.Topmost = true;
            settingsWindow.Closed += settingsWindow_Closed;
            _settings = SettingsController.GetSettings();
            _fetcher = FetchFactory.FetchData(_settings.DataFetchType);
            LoadTeams();
        }

        private async void LoadTeams()
        {
            if (_settings.FavouriteRepresentation != null)
            {
                cbFavouriteRepresenation.SelectedItem = _settings.FavouriteRepresentation;
            }
            else { }

            var rep = await _fetcher.FetchTeamDetails();
            var teams = rep.Select(m => m.FifaCode)
                .Order()
                .ToArray();
            foreach (var team in teams)
            {
                cbFavouriteRepresenation.Items.Add(team);
            }
        }

        private async void LoadRivalTeams()
        {
            string favTeam = (string)cbFavouriteRepresenation.SelectedItem;
            var matches = await _fetcher.fetchMatchesByCountry(favTeam);
            var rivalTeams = matches.Select(m => m.HomeTeam.Code == favTeam ? m.AwayTeam.Code : m.HomeTeam.Code)
                .Distinct()
                .ToArray();
            foreach (var team in rivalTeams)
            {
                cbRivalRepresentation.Items.Add(team);
            }
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            this.Opacity = 0.1;
            settingsWindow.Closed += settingsWindow_Closed;
            settingsWindow.ShowDialog();
        }

        private void settingsWindow_Closed(object? sender, EventArgs e)
        {
            this.IsEnabled = true;
            this.Opacity = 1;
            this.Focusable = true;
        }

        private void lblFavTeamInfo_Click(object sender, RoutedEventArgs e)
        {
            if (cbFavouriteRepresenation.SelectedIndex == -1 || cbRivalRepresentation.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both teams first!");
                return;
            }
            loadingProgressBar.Visibility = Visibility.Visible;
            loadingProgressBar.IsIndeterminate = false;
            loadingProgressBar.Value = 0;
            loadingProgressBar.Maximum = 100;
            RepresentationWindow rw =
                new RepresentationWindow((string)cbFavouriteRepresenation.SelectedItem, (string)cbRivalRepresentation.SelectedItem);
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(30);
            int duration = 1500;
            int steps = duration / 30;
            int currentStep = 0;
            timer.Tick += (s, args) =>
            {
                currentStep++;
                loadingProgressBar.Value = (double)currentStep / steps * 100;

                if (currentStep >= steps)
                {
                    loadingProgressBar.Visibility = Visibility.Hidden;
                    RepresentationWindow rw =
                        new RepresentationWindow((string)cbFavouriteRepresenation.SelectedItem, (string)cbRivalRepresentation.SelectedItem);
                    rw.ShowDialog();
                    timer.Stop();
                }
            };
            timer.Start();
        }

        private void lblRivalTeamInfo_Click(object sender, RoutedEventArgs e)
        {
            if (cbFavouriteRepresenation.SelectedIndex == -1 || cbRivalRepresentation.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both teams first!");
                return;
            }
            loadingProgressBar.Visibility = Visibility.Visible;
            loadingProgressBar.IsIndeterminate = false;
            loadingProgressBar.Value = 0;
            loadingProgressBar.Maximum = 100;
            RepresentationWindow rw = new RepresentationWindow((string)cbRivalRepresentation.SelectedItem, (string)cbFavouriteRepresenation.SelectedItem);
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(30);
            int duration = 1500;
            int steps = duration / 30;
            int currentStep = 0;
            timer.Tick += (s, args) =>
            {
                currentStep++;
                loadingProgressBar.Value = (double)currentStep / steps * 100;

                if (currentStep >= steps)
                {
                    loadingProgressBar.Visibility = Visibility.Hidden;
                    RepresentationWindow rw =
                        new RepresentationWindow((string)cbRivalRepresentation.SelectedItem, (string)cbFavouriteRepresenation.SelectedItem);
                    rw.ShowDialog();
                    timer.Stop();
                }
            };
            timer.Start();
        }

        private void cbFavouriteRepresenation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbRivalRepresentation.Items.Clear();
            rivalRepResult.Content = "/";
            favRepResult.Content = "/";
            LoadRivalTeams();
        }

        private async void cbRivalRepresentation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbRivalRepresentation.SelectedIndex == -1)
            {
                return;
            }
            string favTeam = (string)cbFavouriteRepresenation.SelectedItem;
            string rivalTeam = (string)cbRivalRepresentation.SelectedItem;
            var matches = await _fetcher.fetchMatchesByCountry(favTeam);
            var match = matches
                .Where(m => m.HomeTeam.Code == rivalTeam || m.AwayTeam.Code == rivalTeam)
                .FirstOrDefault();
            if (favTeam == match.HomeTeam.Code)
            {
                favRepResult.Content = match.HomeTeam.Goals;
                rivalRepResult.Content = match.AwayTeam.Goals;
            }
            else
            {
                rivalRepResult.Content = match.HomeTeam.Goals;
                favRepResult.Content = match.AwayTeam.Goals;
            }
        }

        private async void testPlayer_Click(object sender, RoutedEventArgs e)
        {
            string team = cbFavouriteRepresenation.Text;
            string rteam = cbRivalRepresentation.Text;
            Player p = new Player();
            var matches = await _fetcher.fetchMatchesByCountry(team);
            var match = matches.First();
            List<Player> players = new List<Player>();
            if (match.AwayTeam.Code == team)
            {
                players = match.AwayTeamStatistics.StartingEleven.ToList();
            }
            else if (match.HomeTeam.Code == team)
            {
                players = match.HomeTeamStatistics.StartingEleven.ToList();
            }

            foreach (var pl in players)
            {
                if (pl.ShirtNumber == 19)
                {
                    p = pl;
                }
            }

            PlayerWindow pw = new PlayerWindow(p, team,rteam);
            pw.ShowDialog();
        }
    }
}
