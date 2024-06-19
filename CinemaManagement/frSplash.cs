using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CinemaManagement
{
    public partial class frSplash : Form
    {
        LopDungChung a = new LopDungChung();
        public frSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadingBar.Increment(5);
            if (loadingBar.Value == 100)
            {
                timer1.Stop();
                a.CheckConfig();
                this.Hide();
            }
        }

        private void frSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
