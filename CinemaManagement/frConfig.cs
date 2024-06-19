using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CinemaManagement
{
    public partial class frConfig : Form
    {
        LopDungChung a = new LopDungChung();
        public frConfig()
        {
            InitializeComponent();
        }

        private void UpdateConfiguration()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("Server");
            config.AppSettings.Settings.Add("Server", txtServer.Text);
            config.AppSettings.Settings.Remove("Database");
            config.AppSettings.Settings.Add("Database", txtData.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            UpdateConfiguration();
            a.TaoKetNoi();
            a.Connect();
            if (a.check == 1)
            {
                Application.Restart();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
