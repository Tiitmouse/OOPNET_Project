using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Resources;
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
using WCup_Data.Models;
using WCup_Data.PictureLoaders;

namespace WCup_WPF
{
    /// <summary>
    /// Interaction logic for playerOnFieldControl.xaml
    /// </summary>
    public partial class playerOnFieldControl : UserControl
    {
        public Player player { get; set; }
        public string team { get; set; }
        public string rteam { get; set; }
        public string picturePath { get; set; }
        public playerOnFieldControl()
        {
            InitializeComponent();
            
        }

        public void setPlayer(Player player)
        {
            this.player = player;
            LoadInfo();
        }

        public void setTeams(string team, string rteam)
        {
            this.team = team;
            this.rteam = rteam;
        }

        private void LoadInfo()
        {
            PCnumber.Content = player.ShirtNumber.ToString();
            PCname.Content = player.Name.ToString();
            picturePath = PictureUtils.LoadPicture(player.Name.ToString());
            if (File.Exists(picturePath))
            {
                ImageBrush imageBrush = new ImageBrush();
                imageBrush.ImageSource = new BitmapImage(new Uri(picturePath));
                PCPicture.Fill = imageBrush;
            }
        }

        private void openPlayerWindow(object sender, MouseButtonEventArgs e)
        {
            if (player == null || team == null || rteam == null)
            {
                MessageBox.Show("please select all");
                return;
            }
            PlayerWindow pw = new PlayerWindow(player, team, rteam);
            pw.ShowDialog();
        }
    }
}
