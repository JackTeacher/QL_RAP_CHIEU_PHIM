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
    public partial class FrSuatChieu : Form
    {
        BindingSource suatchieu, lichchieu, phongchieu;
        BindingSource cbphim, cbphongchieu, cbsuatchieu, cbtennv;
        SqlCommand cmd;
        LopDungChung a = new LopDungChung();
        string sqlcbsuatchieu = "select MaS, GioChieu+':'+PhutChieu as ThoiGian from SuatChieu";
        public FrSuatChieu()
        {
            InitializeComponent();
        }

        private void taoSourceSC(string sql)
        {
            suatchieu = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            suatchieu.DataSource = dt;
        }

        private void taoSourceCBPhim(string sql)
        {
            cbphim = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbphim.DataSource = dt;
        }

        private void taoSourceLC(string sql)
        {
            lichchieu = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lichchieu.DataSource = dt;
        }

        private void taoSourcecbPhongchieu(string sql)
        {
            cbphongchieu = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbphongchieu.DataSource = dt;
        }

        private void taoSourcecbSuatchieu(string sql)
        {
            cbsuatchieu = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbsuatchieu.DataSource = dt;
        }

        private void taoSourcePC(string sql)
        {
            phongchieu = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            phongchieu.DataSource = dt;
        }

        private void taoSourcecbTenNhanVien(string sql)
        {
            cbtennv = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbtennv.DataSource = dt;
        }

        private void FrSuatChieu_Load(object sender, EventArgs e)
        {
            a.TaoKetNoi();
            if (a.cn.State == ConnectionState.Closed)
                a.cn.Open();
            //Form SC
            string sqlsc = "select * from SuatChieu";
            taoSourceSC(sqlsc);
            dgvSC.DataSource = suatchieu;

            //Combobox Tenphim
            string sqlcbphim = "select TenP, MaPhim from Phim P";
            taoSourceCBPhim(sqlcbphim);
            cbSCTP.DataSource = cbphim;
            cbSCTP.DisplayMember = "TenP";
            cbSCTP.ValueMember = "MaPhim";

            //Form LC
            string sqllc = " select * from LichChieu";
            taoSourceLC(sqllc);
            dgvLC.DataSource = lichchieu;

            //Combobox PhongChieu
            string sqlcbphongchieu = "select MaPC , TenPhong from PhongChieu PC";
            taoSourcecbPhongchieu(sqlcbphongchieu);
            cbLCPC.DataSource = cbphongchieu;
            cbLCPC.DisplayMember = "TenPhong";
            cbLCPC.ValueMember = "MaPC";

            //Combobox SuatChieu
            taoSourcecbSuatchieu(sqlcbsuatchieu);
            cbLCSC.DataSource = cbsuatchieu;
            cbLCSC.DisplayMember = "ThoiGian";
            cbLCSC.ValueMember = "MaS";

            //ComboboxPhim LC
            cbLCTP.DataSource = cbphim;
            cbLCTP.DisplayMember = "TenP";
            cbLCTP.ValueMember = "MaPhim";

            //Form Phòng Chiếu
            string sqlpc = " select * from PhongChieu";
            taoSourcePC(sqlpc);
            dgvPC.DataSource = phongchieu;

            //ComboboxTenNV PC
            string sqlnvPC = "select MaNV, HoNV+' '+TenNV as HoTen from NhanVien where IDChucVu = 3";
            taoSourcecbTenNhanVien(sqlnvPC);
            cbPCMaNV.DataSource = cbtennv;
            cbPCMaNV.DisplayMember = "HoTen";
            cbPCMaNV.ValueMember = "MaNV";
        }

        // Form Suất Chiếu

        private void btSCThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sqlSCThem = "insert into SuatChieu(MaS,MaPhim,GioChieu,PhutChieu) values (@mas,@maphim,@giochieu,@phutchieu)";
                cmd = new SqlCommand(sqlSCThem, a.cn);
                cmd.Parameters.AddWithValue("@mas", txtSCMS.Text);
                cmd.Parameters.AddWithValue("@maphim", cbSCTP.SelectedValue);
                cmd.Parameters.AddWithValue("@giochieu", txtGioChieu.Text);
                cmd.Parameters.AddWithValue("@phutchieu", txtPhutChieu.Text);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataTable dt = (DataTable)suatchieu.DataSource;
                    DataRow r = dt.NewRow();
                    r[0] = txtSCMS.Text;
                    r[1] = cbSCTP.SelectedValue;
                    r[2] = txtGioChieu.Text;
                    r[3] = txtPhutChieu.Text;
                    dt.Rows.Add(r);
                    MessageBox.Show("Thêm thành công " + n + " suất chiếu ", "Thông báo");
                    taoSourcecbSuatchieu(sqlcbsuatchieu);
                    cbLCSC.DataSource = cbsuatchieu;
                    cbLCSC.DisplayMember = "ThoiGian";
                    cbLCSC.ValueMember = "MaS";
                }
                else MessageBox.Show("Không thể thêm", "Thông báo");
                a.cn.Close();
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void btSCSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                if (txtSCMS.Text == "")
                    MessageBox.Show("Xin vui lòng chọn suất chiếu ", "Thông báo");
                else
                {
                    string sqlSCSua = "update SuatChieu Set MaPhim = @maphim, GioChieu = @giochieu, PhutChieu =@phutchieu where MaS = @mas";
                    cmd = new SqlCommand(sqlSCSua, a.cn);
                    cmd.Parameters.AddWithValue("@mas", txtSCMS.Text);  
                    cmd.Parameters.AddWithValue("@maphim", cbSCTP.SelectedValue);
                    cmd.Parameters.AddWithValue("@giochieu", txtGioChieu.Text);
                    cmd.Parameters.AddWithValue("@phutchieu", txtPhutChieu.Text);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DataRowView rv = (DataRowView)suatchieu.Current;
                        rv[1] = cbSCTP.SelectedValue;
                        rv[2] = txtGioChieu.Text;
                        rv[3] = txtPhutChieu.Text;
                        suatchieu.ResetCurrentItem();
                        MessageBox.Show("Update thành công " + n + " suất chiếu ", "Thông báo");
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

        private void btSCXoa_Click(object sender, EventArgs e)
        {
            if (txtSCMS.Text == "")
                MessageBox.Show("Vui lòng chọn suất chiếu ", "Thông báo");
            else
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sql = "delete from SuatChieu where MaS = @mas";
                cmd = new SqlCommand(sql, a.cn);
                cmd.Parameters.AddWithValue("@mas", txtSCMS.Text);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataRowView r = (DataRowView)suatchieu.Current;
                    r.Delete();
                    MessageBox.Show("Xóa thành công " + n + " suất chiếu ", "Thông báo");
                }
                else MessageBox.Show("Xóa không thành công", "Thông báo");
            }
            a.cn.Close();
        }

        // Form LichChieu

        private void btLCThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sqlLCThem = "insert into LichChieu(MaChieu,MaPC,MaS,NgayChieu,MaPhim) values (@machieu,@mapc,@mas,@ngaychieu,@maphim)";
                cmd = new SqlCommand(sqlLCThem, a.cn);
                cmd.Parameters.AddWithValue("@machieu", txtLCMC.Text);
                cmd.Parameters.AddWithValue("@mapc", cbLCPC.SelectedValue);
                cmd.Parameters.AddWithValue("@mas", cbLCSC.SelectedValue);
                cmd.Parameters.AddWithValue("@ngaychieu", Convert.ToDateTime(dateNgayChieu.Text));
                cmd.Parameters.AddWithValue("@maphim", cbLCTP.SelectedValue);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataTable dt = (DataTable)lichchieu.DataSource;
                    DataRow r = dt.NewRow();
                    r[0] = txtLCMC.Text;
                    r[1] = cbLCPC.SelectedValue;
                    r[2] = cbLCSC.SelectedValue;
                    r[3] = dateNgayChieu.Text;
                    r[4] = cbLCTP.SelectedValue;
                    dt.Rows.Add(r);
                    MessageBox.Show("Thêm thành công " + n + " lịch chiếu ", "Thông báo");
                }
                else MessageBox.Show("Không thể thêm", "Thông báo");
                a.cn.Close();
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void btLCSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                if (txtLCMC.Text == "")
                    MessageBox.Show("Xin vui lòng chọn lịch chiếu ", "Thông báo");
                else
                {
                    string sqlLCSua = "update LichChieu Set MaPC = @mapc, MaS = @mas, NgayChieu =@ngaychieu, MaPhim = @maphim where MaChieu = @machieu";
                    cmd = new SqlCommand(sqlLCSua, a.cn);
                    cmd.Parameters.AddWithValue("@machieu", txtLCMC.Text);
                    cmd.Parameters.AddWithValue("@mapc", cbLCPC.SelectedValue);
                    cmd.Parameters.AddWithValue("@mas", cbLCSC.SelectedValue);
                    cmd.Parameters.AddWithValue("@ngaychieu", Convert.ToDateTime(dateNgayChieu.Value));
                    cmd.Parameters.AddWithValue("@maphim", cbLCTP.SelectedValue);
                    cmd.Parameters.AddWithValue("@machieu", txtLCMC.Text);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DataRowView rv = (DataRowView)lichchieu.Current;
                        rv[1] = cbLCPC.SelectedValue;
                        rv[2] = cbLCSC.SelectedValue;
                        rv[3] = Convert.ToDateTime(dateNgayChieu.Value);
                        rv[4] = cbLCTP.SelectedValue;
                        lichchieu.ResetCurrentItem();
                        MessageBox.Show("Update thành công " + n + " lịch chiếu ", "Thông báo");
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

        private void btLCXoa_Click(object sender, EventArgs e)
        {
            if (txtLCMC.Text == "")
                MessageBox.Show("Vui lòng chọn suất chiếu", "Thông báo");
            else
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sqlLCxoa = "delete from LichChieu where MaChieu = @machieu";
                cmd = new SqlCommand(sqlLCxoa, a.cn);
                cmd.Parameters.AddWithValue("@machieu", txtLCMC.Text);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataRowView r = (DataRowView)lichchieu.Current;
                    r.Delete();
                    MessageBox.Show("Xóa thành công " + n + " lịch chiếu ", "Thông báo");
                }
                else MessageBox.Show("Xóa không thành công", "Thông báo");
            }
            a.cn.Close();
        }

        private void dgvLC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLCMC.Text = dgvLC.CurrentRow.Cells[0].Value.ToString();
            cbLCPC.SelectedValue = dgvLC.CurrentRow.Cells[1].Value.ToString();
            cbLCSC.SelectedValue = dgvLC.CurrentRow.Cells[2].Value.ToString();
            cbLCTP.SelectedValue = dgvLC.CurrentRow.Cells[4].Value.ToString();
            dateNgayChieu.Value = Convert.ToDateTime(dgvLC.CurrentRow.Cells[3].Value.ToString());
        }

        private void dgvSC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSCMS.Text = dgvSC.CurrentRow.Cells[0].Value.ToString();
            txtGioChieu.Text = dgvSC.CurrentRow.Cells[2].Value.ToString();
            cbSCTP.SelectedValue = dgvSC.CurrentRow.Cells[1].Value.ToString();
            txtPhutChieu.Text = dgvSC.CurrentRow.Cells[3].Value.ToString();
        }


        private void tbLC_Click(object sender, EventArgs e)
        {
            
        }

        private void tbLC_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tbLC_MouseHover(object sender, EventArgs e)
        {
            
        }

        // form Phòng Chiếu

        private void btPCThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sqlPCThem = "insert into PhongChieu(MaPC,TenPhong,MaNV, SoGhe,DayGhe) values (@mapc,@tenphong,@manv,@soghe,@dayghe)";
                cmd = new SqlCommand(sqlPCThem, a.cn);
                cmd.Parameters.AddWithValue("@mapc", txtPCMPC.Text);
                cmd.Parameters.AddWithValue("@tenphong", txtPCTP.Text);
                cmd.Parameters.AddWithValue("@manv", cbPCMaNV.SelectedValue);
                cmd.Parameters.AddWithValue("@soghe", txtPCSG.Text);
                cmd.Parameters.AddWithValue("@dayghe", txtPCDG.Text);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataTable dt = (DataTable)phongchieu.DataSource;
                    DataRow r = dt.NewRow();
                    r[0] = txtPCMPC.Text;
                    r[1] = txtPCTP.Text;
                    r[2] = cbPCMaNV.SelectedValue;
                    r[3] = txtPCSG.Text;
                    r[4] = txtPCDG.Text;
                    dt.Rows.Add(r);
                    MessageBox.Show("Thêm thành công " + n + " lịch chiếu ", "Thông báo");
                    taoSourcecbPhongchieu("select MaPC , TenPhong from PhongChieu PC");
                    cbLCPC.DataSource = cbphongchieu;
                    cbLCPC.DisplayMember = "TenPhong";
                    cbLCPC.ValueMember = "MaPC";
                }
                else MessageBox.Show("Không thể thêm", "Thông báo");
                a.cn.Close();
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void btPCSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                if (txtPCMPC.Text == "")
                    MessageBox.Show("Xin vui lòng chọn phòng chiếu ", "Thông báo");
                else
                {
                    string sqlLCSua = "update LichChieu Set TenPhong = @tenphong, MaNV =@manv, SoGhe = @soghe,DayGhe = @dayghe where MaPC = @mapc";
                    cmd = new SqlCommand(sqlLCSua, a.cn);
                    cmd.Parameters.AddWithValue("@mapc", txtPCMPC.Text);
                    cmd.Parameters.AddWithValue("@tenphong", txtPCTP.Text);
                    cmd.Parameters.AddWithValue("@manv", cbPCMaNV.SelectedValue);
                    cmd.Parameters.AddWithValue("@soghe", txtPCSG.Text);
                    cmd.Parameters.AddWithValue("@dayghe", txtPCSG.Text);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DataRowView rv = (DataRowView)phongchieu.Current;
                        rv[1] = txtPCTP.Text;
                        rv[2] = cbPCMaNV.SelectedValue;
                        rv[3] = txtPCSG.Text;
                        rv[4] = txtPCSG.Text;
                        phongchieu.ResetCurrentItem();
                        MessageBox.Show("Update thành công " + n + " phòng chiếu ", "Thông báo");
                        taoSourcecbPhongchieu("select MaPC , TenPhong from PhongChieu PC");
                        cbLCPC.DataSource = cbphongchieu;
                        cbLCPC.DisplayMember = "TenPhong";
                        cbLCPC.ValueMember = "MaPC";
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

        private void btPCXoa_Click(object sender, EventArgs e)
        {
            if (txtPCMPC.Text == "")
                MessageBox.Show("Vui lòng chọn phòng chiếu", "Thông báo");
            else
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sqlPCxoa = "delete from LichChieu where MaPC = @mapc";
                cmd = new SqlCommand(sqlPCxoa, a.cn);
                cmd.Parameters.AddWithValue("@mapc", txtPCMPC.Text);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataRowView r = (DataRowView)phongchieu.Current;
                    r.Delete();
                    MessageBox.Show("Xóa thành công " + n + " phòng chiếu ", "Thông báo");
                    taoSourcecbPhongchieu("select MaPC , TenPhong from PhongChieu PC");
                    cbLCPC.DataSource = cbphongchieu;
                    cbLCPC.DisplayMember = "TenPhong";
                    cbLCPC.ValueMember = "MaPC";
                }
                else MessageBox.Show("Xóa không thành công", "Thông báo");
            }
            a.cn.Close();
        }

        private void dgvPC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPCMPC.Text = dgvPC.CurrentRow.Cells[0].Value.ToString();
            txtPCTP.Text = dgvPC.CurrentRow.Cells[1].Value.ToString();
            cbPCMaNV.SelectedValue = dgvPC.CurrentRow.Cells[2].Value.ToString();
            txtPCSG.Text = dgvPC.CurrentRow.Cells[3].Value.ToString();
            txtPCDG.Text = dgvPC.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
