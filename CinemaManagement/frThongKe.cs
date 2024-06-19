using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CinemaManagement
{
    public partial class frThongKe : Form
    {
        BindingSource rp;
        LopDungChung a = new LopDungChung();
        public frThongKe()
        {
            InitializeComponent();
        }

        private void taoRP(string sql)
        {
            rp = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rp.DataSource = dt;
        }

        private void frThongKe_Load(object sender, EventArgs e)
        {
            a.TaoKetNoi();
            if (a.cn.State == ConnectionState.Closed)
                a.cn.Open();
            taoRP("select * from Ve");
            dgvTK.DataSource = rp;
        }
    }
}
