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
using WCup_Data.PictureLoaders;
using WCup_Data.Settings;
using WCup_Forms.components;

namespace WCup_Forms.views
{
    public partial class IgraciUserControl : UserControl
    {
        string? representation = null;
        private PlayerControl? _selectedPlayerControl;

        public IgraciUserControl()
        {
            InitializeComponent();
            _settings = SettingsController.GetSettings();
            _fetcher = FetchFactory.FetchData(_settings.DataFetchType);

            // Enable drag-and-drop for the FlowLayoutPanels
            flpPlayersList.AllowDrop = true;
            flpFavouritePlayers.AllowDrop = true;

            // Subscribe to the necessary events
            flpPlayersList.MouseDown += FlpPlayersList_MouseDown;
            flpFavouritePlayers.DragEnter += FlpFavouritePlayers_DragEnter;
            flpFavouritePlayers.DragDrop += FlpFavouritePlayers_DragDrop;
        }

        private IDataFetcher _fetcher;
        private Settings _settings;

        public async void setRep(string rep)
        {
            representation = rep;
            await LoadPlayers(rep);
        }

        private async Task LoadPlayers(string fifaCode)
        {
             ClearFlowLayoutPanels();
            var matches = await _fetcher.fetchMatchesByCountry(fifaCode);
            var match = matches.First();
            List<Player>? players = null;

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
                var playerControl = new PlayerControl(player);
                playerControl.Click += PlayerControl_Click;
                pControls.Add(playerControl);
            }

            flpPlayersList.Controls.AddRange(pControls.ToArray());

            loadFav(players);
        }

        private void loadFav(List<Player> players)
        {
            List<PlayerControl> pControls = new List<PlayerControl>();
            List<string> favs = new List<string>();
            favs.AddRange(_settings.favouritePlayers);
            List<Player> favpl =  players.Where(p => favs.Contains(p.Name)).ToList();
            foreach (var player in favpl)
            {
                var playerControl = new PlayerControl(player);
                playerControl.Click += PlayerControl_Click;
                pControls.Add(playerControl);
            }
            if (pControls.Count == 0)
            {
                return;
            }
             flpFavouritePlayers.Controls.AddRange(pControls.ToArray());

        }

        private void PlayerControl_Click(object? sender, EventArgs e)
        {
            _selectedPlayerControl = sender as PlayerControl;
        }

        private void btnSetPlayerPicture_Click(object sender, EventArgs e)
        {
            if (_selectedPlayerControl == null)
            {
                MessageBox.Show("Please select a player first.");
                return;
            }
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    PictureUtils.savePicture(filePath, _selectedPlayerControl.getName());
                    var img = PictureUtils.LoadPicture(_selectedPlayerControl.getName());
                    if (img != null)
                    {
                        Image selectedImage = Image.FromFile(img);
                    }
                }
            }
        }

        private void FlpPlayersList_MouseDown(object? sender, MouseEventArgs e)
        {
            var playerControl = flpPlayersList.GetChildAtPoint(e.Location) as PlayerControl;
            if (playerControl != null)
            {
                playerControl.BackColor = Color.Blue;
                _selectedPlayerControl = playerControl;
                flpPlayersList.DoDragDrop(playerControl, DragDropEffects.Move);
            }
        }

        private void FlpFavouritePlayers_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(typeof(PlayerControl)) == true)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void FlpFavouritePlayers_DragDrop(object? sender, DragEventArgs e)
        {
            var playerControl = e.Data?.GetData(typeof(PlayerControl)) as PlayerControl;
            if (playerControl != null)
            {
                flpPlayersList.Controls.Remove(playerControl);
                flpFavouritePlayers.Controls.Add(playerControl);
            }
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if (flpFavouritePlayers.Controls.Count == 3)
            {
                return;
            }
            if (_selectedPlayerControl != null)
            {
                flpPlayersList.Controls.Remove(_selectedPlayerControl);
                flpFavouritePlayers.Controls.Add(_selectedPlayerControl);
                _settings.favouritePlayers.Add(_selectedPlayerControl.getName());
                _selectedPlayerControl.setIsFavourite(true);
                _selectedPlayerControl = null;
                SettingsController.SaveSettings();
            }
        }

        private void btnUnfavorite_Click(object sender, EventArgs e)
        {
            if (_selectedPlayerControl != null)
            {
                flpFavouritePlayers.Controls.Remove(_selectedPlayerControl);
                flpPlayersList.Controls.Add(_selectedPlayerControl);
                _selectedPlayerControl.setIsFavourite(false);
                _selectedPlayerControl = null; // Clear the selection
            }
        }

        private void ClearFlowLayoutPanels()
        {
            flpPlayersList.Controls.Clear();
            flpFavouritePlayers.Controls.Clear();
        }
    }
}