using WCup_Data.DataFetching;
using WCup_Data.Settings;

namespace WCup_Forms
{
    public partial class Form1 : Form
    {
        private readonly IDataFetcher _fetcher;
        private readonly Settings _settings;
        public Form1()
        {
            InitializeComponent();
            _settings = SettingsController.GetSettings();
            _fetcher = FetchFactory.FetchData(_settings.DataFetchType);
        }
    }
}