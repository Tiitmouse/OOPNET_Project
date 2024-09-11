using System;
using System.Windows;
using System.Windows.Controls;
using WCup_Data.Models;

namespace WCup_WPF.formationColumns
{
    /// <summary>
    /// Interaction logic for defenderControl.xaml
    /// </summary>
    public partial class defenderControl : UserControl
    {
        private int playerNumber;
        private Player playerToShow;

        public defenderControl(int plNum, Player plToShow)
        {
            this.playerNumber = plNum;
            playerToShow = plToShow;
            InitializeComponent();
            CreatePlayerOnFieldControls();
        }

        private void CreatePlayerOnFieldControls()
        {
            if (playerNumber < 1 || playerNumber > 5)
                throw new ArgumentOutOfRangeException(nameof(playerNumber), "Number of players must be between 1 and 5.");

            StackPanel stackPanel = new StackPanel
            {
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                Orientation = Orientation.Vertical
            };

            for (int i = 0; i < playerNumber; i++)
            {
                playerOnFieldControl playerControl = new playerOnFieldControl(playerToShow);
                stackPanel.Children.Add(playerControl);
            }

            LayoutRoot.Children.Clear();
            LayoutRoot.Children.Add(stackPanel);
        }
    }
}
