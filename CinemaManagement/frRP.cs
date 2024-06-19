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
    public partial class frRP : Form
    {
        public frRP()
        {
            InitializeComponent();
        }

        private void frRP_Load(object sender, EventArgs e)
        {
            lbTenPhim.Text = label1.Text = TruyenData.TenPhim;
            lbDangPhim.Text = label2.Text = TruyenData.DinhDang;
            lbPhongChieu.Text = label3.Text = TruyenData.TenRap;
            lbSoGhe.Text = label4.Text = TruyenData.SoGhe;
            lbSuatChieu.Text = label5.Text = TruyenData.Suat;
            lbTenNV.Text = "Tên người xuất vé: "+ TruyenData.TenNV2Ve;
            label6.Text = "NXV: " + TruyenData.TenNV2Ve;
            lbThanhTien.Text = label10.Text = "Tổng số tiền: " + TruyenData.ThanhTien;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
