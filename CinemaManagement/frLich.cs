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
    public partial class frLich : Form
    {
        public static string manv, cangay, ngaycheck, qlcheck;
        BindingSource ds = new BindingSource();
        LopDungChung a = new LopDungChung();
        SqlCommand cmd;
        public frLich()
        {
            InitializeComponent();
        }

        private void nhapCaNgay(int cngay)
        {
            cangay = cangay + cngay + ",";
        }

        private void checkNgay()
        {
            if (checkT2Sang.Checked == true)
                nhapCaNgay(12);
            if (checkT2Chieu.Checked == true)
                nhapCaNgay(22);
            if (checkT2Toi.Checked == true)
                nhapCaNgay(32);
            if (checkT3Sang.Checked == true)
                nhapCaNgay(13);
            if (checkT3Chieu.Checked == true)
                nhapCaNgay(23);
            if (checkT3Toi.Checked == true)
                nhapCaNgay(33);
            if (checkT4Sang.Checked == true)
                nhapCaNgay(14);
            if (checkT4Chieu.Checked == true)
                nhapCaNgay(24);
            if (checkT4Toi.Checked == true)
                nhapCaNgay(34);
            if (checkT5Sang.Checked == true)
                nhapCaNgay(15);
            if (checkT5Chieu.Checked == true)
                nhapCaNgay(25);
            if (checkT5Toi.Checked == true)
                nhapCaNgay(35);
            if (checkT6Sang.Checked == true)
                nhapCaNgay(16);
            if (checkT6Chieu.Checked == true)
                nhapCaNgay(26);
            if (checkT6Toi.Checked == true)
                nhapCaNgay(36);
            if (checkT7Sang.Checked == true)
                nhapCaNgay(17);
            if (checkT7Chieu.Checked == true)
                nhapCaNgay(27);
            if (checkT7Toi.Checked == true)
                nhapCaNgay(37);
            if (checkCNSang.Checked == true)
                nhapCaNgay(18);
            if (checkCNChieu.Checked == true)
                nhapCaNgay(28);
            if (checkCNToi.Checked == true)
                nhapCaNgay(38);
        }

        private void taoSourceNV(string sql)
        {
            ds = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ds.DataSource = dt;
        }

        private void btXacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                a.cn.Open();
                frLogin l = new frLogin();
                string sqlds = "select N.MaNV, N.HoNV, N.TenNV, T.TenTK from NhanVien N,TaiKhoan T where T.MaNV = N.MaNV and T.TenTK = '" + TruyenData.tentk + "'";
                taoSourceNV(sqlds);
                DataTable dt = (DataTable)ds.DataSource;
                DataRow dr = dt.Rows[0];
                ngaycheck = DateTime.Today.ToString();
                qlcheck = "";
                checkNgay();
                string sql = "INSERT INTO Lich(MaNV,CaNgay,NgayNvCheck,NgayQlCheck,IDChucVu) VALUES (@manv,@cangay,@ngayNV,@NgayQL,@idchucvu)";
                cmd = new SqlCommand(sql, a.cn);
                cmd.Parameters.AddWithValue("@manv", dr[0].ToString());
                cmd.Parameters.AddWithValue("@cangay", cangay);
                cmd.Parameters.AddWithValue("@ngayNV", ngaycheck);
                cmd.Parameters.AddWithValue("@ngayQL", qlcheck);
                cmd.Parameters.AddWithValue("@idchucvu", TruyenData.id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã xác nhận", "Thông báo");
                this.Hide();
            }
            catch (SqlException d)
            {
                MessageBox.Show(d.Message);
            }
            finally
            {
                a.cn.Close();
            }
        }

        private void frLich_Load(object sender, EventArgs e)
        {
            a.TaoKetNoi();
            lbfrLichTenTK.Text = "Xin chào " + TruyenData.tentk;
        }
    }
}
