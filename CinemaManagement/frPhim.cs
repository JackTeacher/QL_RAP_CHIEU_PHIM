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
    public partial class frPhim : Form
    {
        BindingSource phim, mlp, mqg, mdp, dangphim, quocgia, loaiphim;
        SqlCommand cmd;
        LopDungChung a = new LopDungChung();
        public frPhim()
        {
            InitializeComponent();
        }

        private void frPhim_Load(object sender, EventArgs e)
        {
            a.TaoKetNoi();
            if (a.cn.State == ConnectionState.Closed)
                a.cn.Open();
            taoSourcecbMLP("select * from LoaiPhim");
            taoSourcePhim("select * from Phim");
            taoSourcecbDP("select * from DangPhim");
            taoSourcecbQG("select * from QuocGia");
            taoSourcedgvDP("select * from DangPhim");
            taoSourcedgvQG("select * from QuocGia");
            taoSourcedgvLP("select * from LoaiPhim");
            dataPhim.DataSource = phim;
            cbMLP.DataSource = mlp;
            cbMLP.DisplayMember = "TenLoaiPhim";
            cbMLP.ValueMember = "MaLoaiPhim";
            cbTP.DataSource = phim;
            cbTP.DisplayMember = "TenP";
            cbTP.ValueMember = "MaPhim";
            cbMDP.DataSource = mdp;
            cbMDP.DisplayMember = "TenDangPhim";
            cbMDP.ValueMember = "MaDangPhim";
            cbMQG1.DataSource = mqg;
            cbMQG1.DisplayMember = "TenQuocGia";
            cbMQG1.ValueMember = "MaQuocGia";
            dgvDP.DataSource = dangphim;
            dgvQG.DataSource = quocgia;
            dgvLP.DataSource = loaiphim;
        }
        // Form Phim
        private void taoSourcePhim(string sql)
        {
            phim = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            phim.DataSource = dt;
        }

        private void taoSourcecbMLP(string sql)
        {
            mlp = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mlp.DataSource = dt;
        }

        private void taoSourcecbQG(string sql)
        {
            mqg = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mqg.DataSource = dt;
        }

        private void taoSourcecbDP(string sql)
        {
            mdp = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mdp.DataSource = dt;
        }

        private void taoSourcedgvDP(string sql)
        {
            dangphim = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dangphim.DataSource = dt;
        }

        private void taoSourcedgvQG(string sql)
        {
            quocgia = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            quocgia.DataSource = dt;
        }

        private void taoSourcedgvLP(string sql)
        {
            loaiphim = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            loaiphim.DataSource = dt;
        }

        private void btPThem_Click(object sender, EventArgs e)
        {

            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sql = "insert into Phim(MaPhim , MaLoaiPhim , TenP , DoDaiGio , DoDaiPhut , MaQuocGia , MaDangPhim , NgayBatDau , NgayKetThuc , MoTaPhim, AnhPhim) VALUES (@maphim,@maloaiphim,@tenp,@dodaigio,@dodaiphut,@maquocgia,@madangphim,@ngaybatdau,@ngayketthuc,@motaphim,@anh) ";//anhphim
                cmd = new SqlCommand(sql, a.cn);
                cmd.Parameters.AddWithValue("@maphim", txtMP.Text);
                cmd.Parameters.AddWithValue("@maloaiphim", cbMLP.SelectedValue);
                cmd.Parameters.AddWithValue("@tenp", cbTP.Text);
                cmd.Parameters.AddWithValue("@dodaigio", txtGio.Text);
                cmd.Parameters.AddWithValue("@dodaiphut", txtPhut.Text);
                cmd.Parameters.AddWithValue("@maquocgia", cbMQG1.SelectedValue);
                cmd.Parameters.AddWithValue("@madangphim", cbMDP.SelectedValue);
                cmd.Parameters.AddWithValue("@ngaybatdau", Convert.ToDateTime(dateNBD.Text));
                cmd.Parameters.AddWithValue("@ngayketthuc", Convert.ToDateTime(dateNKT.Text));
                cmd.Parameters.AddWithValue("@motaphim", txtMTP.Text);
                cmd.Parameters.AddWithValue("@anh", txtHinh.Text);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataTable dt = (DataTable)phim.DataSource;
                    DataRow r = dt.NewRow();
                    r[0] = txtMP.Text;
                    r[1] = cbMLP.SelectedValue;
                    r[2] = cbTP.Text;
                    r[3] = txtGio.Text;
                    r[4] = txtPhut.Text;
                    r[5] = cbMQG1.SelectedValue;
                    r[6] = cbMDP.SelectedValue;
                    r[7] = dateNBD.Text;
                    r[8] = dateNKT.Text;
                    r[9] = txtMTP.Text;
                    r[10] = txtHinh.Text;
                    dt.Rows.Add(r);
                    MessageBox.Show("Thêm thành công " + n + " phim ", "Thông báo");
                }
                else MessageBox.Show("Không thể thêm", "Thông báo");
                a.cn.Close();
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void btPSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                if (txtMP.Text == "")
                    MessageBox.Show("Xin vui lòng chọn phim để chỉnh sửa", "Thông báo");
                else
                {
                    string sql = "update Phim Set  MaLoaiPhim = @maloaiphim , TenP = @tenp , DoDaiGio = @dodaigio , DoDaiPhut = @dodaiphut , MaQuocGia = @maquocgia , MaDangPhim = @madangphim , NgayBatDau = @ngaybatdau , NgayKetThuc = @ngayketthuc , MoTaPhim = @motaphim, AnhPhim = @anh  where MaPhim = @maphim ";//anhphim
                    cmd = new SqlCommand(sql, a.cn);
                    cmd.Parameters.AddWithValue("@maphim", txtMP.Text);
                    cmd.Parameters.AddWithValue("@maloaiphim", cbMLP.SelectedValue);
                    cmd.Parameters.AddWithValue("@tenp", cbTP.SelectedValue);
                    cmd.Parameters.AddWithValue("@dodaigio", txtGio.Text);
                    cmd.Parameters.AddWithValue("@dodaiphut", txtPhut.Text);
                    cmd.Parameters.AddWithValue("@maquocgia", cbMQG1.SelectedValue);
                    cmd.Parameters.AddWithValue("@madangphim", cbMDP.SelectedValue);
                    cmd.Parameters.AddWithValue("@ngaybatdau", Convert.ToDateTime(dateNBD.Text));
                    cmd.Parameters.AddWithValue("@ngayketthuc", Convert.ToDateTime(dateNKT.Text));
                    cmd.Parameters.AddWithValue("@motaphim", txtMTP.Text);
                    cmd.Parameters.AddWithValue("@anh", txtHinh.Text);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DataRowView rv = (DataRowView)phim.Current;
                        rv[1] = cbMLP.SelectedValue;
                        rv[2] = cbTP.Text;
                        rv[3] = txtGio.Text;
                        rv[4] = txtPhut.Text;
                        rv[5] = cbMQG1.SelectedValue;
                        rv[6] = cbMDP.SelectedValue;
                        rv[7] = dateNBD.Text;
                        rv[8] = dateNKT.Text;
                        rv[9] = txtMTP.Text;
                        rv[10] = txtHinh.Text;
                        phim.ResetCurrentItem();
                        MessageBox.Show("Update thành công " + n + " phim ", "Thông báo");
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

        private void dataPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMP.Text = dataPhim.CurrentRow.Cells[0].Value.ToString();
            cbMLP.SelectedValue = dataPhim.CurrentRow.Cells[1].Value.ToString();
            cbTP.SelectedValue = dataPhim.CurrentRow.Cells[0].Value.ToString();
            txtGio.Text = dataPhim.CurrentRow.Cells[3].Value.ToString();
            txtPhut.Text = dataPhim.CurrentRow.Cells[4].Value.ToString();
            cbMQG1.SelectedValue = dataPhim.CurrentRow.Cells[5].Value.ToString();
            cbMDP.SelectedValue = dataPhim.CurrentRow.Cells[6].Value.ToString();
            dateNBD.Text = dataPhim.CurrentRow.Cells[7].Value.ToString();
            dateNKT.Text = dataPhim.CurrentRow.Cells[8].Value.ToString();
            txtMTP.Text = dataPhim.CurrentRow.Cells[9].Value.ToString();
            txtHinh.Text = dataPhim.CurrentRow.Cells[10].Value.ToString();
        }

        private void btPXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMP.Text == "")
                    MessageBox.Show("Vui lòng chọn phim để xóa", "Thông báo");
                else
                {
                    if (a.cn.State == ConnectionState.Closed)
                        a.cn.Open();
                    string sql = "delete from Phim where MaPhim = @maphim";
                    cmd = new SqlCommand(sql, a.cn);
                    cmd.Parameters.AddWithValue("@maphim", txtMP.Text);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DataRowView r = (DataRowView)phim.Current;
                        r.Delete();
                        MessageBox.Show("Xóa thành công " + n + " phim", "Thông báo");
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




        // DANG PHIM


        private void btDPThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sql = "insert into DangPhim (MaDangPhim,TenDangPhim) VALUES (@madangphim,@tendangphim) ";
                cmd = new SqlCommand(sql, a.cn);
                cmd.Parameters.AddWithValue("@madangphim", txtDPMDP.Text);
                cmd.Parameters.AddWithValue("@tendangphim", txtDPTDP.Text);

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataTable dt = (DataTable)dangphim.DataSource;
                    DataRow r = dt.NewRow();
                    r[0] = txtDPMDP.Text;
                    r[1] = txtDPTDP.Text;
                    dt.Rows.Add(r);
                    MessageBox.Show("Thêm thành công" + n + " dạng phim ", "Thông báo");
                    taoSourcecbDP("select * from DangPhim");
                    cbMDP.DataSource = mdp;
                    cbMDP.DisplayMember = "TenDangPhim";
                    cbMDP.ValueMember = "MaDangPhim";
                }
                else MessageBox.Show("Không thể chọn", "Thông báo");
                a.cn.Close();
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void btDPSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                if (txtDPMDP.Text == "")
                    MessageBox.Show("Xin vui lòng chọn dạng phim để chỉnh sửa", "Thông báo");
                else
                {
                    string sql = "update DangPhim Set TenDangPhim= @tendangphim where MaDangPhim = @madangphim";
                    cmd = new SqlCommand(sql, a.cn);

                    cmd.Parameters.AddWithValue("@madangphim", txtDPMDP.Text);
                    cmd.Parameters.AddWithValue("@tendangphim", txtDPTDP.Text);

                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DataRowView rv = (DataRowView)dangphim.Current;

                        rv[0] = txtDPMDP.Text;
                        rv[1] = txtDPTDP.Text;
                        dangphim.ResetCurrentItem();
                        MessageBox.Show("Update thành công" + n + "dạng phim ", "Thông báo");
                        taoSourcecbDP("select * from DangPhim");
                        cbMDP.DataSource = mdp;
                        cbMDP.DisplayMember = "TenDangPhim";
                        cbMDP.ValueMember = "MaDangPhim";
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

        private void btDPXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDPMDP.Text == "")
                    MessageBox.Show("Vui lòng chọn dạng phim để xóa", "Thông báo");
                else
                {
                    if (a.cn.State == ConnectionState.Closed)
                        a.cn.Open();
                    string sql = "delete from DangPhim where MaDangPhim = @madangphim";
                    cmd = new SqlCommand(sql, a.cn);
                    cmd.Parameters.AddWithValue("@madangphim", txtDPMDP.Text);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DataRowView r = (DataRowView)dangphim.Current;
                        r.Delete();
                        MessageBox.Show("Xóa thành công " + n + " dạng phim", "Thông báo");
                        taoSourcecbDP("select * from DangPhim");
                        cbMDP.DataSource = mdp;
                        cbMDP.DisplayMember = "TenDangPhim";
                        cbMDP.ValueMember = "MaDangPhim";
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


        //LOAI PHIM


        private void btLPThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sql = "insert into LoaiPhim (MaLoaiPhim,TenLoaiPhim) VALUES (@maloaiphim,@tenloaiphim) ";
                cmd = new SqlCommand(sql, a.cn);
                cmd.Parameters.AddWithValue("@maloaiphim", txtLPMLP.Text);
                cmd.Parameters.AddWithValue("@tenloaiphim", txtLPTLP.Text);

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataTable dt = (DataTable)loaiphim.DataSource;
                    DataRow r = dt.NewRow();
                    r[0] = txtLPMLP.Text;
                    r[1] = txtLPTLP.Text;
                    dt.Rows.Add(r);
                    MessageBox.Show("Thêm thành công" + n + " loại phim ", "Thông báo");
                    taoSourcecbMLP("select * from LoaiPhim");
                    cbMLP.DataSource = mlp;
                    cbMLP.DisplayMember = "TenLoaiPhim";
                    cbMLP.ValueMember = "MaLoaiPhim";
                }
                else MessageBox.Show("Không thể chọn", "Thông báo");
                a.cn.Close();
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void btLPSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                if (txtLPMLP.Text == "")
                    MessageBox.Show("Xin vui lòng chọn loại phim để chỉnh sửa", "Thông báo");
                else
                {
                    string sql = "update LoaiPhim Set    MaLoaiPhim = @maloaiphim , TenLoaiPhim= @tenloaiphim";
                    cmd = new SqlCommand(sql, a.cn);

                    cmd.Parameters.AddWithValue("@maloaiphim", txtLPMLP.Text);
                    cmd.Parameters.AddWithValue("@tenloaiphim", txtLPTLP.Text);

                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DataRowView rv = (DataRowView)loaiphim.Current;

                        rv[1] = txtLPMLP.Text;
                        rv[2] = txtLPTLP.Text;
                        loaiphim.ResetCurrentItem();
                        MessageBox.Show("Update thành công" + n + "loại phim ", "Thông báo");
                        taoSourcecbMLP("select * from LoaiPhim");
                        cbMLP.DataSource = mlp;
                        cbMLP.DisplayMember = "TenLoaiPhim";
                        cbMLP.ValueMember = "MaLoaiPhim";
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

        private void btLPXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLPMLP.Text == "")
                    MessageBox.Show("Vui lòng chọn loại phim để xóa", "Thông báo");
                else
                {
                    if (a.cn.State == ConnectionState.Closed)
                        a.cn.Open();
                    string sql = "delete from LoaiPhim where MaDangPhim = @madangphim";
                    cmd = new SqlCommand(sql, a.cn);
                    cmd.Parameters.AddWithValue("@maloaiphim", txtLPMLP.Text);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DataRowView r = (DataRowView)loaiphim.Current;
                        r.Delete();
                        MessageBox.Show("Xóa thành công " + n + " loại phim", "Thông báo");
                        taoSourcecbMLP("select * from LoaiPhim");
                        cbMLP.DataSource = mlp;
                        cbMLP.DisplayMember = "TenLoaiPhim";
                        cbMLP.ValueMember = "MaLoaiPhim";
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


        //QUỐC GIA


        private void btQGThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sql = "insert into QuocGia (MaQuocGia,TenQuocGia) VALUES (@maquocgia,@tenquocgia) ";
                cmd = new SqlCommand(sql, a.cn);
                cmd.Parameters.AddWithValue("@maquocgia", txtQGMQG.Text);
                cmd.Parameters.AddWithValue("@tenquocgia", txtQGTQG.Text);

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataTable dt = (DataTable)quocgia.DataSource;
                    DataRow r = dt.NewRow();
                    r[0] = txtQGMQG.Text;
                    r[1] = txtQGTQG.Text;
                    dt.Rows.Add(r);
                    MessageBox.Show("Thêm thành công" + n + " quốc gia ", "Thông báo");
                    taoSourcecbQG("select * from QuocGia");
                    cbMQG1.DataSource = mqg;
                    cbMQG1.DisplayMember = "TenQuocGia";
                    cbMQG1.ValueMember = "MaQuocGia";
                }
                else MessageBox.Show("Không thể chọn", "Thông báo");
                a.cn.Close();
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void btQGSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                if (txtQGMQG.Text == "")
                    MessageBox.Show("Xin vui lòng chọn quốc gia để chỉnh sửa", "Thông báo");
                else
                {
                    string sql = "update QuocGia Set    MaQuocGia = @maquocgia , TenQuocGia= @tenquocgia";
                    cmd = new SqlCommand(sql, a.cn);

                    cmd.Parameters.AddWithValue("@maquocgia", txtQGMQG.Text);
                    cmd.Parameters.AddWithValue("@tenquocgia", txtQGTQG.Text);

                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DataRowView rv = (DataRowView)quocgia.Current;

                        rv[0] = txtQGMQG.Text;
                        rv[1] = txtQGTQG.Text;
                        quocgia.ResetCurrentItem();
                        MessageBox.Show("Update thành công" + n + "quốc gia ", "Thông báo");
                        taoSourcecbQG("select * from QuocGia");
                        cbMQG1.DataSource = mqg;
                        cbMQG1.DisplayMember = "TenQuocGia";
                        cbMQG1.ValueMember = "MaQuocGia";
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

        private void btQGXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQGMQG.Text == "")
                    MessageBox.Show("Vui lòng chọn quốc gia để xóa", "Thông báo");
                else
                {
                    if (a.cn.State == ConnectionState.Closed)
                        a.cn.Open();
                    string sql = "delete from QuocGia where MaQuocGia = @maquocgia";
                    cmd = new SqlCommand(sql, a.cn);
                    cmd.Parameters.AddWithValue("@maquocgia", txtQGMQG.Text);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DataRowView r = (DataRowView)quocgia.Current;
                        r.Delete();
                        MessageBox.Show("Xóa thành công " + n + " quốc gia", "Thông báo");
                        taoSourcecbQG("select * from QuocGia");
                        cbMQG1.DataSource = mqg;
                        cbMQG1.DisplayMember = "TenQuocGia";
                        cbMQG1.ValueMember = "MaQuocGia";
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

        private void dgvDP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDPMDP.Text = dgvDP.CurrentRow.Cells[0].Value.ToString();
            txtDPTDP.Text = dgvDP.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvQG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtQGMQG.Text = dgvQG.CurrentRow.Cells[0].Value.ToString();
            txtQGTQG.Text = dgvQG.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvLP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLPMLP.Text = dgvLP.CurrentRow.Cells[0].Value.ToString();
            txtLPTLP.Text = dgvLP.CurrentRow.Cells[1].Value.ToString();
        }

    }
}

