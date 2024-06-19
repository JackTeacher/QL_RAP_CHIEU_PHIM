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
    public partial class frOrther : Form
    {

        LopDungChung a = new LopDungChung();
        BindingSource quaytp;
        BindingSource cbTenNV;
        SqlCommand cmd;
        public frOrther()
        {
            InitializeComponent();
        }


        private void taoSourceQThucPham(string sql)
        {
            quaytp = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            quaytp.DataSource = dt;
        }

        private void taoSourcecbQTPTenNV(string sql)
        {
            cbTenNV = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbTenNV.DataSource = dt;
        }

        private void frOrther_Load(object sender, EventArgs e)
        {
            a.TaoKetNoi();
            if (a.cn.State == ConnectionState.Closed)
                a.cn.Open();

            // Form Quay Thuc Pham
            string sqlqtp = " select * from QuayTP ";
            taoSourceQThucPham(sqlqtp);
            taoSourcecbQTPTenNV("select MaNV, HoNV+' '+TenNV as HoTen from NhanVien where IDChucVu = 3");
            dgvQTP.DataSource = quaytp;
            cbQTPMaNV.DataSource = cbTenNV;
            cbQTPMaNV.DisplayMember = "HoTen";
            cbQTPMaNV.ValueMember = "MaNV";
        }

        private void btQTPThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sqlQTPThem = "insert into QuayTP(MaSP,MaNV,TenSP,LoaiSP,SoLuong,DonVi) values (@masp,@manv,@tensp,@loaisp,@soluong,@donvi)";
                cmd = new SqlCommand(sqlQTPThem, a.cn);
                cmd.Parameters.AddWithValue("@masp",txtQTPMSP.Text);
                cmd.Parameters.AddWithValue("@manv",cbQTPMaNV.SelectedValue);
                cmd.Parameters.AddWithValue("@tensp", txtQTPTSP.Text);
                cmd.Parameters.AddWithValue("@loaisp", txtQTPLSP.Text);
                cmd.Parameters.AddWithValue("@soluong", txtQTPSL.Text);
                cmd.Parameters.AddWithValue("@donvi", txtQTPDV.Text);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataTable dt = (DataTable)quaytp.DataSource;
                    DataRow r = dt.NewRow();
                    r[0] = txtQTPMSP.Text;
                    r[1] = cbQTPMaNV.SelectedValue;
                    r[2] = txtQTPTSP.Text;
                    r[3] = txtQTPLSP.Text;
                    r[4] = txtQTPSL.Text;
                    r[5] = txtQTPDV.Text;
                    dt.Rows.Add(r);
                    MessageBox.Show("Thêm thành công " + n + " thực phẩm ", "Thông báo");
                }
                else MessageBox.Show("Không thể thêm", "Thông báo");
                a.cn.Close();
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void btQTPSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                if (txtQTPMSP.Text == "")
                    MessageBox.Show("Xin vui lòng chọn  ", "Thông báo");
                else
                {
                    string sqlQTPSua = "update QuayTP Set MaNV = @manv, TenSP = @tensp, LoaiSP =@loaisp, SoLuong = @soluong, DonVi = @donvi where MaSP = @masp";
                    cmd = new SqlCommand(sqlQTPSua, a.cn);
                    cmd.Parameters.AddWithValue("@masp", txtQTPMSP.Text);
                    cmd.Parameters.AddWithValue("@manv", cbQTPMaNV.SelectedValue);
                    cmd.Parameters.AddWithValue("@tensp", txtQTPTSP.Text);
                    cmd.Parameters.AddWithValue("@loaisp", txtQTPLSP.Text);
                    cmd.Parameters.AddWithValue("@soluong", txtQTPSL.Text);
                    cmd.Parameters.AddWithValue("@donvi", txtQTPDV.Text);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DataRowView rv = (DataRowView)quaytp.Current;
                        rv[1] = cbQTPMaNV.SelectedValue;
                        rv[2] = txtQTPTSP.Text;
                        rv[3] = txtQTPLSP.Text;
                        rv[4] = txtQTPSL.Text;
                        rv[5] = txtQTPDV.Text;
                        quaytp.ResetCurrentItem();
                        MessageBox.Show("Update thành công " + n + " thực phẩm ", "Thông báo");
                    }
                    else MessageBox.Show("Update thất bại", "Thông báo");
                }
                a.cn.Close();
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void btQTPXoa_Click(object sender, EventArgs e)
        {
            if (txtQTPMSP.Text == "")
                MessageBox.Show("Vui lòng chọn", "Thông báo");
            else
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sqlQTPxoa = "delete from QuayTP where MaSP = @masp";
                cmd = new SqlCommand(sqlQTPxoa, a.cn);
                cmd.Parameters.AddWithValue("@masp", txtQTPMSP.Text);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataRowView r = (DataRowView)quaytp.Current;
                    r.Delete();
                    MessageBox.Show("Xóa thành công " + n + " thực phẩm ", "Thông báo");
                }
                else MessageBox.Show("Xóa không thành công", "Thông báo");
            }
            a.cn.Close();
        }

        private void dgvQTP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtQTPMSP.Text = dgvQTP.CurrentRow.Cells[0].Value.ToString();
            cbQTPMaNV.SelectedValue = dgvQTP.CurrentRow.Cells[1].Value.ToString();
            txtQTPTSP.Text = dgvQTP.CurrentRow.Cells[2].Value.ToString();
            txtQTPLSP.Text = dgvQTP.CurrentRow.Cells[3].Value.ToString();
            txtQTPSL.Text = dgvQTP.CurrentRow.Cells[4].Value.ToString();
            txtQTPDV.Text = dgvQTP.CurrentRow.Cells[5].Value.ToString();
        }




    }
}
