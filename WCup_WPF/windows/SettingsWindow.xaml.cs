using System.Windows;
using System.Windows.Controls;
using WCup_Data.Settings;
using static WCup_Data.Settings.Settings;

namespace WCup_WPF
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        Settings s;
        public SettingsWindow()
        {
            s = SettingsController.GetSettings();
            InitializeComponent();
            setSettings();
        }

        private void setSettings()
        {
            s = SettingsController.GetSettings(); //myb no need 
            string ct = s.CType.ToString();
            string lang = s.DisplayLanguage.ToString();
            string res = s.resolution?.ToString() ?? "490x820";


            setCupType(ct);
            setLanguage(lang);
            setResolution(res);
        }
        private void setCupType(string ct)
        {
            switch (ct)
            {
                case "women":
                    rbWomen.IsChecked = true;
                    break;
                case "men":
                    rbMen.IsChecked = true;
                    break;
                default:
                    break;


            }
        }
        private void setLanguage(string lang)
        {
            switch (lang)
            {
                case "English":
                    rbEnglish.IsChecked = true;
                    break;
                case "Croatian":
                    rbCroatian.IsChecked = true;
                    break;
                default:
                    break;
            }
        }

        private void setResolution(string res)
        {
            switch (res)
            {
                case "Fullscreen":
                    cbResolutions.SelectedIndex = 0;
                    break;
                case "720x1200":
                    cbResolutions.SelectedIndex = 2;
                    break;
                case "1000x1600":
                    cbResolutions.SelectedIndex = 3;
                    break;
                default:
                    cbResolutions.SelectedIndex = 1;
                    break;
            }
        }

        private void btnSaveSettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsController.SaveSettings();
            this.Close();
        }

        private void btnCancelSetings_Click(object sender, RoutedEventArgs e)
        {
            setSettings();
            this.Close();
        }

        private void cbResolutions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbResolutions.SelectedItem != null)
            {
                s.resolution = cbResolutions.SelectedItem?.ToString() ?? string.Empty;
            }
        }

        private void rbWomen_Checked(object sender, RoutedEventArgs e)
        {
            s.CType = CupType.women;
        }

        private void rbMen_Checked(object sender, RoutedEventArgs e)
        {
            s.CType = CupType.men;
        }

        private void rbEnglish_Checked(object sender, RoutedEventArgs e)
        {
            s.DisplayLanguage = Settings.Language.English;
        }

        private void rbCroatian_Checked(object sender, RoutedEventArgs e)
        {
            s.DisplayLanguage = Settings.Language.Croatian;
        }


    }
}
