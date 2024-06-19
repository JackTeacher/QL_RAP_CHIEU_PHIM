using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Threading;

namespace CinemaManagement
{
    public partial class frLogin : Form
    {
        LopDungChung a = new LopDungChung();
        BindingSource nv;
        DataTable dt;
        DataRow drs;
        DataSet ds;
        public frLogin()
        {
            InitializeComponent();
        }

        private void frLogin_Load(object sender, EventArgs e)
        {
            a.TaoKetNoi();
            TruyenData.ktdong = 0;
        }

        public DataSet loadIDChucVu()
        {
            try
            {
                string sql = "SELECT IDChucVu FROM TaiKhoan WHERE TenTK = '"+txtTenTKfrLogin.Text+"'";
                SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
                ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (SqlException a)
            {
                MessageBox.Show(a.Message);
                return null;
            }
        }

        private string MaHoaPass(string s)
        {
            string pssbyMD5 = ""; //tạo một chuỗi rỗng
            byte[] mangP = System.Text.Encoding.UTF8.GetBytes(s); //tạo một mảng kiểu byte lưu các kí tự đã mã hóa sang dạng UTF8 của chuỗi s
            MD5CryptoServiceProvider md5_str = new MD5CryptoServiceProvider(); //kiểu dữ liệu liên quan đến md5
            mangP = md5_str.ComputeHash(mangP); //mã hóa
            foreach (byte b in mangP)
            {
                pssbyMD5 += b.ToString("X2"); //cộng từng kí tự trong mangP đã mã hóa vào chuỗi
            }
            return pssbyMD5;
        }

        private void taoSourceNV(string sql)
        {
            nv = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            nv.DataSource = dt;
        }

        private void gandlF2()
        {
            TruyenData.tentk = txtTenTKfrLogin.Text;
            TruyenData.MaNV = drs[0].ToString();
            TruyenData.Ten = drs[1].ToString();
            TruyenData.DiaChi = drs[2].ToString();
            TruyenData.ChucVu = drs[3].ToString();
            TruyenData.Email = drs[4].ToString();
            TruyenData.SDT = drs[5].ToString();
        }

        private void btOKfrLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var idchucvu = loadIDChucVu().Tables[0];
                string pass = MaHoaPass(txtMKfrLogin.Text);
                string kiemtraTK = "SELECT * FROM TaiKhoan WHERE TenTK = '" + txtTenTKfrLogin.Text + "' AND pass = '" + pass + "'";
                SqlCommand cmd = new SqlCommand(kiemtraTK, a.cn);
                a.cn.Open();//mo ket noi luc nay
                string sql = "select N.MaNV,N.HoNV+' '+N.TenNV as Ten,N.DiaChi,C.ChucVu,N.Email,N.SDT, T.TenTK from NhanVien N, TaiKhoan T, ChucVu C where T.IDChucVu = N.IDChucVu and T.MaNV = N.MaNV and N.IDChucVu = C.IDChucVu and T.TenTK = '" + txtTenTKfrLogin.Text + "'";
                taoSourceNV(sql);
                dt = (DataTable)nv.DataSource;
                drs = dt.Rows[0];
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Hide();
                    TruyenData.id = Convert.ToInt32(idchucvu.Rows[0][0].ToString());
                    gandlF2();
                    TruyenData.ktdong = 1;
                    frMain2 m = new frMain2();
                    m.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, vui lòng bạn kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
                    txtTenTKfrLogin.Text = "";
                    txtMKfrLogin.Text = "";
                }
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message);
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
            finally
            {
                a.cn.Close();
            }
        }

        private void btHuyfrLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
