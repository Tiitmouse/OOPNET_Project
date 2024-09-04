using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCup_Data.Models;
using WCup_Data.Settings;

namespace WCup_Forms.components
{
    public partial class PlayerControl : UserControl
    {
        private readonly Settings s = SettingsController.GetSettings();

        private readonly Player player;
        public PlayerControl(Player p)
        {
            player = p;
            InitializeComponent();
            setValues(p);
        }

        private void setValues(Player p)
        {
            lblPlayerNumber.Text = p.ShirtNumber.ToString();
            lblPlayerName.Text = p.Name;
            lblPlayerPosition.Text = p.Position.ToString();
            if (p.Captain)
            {
                lblPlayerIsCapetan.Text = "C";
            }
            foreach (var f in s.favouritePlayers)
            {
                if (f.Name.Equals(p.Name))
                {
                    lblPlayerIsFavourite.Text = "★";
                }
            }
        }
    }
}
