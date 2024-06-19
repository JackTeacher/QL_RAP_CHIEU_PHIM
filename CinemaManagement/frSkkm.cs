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
    public partial class frSkkm : Form
    {
        LopDungChung a = new LopDungChung();
        BindingSource sukienkm;
        SqlCommand cmd;
        public frSkkm()
        {
            InitializeComponent();
        }
        private void taoSourceSKKM(string sql)
        {
            sukienkm = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sukienkm.DataSource = dt;
        }

        private void frSkkm_Load(object sender, EventArgs e)
        {
            a.TaoKetNoi();
            if (a.cn.State == ConnectionState.Closed)
                a.cn.Open();
            // Form SKKM
            string sqlskkm = " select * from SuKienKM ";
            taoSourceSKKM(sqlskkm);
            dgvSKKM.DataSource = sukienkm;
        }

        private void btSKKMThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sqlSKKMThem = "insert into SuKienKM(MaSuKien,TenSuKien,NoiDung,NgayBatDau,NgayKetThuc,HinhAnh,MucGiamGia) values (@mask,@tensk,@noidung,@nbd,@nkt,@ha,@mgg)";
                cmd = new SqlCommand(sqlSKKMThem, a.cn);
                cmd.Parameters.AddWithValue("@mask", txtSKKMMSK.Text);
                cmd.Parameters.AddWithValue("@tensk", txtSKKMTSK.Text);
                cmd.Parameters.AddWithValue("@noidung", txtSKKMND.Text);
                cmd.Parameters.AddWithValue("@nbd", dateNBD.Text);
                cmd.Parameters.AddWithValue("@nkt", dateNKT.Text);
                cmd.Parameters.AddWithValue("@ha", txtSKKMHA.Text);
                cmd.Parameters.AddWithValue("@mgg", txtSKKMMGG.Text);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataTable dt = (DataTable)sukienkm.DataSource;
                    DataRow r = dt.NewRow();
                    r[0] = txtSKKMMSK.Text;
                    r[1] = txtSKKMTSK.Text;
                    r[2] = txtSKKMND.Text;
                    r[3] = dateNBD.Text;
                    r[4] = dateNKT.Text;
                    r[6] = txtSKKMHA.Text;
                    r[5] = txtSKKMMGG.Text;
                    dt.Rows.Add(r);
                    MessageBox.Show("Thêm thành công " + n + " sự kiện khuyến mãi ", "Thông báo");
                }
                else MessageBox.Show("Không thể thêm", "Thông báo");
                a.cn.Close();
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void btSKKMSua_Click(object sender, EventArgs e)
        {

            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                if (txtSKKMMSK.Text == "")
                    MessageBox.Show("Xin vui lòng chọn  ", "Thông báo");
                else
                {
                    string sqlQTPSua = "update SuKienKM Set TenSuKien = @tensk, NoiDung = @noidung, NgayBatDau =@nbd, NgayKetThuc = @nkt, HinhAnh = @ha,MucGiamGia = @mgg  where MaSuKien = @mask";
                    cmd = new SqlCommand(sqlQTPSua, a.cn);
                    cmd.Parameters.AddWithValue("@mask", txtSKKMMSK.Text);
                    cmd.Parameters.AddWithValue("@tensk", txtSKKMTSK.Text);
                    cmd.Parameters.AddWithValue("@noidung", txtSKKMND.Text);
                    cmd.Parameters.AddWithValue("@nbd", dateNBD.Text);
                    cmd.Parameters.AddWithValue("@nkt", dateNKT.Text);
                    cmd.Parameters.AddWithValue("@ha", txtSKKMHA.Text);
                    cmd.Parameters.AddWithValue("@mgg", txtSKKMMGG.Text);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DataRowView rv = (DataRowView)sukienkm.Current;
                        rv[1] = txtSKKMTSK.Text;
                        rv[2] = txtSKKMND.Text;
                        rv[3] = dateNBD.Text;
                        rv[4] = dateNKT.Text;
                        rv[6] = txtSKKMHA.Text;
                        rv[5] = txtSKKMMGG.Text;
                        sukienkm.ResetCurrentItem();
                        MessageBox.Show("Update thành công " + n + " sự kiện khuyến mãi ", "Thông báo");
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

        private void btSKKMXoa_Click(object sender, EventArgs e)
        {
            if (txtSKKMMSK.Text == "")
                MessageBox.Show("Vui lòng chọn", "Thông báo");
            else
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sqlSKKMxoa = "delete from SuKienKM where MaSuKien = @mask";
                cmd = new SqlCommand(sqlSKKMxoa, a.cn);
                cmd.Parameters.AddWithValue("@mask", txtSKKMMSK.Text);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataRowView r = (DataRowView)sukienkm.Current;
                    r.Delete();
                    MessageBox.Show("Xóa thành công " + n + " sự kiện  ", "Thông báo");
                }
                else MessageBox.Show("Xóa không thành công", "Thông báo");
            }
            a.cn.Close();
        }

        private void dgvSKKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSKKMMSK.Text = dgvSKKM.CurrentRow.Cells[0].Value.ToString();
            txtSKKMTSK.Text = dgvSKKM.CurrentRow.Cells[1].Value.ToString();
            txtSKKMND.Text = dgvSKKM.CurrentRow.Cells[2].Value.ToString();
            dateNBD.Text = dgvSKKM.CurrentRow.Cells[3].Value.ToString();
            dateNKT.Text = dgvSKKM.CurrentRow.Cells[4].Value.ToString();
            txtSKKMHA.Text = dgvSKKM.CurrentRow.Cells[6].Value.ToString();
            txtSKKMMGG.Text = dgvSKKM.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
