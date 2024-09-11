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
        }
        private async Task LoadTeams()
        {
            if (_settings.FavouriteRepresentation != null)
            {
                cbRepresentation.SelectedItem = _settings.FavouriteRepresentation;
            }

            var rep = await _fetcher.FetchTeamDetails();
            var teams = rep.Select(m => m.FifaCode)
                .Order()
                .ToArray();
            cbRepresentation.Items.AddRange(teams);
            if (_settings.FavouriteRepresentation != null)
            {
                cbRepresentation.SelectedItem = _settings.FavouriteRepresentation?.ToString();
            }
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
            igraciUserControl1.setRep(fifaCode);
            rangListeUserControl1.setRep(fifaCode);
            _settings.FavouriteRepresentation = fifaCode;
            SettingsController.SaveSettings();
        }


    }
}