using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCup_Data.Settings;
using static WCup_Data.Settings.Settings;

namespace WCup_Forms
{
    public partial class SettingsForm : Form
    {
        Settings s;
        public SettingsForm(Settings sett)
        {
            s = sett;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            setSettings();
        }

        private void setSettings()
        {
            s = SettingsController.GetSettings(); //myb no need 
            string ct = s.CType.ToString();
            string lang = s.DisplayLanguage.ToString();
            string df = s.DataFetchType.ToString();

            setCupType(ct);
            setLanguage(lang);
            setDataFetching(df);

        }
        private void setCupType(string ct)
        {
            switch (ct)
            {
                case "women":
                    rbCupTypeWomen.Select();
                    break;
                case "men":
                    rbCupTypeMen.Select();
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
                    rbLanguageEng.Select();
                    break;
                case "Croatian":
                    rbLanguageCro.Select();
                    break;
                default:
                    break;
            }
        }
        private void setDataFetching(string df)
        {
            switch (df)
            {
                case "L":
                    rbDataFechLocal.Select();
                    break;
                case "G":
                    rbDataFechGlobal.Select();
                    break;
                default:
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SettingsController.SaveSettings();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setSettings();
            this.Close();
        }

        private void rbCupTypeWomen_CheckedChanged(object sender, EventArgs e)
        {
            s.CType = CupType.women;
        }

        private void rbCupTypeMen_CheckedChanged(object sender, EventArgs e)
        {
            s.CType = CupType.men;
        }

        private void rbLanguageEng_CheckedChanged(object sender, EventArgs e)
        {
            s.DisplayLanguage = Language.English;
        }

        private void rbLanguageCro_CheckedChanged(object sender, EventArgs e)
        {
            s.DisplayLanguage = Language.Croatian;
        }

        private void rbDataFechLocal_CheckedChanged(object sender, EventArgs e)
        {
            s.DataFetchType = 'L';
        }

        private void rbDataFechGlobal_CheckedChanged(object sender, EventArgs e)
        {
            s.DataFetchType = 'G';
        }
    }
}
