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
using WCup_Data.Models;

namespace WCup_WPF
{
    /// <summary>
    /// Interaction logic for playerOnFieldControl.xaml
    /// </summary>
    public partial class playerOnFieldControl : UserControl
    {
        public Player player { get; set; }
        public string picturePath { get; set; }
        public playerOnFieldControl(Player player)
        {
            this.player = player;
            InitializeComponent();
            LoadInfo();
        }

        private void LoadInfo()
        {
            PCnumber.Content = player.ShirtNumber.ToString();
            PCname.Content = player.Name.ToString();
            picturePath = System.IO.Path.Combine("path_to_your_images_directory", $"{player.Name}.jpg");
            if (File.Exists(picturePath))
            {
                ImageBrush imageBrush = new ImageBrush();
                imageBrush.ImageSource = new BitmapImage(new Uri(picturePath));
                PCPicture.Fill = imageBrush;
            }
            else
            {
                PCPicture.Fill = null;
            }
        }
    }
}
