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
    public partial class forminthongtin : Form
    {
        BindingSource nv, sc,dd,r,nvien,km,gkm, gia;

        LopDungChung a = new LopDungChung();
        public forminthongtin()
        {
            InitializeComponent();
        }

        private void taoSourceNV(string sql)
        {
            nv = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            nv.DataSource = dt;
        }

        private void suatchieu(string sql)
        {
            sc = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sc.DataSource = dt;
        }

        private void dinhdang(string sql)
        {
            dd = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dd.DataSource = dt;
        }

        private void rap(string sql)
        {
            r = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            r.DataSource = dt;
        }

        private void nhanvien(string sql)
        {
            nvien = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            nvien.DataSource = dt;
        }

        private void khuyenmai(string sql)
        {
            km = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            km.DataSource = dt;
        }

        private void giaKM(string sql)
        {
            gkm = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gkm.DataSource = dt;
        }

        private void gias(string sql)
        {
            gia = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gia.DataSource = dt;
        }

        private void forminthongtin_Load(object sender, EventArgs e)
        {
            a.TaoKetNoi();
            a.cn.Open();
            taoSourceNV("select MaPhim, TenP from Phim");
            comboBox1.DataSource = nv;
            comboBox1.DisplayMember = "TenP";
            comboBox1.ValueMember = "MaPhim";
            suatchieu("select MaS, GioChieu + 'h' + PhutChieu as ThoiGian from SuatChieu");
            comboBox2.DataSource = sc;
            comboBox2.DisplayMember = "ThoiGian";
            comboBox2.ValueMember = "MaS";
            dinhdang("select d.TenDangPhim , d.MaDangPhim from DangPhim d");
            comboBox3.DataSource = dd;
            comboBox3.DisplayMember = "TenDangPhim";
            comboBox3.ValueMember = "MaDangPhim";
            rap("select MaPC,TenPhong from PhongChieu");
            khuyenmai("select * from SuKienKM");
            cbKM.DataSource = km;
            cbKM.DisplayMember = "TenSuKien";
            cbKM.ValueMember = "MaSuKien";
            comboBox4.DataSource = r;
            comboBox4.DisplayMember = "TenPhong";
            comboBox4.ValueMember = "MaPC";
            nhanvien("select MaNV, HoNV+' '+TenNV as HoTen from NhanVien where IDChucVu = 2");
            comboBox5.DataSource = nvien;
            comboBox5.DisplayMember = "HoTen";
            comboBox5.ValueMember = "MaNV";
        }

        private void tbSoghe_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSoghe.Text == "")
                {
                    TruyenData.TongGhe = Convert.ToInt32(textBox1.Text);
                    Form1 gicungduoc = new Form1();
                    gicungduoc.ShowDialog();
                    tbSoghe.Text = TruyenData.SoGhe;
                    tbGiave.Text = TruyenData.ThanhTien.ToString();
                }
                else MessageBox.Show("Ban da chon ghe xong roi");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Thông báo");
            }
        }

        private void XuatRaVe()
        {
            TruyenData.TenNV2Ve = comboBox5.Text;
            TruyenData.TenPhim = comboBox1.Text;
            TruyenData.DinhDang = comboBox3.Text;
            TruyenData.Suat = comboBox2.Text;
            TruyenData.TenRap = comboBox4.Text;
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                TruyenData.maGG = Convert.ToInt32(comboBox3.SelectedValue);
                gias("select d.MaDangPhim, g.SoTien from DangPhim d, Gia g where d.MaDangPhim = g.MaDangPhim and d.MaDangPhim = '" + TruyenData.maGG + "'");
                DataTable dbgia = (DataTable)gia.DataSource;
                DataRow drgia = dbgia.Rows[0];
                TruyenData.GiaVe = Convert.ToInt32(drgia[1]);
                TruyenData.maSK = Convert.ToInt32(cbKM.SelectedValue);
                giaKM("select MucGiamGia from SuKienKM where MaSuKien = '" + TruyenData.maSK + "'");
                DataTable dt = (DataTable)gkm.DataSource;
                DataRow dr = dt.Rows[0];
                TruyenData.MucGiamGia = Convert.ToInt32(dr[0]);
                a.TinhTien();
                tbGiave.Text = TruyenData.ThanhTien.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void capnhatVe()
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                a.cn.Open();
                string sql = "insert into Ve(MaNV,MaPC,MaS,MaGia,MaSuKien,MaPhim,Ghe,DonGia) values (@manv,@mapc,@mas,@magia,@mask,@maphim,@ghe,@thanhtien)";
                SqlCommand cmd = new SqlCommand(sql, a.cn);
                cmd.Parameters.AddWithValue("@manv", comboBox5.SelectedValue);
                cmd.Parameters.AddWithValue("@mapc", comboBox4.SelectedValue);
                cmd.Parameters.AddWithValue("@mas", comboBox2.SelectedValue);
                cmd.Parameters.AddWithValue("@magia", comboBox3.SelectedValue);
                cmd.Parameters.AddWithValue("@mask", cbKM.SelectedValue);
                cmd.Parameters.AddWithValue("@maphim", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@ghe", TruyenData.SoGhe);
                cmd.Parameters.AddWithValue("thanhtien", TruyenData.ThanhTien);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void btXuat_Click(object sender, EventArgs e)
        {
            try
            {
                XuatRaVe();
                capnhatVe();
                frRP ve = new frRP();
                ve.ShowDialog();
                tbSoghe.Text = tbGiave.Text = textBox1.Text = "";
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                frThongKe tk = new frThongKe();
                tk.Show();
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void btGiaVe_Click(object sender, EventArgs e)
        {
            frMain giave = new frMain();
            giave.Show();
        }
    }
}
