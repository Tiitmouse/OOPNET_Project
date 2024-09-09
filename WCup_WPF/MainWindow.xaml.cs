using System;
using System.Collections.Generic;
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

namespace WCup_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.Show();
            if(settingsWindow.IsEnabled)
            {
                this.IsEnabled = false;
                this.Opacity = 0.1;
            }
            settingsWindow.Closed += settingsWindow_Closed;
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            this.IsEnabled = false;
            settingsWindow.Closed += settingsWindow_Closed;
            this.Opacity = 0.1;
            settingsWindow.Show();
        }

        private void settingsWindow_Closed(object? sender, EventArgs e)
        {
            this.IsEnabled = true;
            this.Opacity = 1;
        }

        private void lblFavTeamInfo_Click(object sender, RoutedEventArgs e)
        {
            PlayerWindow pw = new PlayerWindow();
            pw.Show();
        }

        private void lblRivalTeamInfo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
