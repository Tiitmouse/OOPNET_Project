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

namespace WCup_Forms.components
{
    public partial class PlayerControl : UserControl
    {
        private readonly Player player;
        public PlayerControl(Player p)
        {
            player = p;
            InitializeComponent();
        }
    }
}
