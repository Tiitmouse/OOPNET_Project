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
using WCup_Data.Settings;
using WCup_Forms.components;

namespace WCup_Forms.views
{
    public partial class IgraciUserControl : UserControl
    {
        string representation = null;

        public IgraciUserControl()
        {
            InitializeComponent();
            _settings = SettingsController.GetSettings();
            _fetcher = FetchFactory.FetchData(_settings.DataFetchType);
        }

        private IDataFetcher _fetcher;
        private Settings _settings;

        public void setRep(string rep)
        {
            representation = rep;
            LoadPlayers(rep);
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

        private void btnSetPlayerPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Image selectedImage = Image.FromFile(filePath);
                    pbPlayerPicture.Image = selectedImage;
                }
            }
        }
    }
}
