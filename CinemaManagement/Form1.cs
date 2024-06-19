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
    public partial class Form1 : Form
    {
        BindingSource gkm;
        LopDungChung a = new LopDungChung();
        int soghe  = TruyenData.TongGhe;
        int tien = TruyenData.GiaVe;
        public Form1()
        {
            InitializeComponent();
        }

        private void giaKM(string sql)
        {
            gkm = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gkm.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a.TaoKetNoi();
            labeldem.Text = soghe.ToString();
        }

        private void HUY_Click(object sender, EventArgs e)
        {
            label2.BackColor = label3.BackColor = label4.BackColor = label5.BackColor = label6.BackColor = label7.BackColor = label8.BackColor = label9.BackColor = label10.BackColor = label11.BackColor = label12.BackColor = label13.BackColor = label14.BackColor = label15.BackColor = label16.BackColor = label17.BackColor = label18.BackColor = label19.BackColor = label20.BackColor = label21.BackColor = label22.BackColor = label23.BackColor = label24.BackColor = label25.BackColor = label26.BackColor = label27.BackColor = label28.BackColor = label29.BackColor = label30.BackColor = label31.BackColor = label32.BackColor = label33.BackColor = label34.BackColor = label35.BackColor = label36.BackColor = Color.Khaki;
            TruyenData.SoGhe = "";
            soghe = TruyenData.TongGhe;
            labeldem.Text = soghe.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                a.cn.Open();
                Label lb = (Label)sender;
                lb.BackColor = Color.Red;
                soghe--;
                labeldem.Text=soghe.ToString();
                TruyenData.SoGhe = TruyenData.SoGhe + lb.Text + ',';
                if (soghe == 0)
                {
                    giaKM("select MucGiamGia from SuKienKM where MaSuKien = '" + TruyenData.maSK + "'");
                    DataTable dt = (DataTable)gkm.DataSource;
                    DataRow dr = dt.Rows[0];
                    TruyenData.MucGiamGia = Convert.ToInt32(dr[0]);
                    a.TinhTien();
                    MessageBox.Show("Ban da chon het ghe!");
                }
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void KETTHUC_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
