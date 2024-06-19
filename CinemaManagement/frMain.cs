using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Configuration;

namespace CinemaManagement
{
    public partial class frMain : Form
    {
        BindingSource gve, cbdp;
        SqlCommand cmd;
        LopDungChung a = new LopDungChung();
        public frMain()
        {
            InitializeComponent();
        }

        private void giave(string sql)
        {
            gve = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gve.DataSource = dt;
        }

        private void cbdangphim(string sql)
        {
            cbdp = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbdp.DataSource = dt;
        }

        private void frMain_Load(object sender, EventArgs e)
        {
            a.TaoKetNoi();
            if (a.cn.State == ConnectionState.Closed)
                a.cn.Open();
            giave("select * from Gia");
            cbdangphim("select  * from DangPhim");
            dgvGiaVe.DataSource = gve;
            cbDangPhim.DataSource = cbdp;
            cbDangPhim.DisplayMember = "TenDangPhim";
            cbDangPhim.ValueMember = "MaDangPhim";
        }

        private void dgvGiaVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMG.Text = dgvGiaVe.CurrentRow.Cells[0].Value.ToString();
            txtGiaVe.Text = dgvGiaVe.CurrentRow.Cells[2].Value.ToString();
            cbDangPhim.SelectedValue = dgvGiaVe.CurrentRow.Cells[1].Value.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sql = "insert into Gia values (@mag,@madp,@giatien)";
                cmd = new SqlCommand(sql, a.cn);
                cmd.Parameters.AddWithValue("@mag", txtMG.Text);
                cmd.Parameters.AddWithValue("@madp", cbDangPhim.SelectedValue);
                cmd.Parameters.AddWithValue("@giatien", txtGiaVe.Text);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataTable dt = (DataTable)gve.DataSource;
                    DataRow r = dt.NewRow();
                    r[0] = txtMG.Text;
                    r[1] = cbDangPhim.SelectedValue;
                    r[2] = txtGiaVe.Text;
                    dt.Rows.Add(r);
                    MessageBox.Show("Thêm thành công" + n + " dạng phim ", "Thông báo");
                }
                else MessageBox.Show("Không thể chọn", "Thông báo");
                a.cn.Close();
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                if (txtMG.Text == "")
                    MessageBox.Show("Xin vui lòng chọn giá để chỉnh sửa", "Thông báo");
                else
                {
                    string sql = "update Gia Set MaDangPhim = @madp, SoTien = @giatien where MaGia = @mag";
                    cmd = new SqlCommand(sql, a.cn);
                    cmd.Parameters.AddWithValue("@mag", txtMG.Text);
                    cmd.Parameters.AddWithValue("@madp", cbDangPhim.SelectedValue);
                    cmd.Parameters.AddWithValue("@giatien", txtGiaVe.Text);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DataRowView rv = (DataRowView)gve.Current;
                        rv[0] = txtMG.Text;
                        rv[1] = cbDangPhim.SelectedValue;
                        rv[2] = txtGiaVe.Text;
                        gve.ResetCurrentItem();
                        MessageBox.Show("Update thành công" + n + "dạng phim ", "Thông báo");
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

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMG.Text == "")
                    MessageBox.Show("Vui lòng chọn dạng phim để xóa", "Thông báo");
                else
                {
                    if (a.cn.State == ConnectionState.Closed)
                        a.cn.Open();
                    string sql = "delete from Gia where MaGia = @mag";
                    cmd = new SqlCommand(sql, a.cn);
                    cmd.Parameters.AddWithValue("@mag", txtMG.Text);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DataRowView r = (DataRowView)gve.Current;
                        r.Delete();
                        MessageBox.Show("Xóa thành công " + n + " dạng phim", "Thông báo");
                    }
                    else MessageBox.Show("Xóa không thành công", "Thông báo");
                }
                a.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
