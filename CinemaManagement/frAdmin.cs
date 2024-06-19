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
using System.Net.Mail;
using System.Net;

namespace CinemaManagement
{
    public partial class frAdmin : Form
    {
        int i, idnv;
        string cangayxn;
        BindingSource nv, tk, cb, sCode, sName, cbnv, cblnv, row1, mails;
        SqlCommand cmd;
        MailMessage mail;
        LopDungChung a = new LopDungChung();
        public frAdmin()
        {
            InitializeComponent();
        }

        private void frAdmin_Load(object sender, EventArgs e)
        {
            a.TaoKetNoi();
            string sql = "select N.MaNV,N.MaLich,N.IDChucVu,N.HoNV,N.TenNV,N.SDT,N.DiaChi,N.Email,C.ChucVu from NhanVien N, ChucVu C where N.IDChucVu = C.IDChucVu";
            string sql2 = "SELECT * FROM TaiKhoan";
            taoSourceNV(sql);
            taoSourceTK(sql2);
            taoSourceCB("select * from ChucVu");
            taoSourceCBNV("select MaNV,IDChucVu from NhanVien");
            taoSourceCBLNV("select L.MaLich, L.CaNgay, L.MaNV,N.HoNV+' '+N.TenNV as HoTen from Lich L, NhanVien N where L.MaNV = N.MaNV");
            taoSourceCBMail("select N.MaLich,N.MaNV, N.Email, N.HoNV+' '+N.TenNV as HoTen from NhanVien N, Lich L where L.MaLich = N.MaLich");
            dgv_NV.DataSource = nv;
            dgv_TK.DataSource = tk;
            cbTabNVChucVuMoi.DataSource = cb;
            cbTabNVChucVuMoi.ValueMember = "ChucVu";
            comboBox1.DataSource = cbnv;
            comboBox1.DisplayMember = "MaNV";
            comboBox1.ValueMember = "IDChucVu";
            cbChonNV.DataSource = cblnv;
            cbChonNV.DisplayMember = "HoTen";
            cbChonNV.ValueMember = "MaLich";
            cbMail.DataSource = mails;
            cbMail.DisplayMember = "HoTen";
            cbMail.ValueMember = "Email";
        }

        private void taoSourceNV(string sql)
        {
            nv = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            nv.DataSource = dt;
        }

        private void taoSourceTK(string sql)
        {
            tk = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tk.DataSource = dt;
        }

        private void taoSourceCB(string sql)
        {
            cb = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb.DataSource = dt;
        }

        private void taoSourceCBNV(string sql)
        {
            cbnv = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbnv.DataSource = dt;
        }

        private void taoSourceSearchC(string sql)
        {
            sCode = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sCode.DataSource = dt;
        }

        private void taoSourceSearchN(string sql)
        {
            sName = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sName.DataSource = dt;
        }

        private void taoSourceCBLNV(string sql)
        {
            cblnv = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cblnv.DataSource = dt;
        }

        private void taoSourceCBLR(string sql)
        {
            row1 = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            row1.DataSource = dt;
        }

        private void taoSourceCBMail(string sql)
        {
            mails = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mails.DataSource = dt;
        }

        private void frAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void dgv_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgv_NV.CurrentRow.Cells[0].Value.ToString();
            txtHoNV.Text = dgv_NV.CurrentRow.Cells[3].Value.ToString();
            txtTenNV.Text = dgv_NV.CurrentRow.Cells[4].Value.ToString();
            txtSDT.Text = dgv_NV.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = dgv_NV.CurrentRow.Cells[7].Value.ToString();
            txtDiaChi.Text = dgv_NV.CurrentRow.Cells[6].Value.ToString();
            txtTabNVChucVuHT.Text = dgv_NV.CurrentRow.Cells[8].Value.ToString();
        }

        private void btTabNVTimKiem_Click(object sender, EventArgs e)
        {
            if (rdNVMaNV.Checked == true)
            {
                string cm = "select N.MaNV,N.MaLich,N.IDChucVu,N.HoNV,N.TenNV,N.SDT,N.DiaChi,N.Email,C.ChucVu from NhanVien N, ChucVu C where N.IDChucVu = C.IDChucVu and MaNV like '%" + txtTabNVTimKiem.Text + "%'";
                taoSourceSearchC(cm);
                dgv_NV.DataSource = sCode;
            }
            else
            {
                string cm = "select N.MaNV,N.MaLich,N.IDChucVu,N.HoNV,N.TenNV,N.SDT,N.DiaChi,N.Email,C.ChucVu from NhanVien N, ChucVu C where N.IDChucVu = C.IDChucVu and TenNV like '%" + txtTabNVTimKiem.Text + "%'";
                taoSourceSearchN(cm);
                dgv_NV.DataSource = sName;
            }
        }

        private void btTabNVThem_Click(object sender, EventArgs e)
        {
            try
            {
                //them thang vo co so du lieu
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sql = "insert into NhanVien(MaNV,IDChucVu,HoNV,TenNV,SDT,DiaChi,Email) values (@manv,@id,@ho,@ten,@sdt,@diachi,@email)";
                cmd = new SqlCommand(sql, a.cn);
                cmd.Parameters.AddWithValue("@manv", txtMaNV.Text);
                cmd.Parameters.AddWithValue("id", i + 1);
                cmd.Parameters.AddWithValue("@ho", txtHoNV.Text);
                cmd.Parameters.AddWithValue("@ten", txtTenNV.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                int n = cmd.ExecuteNonQuery(); // thuc hien va tra ve so dong them vao
                // tu day tro xuong, neu no co them vao thi se tao 1 dong tren datagridview
                if (n > 0)
                {
                    DataTable t1 = (DataTable)nv.DataSource; // tạo một table lấy csdl từ cái binding source
                    DataRow r = t1.NewRow(); //trong bảng t1 tạo 1 dòng rỗng
                    r[0] = txtMaNV.Text; //từ đây tới r[7] là tạo cột và giá trị của nó sẽ bằng cái gì
                    r[2] = i + 1;
                    r[3] = txtHoNV.Text;
                    r[4] = txtTenNV.Text;
                    r[5] = txtSDT.Text;
                    r[6] = txtDiaChi.Text;
                    r[7] = txtEmail.Text;
                    t1.Rows.Add(r);//hàm thêm dòng vào bảng
                    MessageBox.Show("Thêm thành công " + n + " dòng vào csdl", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    taoSourceCBNV("select MaNV,IDChucVu from NhanVien");
                    comboBox1.DataSource = cbnv;
                    comboBox1.DisplayMember = "MaNV";
                    comboBox1.ValueMember = "IDChucVu";
                }
                else MessageBox.Show("Không thêm được", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception sq)
            {
                MessageBox.Show(sq.Message);
            }
            a.cn.Close();
        }

        private void checkTabNVChoPhep_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTabNVChoPhep.Checked == true)
            {
                btTabNVThem.Enabled = true;
                btTabNVSua.Enabled = true;
                btTabNVXoa.Enabled = true;
            }
            else
            {
                btTabNVThem.Enabled = false;
                btTabNVSua.Enabled = false;
                btTabNVXoa.Enabled = false;
            }
        }

        private void cbTabNVChucVuMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = cbTabNVChucVuMoi.SelectedIndex;
        }

        private void btTabNVSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
                MessageBox.Show("Vui lòng chọn nhân viên muốn sửa");
            else
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sql = "update NhanVien set IDChucVu = @id, HoNV = @honv, TenNV = @ten, SDT = @sdt, DiaChi = @diachi, @email = Email where MaNV = @manv";
                cmd = new SqlCommand(sql, a.cn);
                cmd.Parameters.AddWithValue("@manv", txtMaNV.Text);
                cmd.Parameters.AddWithValue("id", i + 1);
                cmd.Parameters.AddWithValue("@honv", txtHoNV.Text);
                cmd.Parameters.AddWithValue("@ten", txtTenNV.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataRowView r = (DataRowView)nv.Current; //tạo một dòng view ( là 1 dòng trong dataview [dataset > dataview > datarowview ]
                    r[0] = txtMaNV.Text; //từ đây tới r[7] là tạo cột và giá trị của nó sẽ bằng cái gì
                    r[2] = i + 1;
                    r[3] = txtHoNV.Text;
                    r[4] = txtTenNV.Text;
                    r[5] = txtSDT.Text;
                    r[6] = txtDiaChi.Text;
                    r[7] = txtEmail.Text;
                    nv.ResetCurrentItem(); //hàm yêu cầu binding source refresh lại item đó
                    MessageBox.Show("Update thành công", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    taoSourceCBNV("select MaNV,IDChucVu from NhanVien");
                    comboBox1.DataSource = cbnv;
                    comboBox1.DisplayMember = "MaNV";
                    comboBox1.ValueMember = "IDChucVu";
                }
                else MessageBox.Show("Update thất bại", "Fail",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                a.cn.Close();
            }
        }

        private void btTabNVXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa");
            else
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sql = "delete from NhanVien where MaNV = @manv";
                cmd = new SqlCommand(sql, a.cn);
                cmd.Parameters.AddWithValue("@manv", txtMaNV.Text);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataRowView r = (DataRowView)nv.Current;
                    r.Delete();
                    MessageBox.Show("Xóa thành công " + n + " dòng", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    taoSourceCBNV("select MaNV,IDChucVu from NhanVien");
                    comboBox1.DataSource = cbnv;
                    comboBox1.DisplayMember = "MaNV";
                    comboBox1.ValueMember = "IDChucVu";
                }
                else
                    MessageBox.Show("Xóa thất bại", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                a.cn.Close();
            }
        }
        
        //Tab Tài khoản

        private void dgv_TK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMNV.Text = dgv_TK.CurrentRow.Cells[0].Value.ToString();
            txtTenTK.Text = dgv_TK.CurrentRow.Cells[1].Value.ToString();
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

        private void btTabTKThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(a.cn.State==ConnectionState.Closed)
                    a.cn.Open();
                string sql = "insert into TaiKhoan(MaNV,TenTK,pass,IDChucVu) values (@manv,@tentk,@mk,@idchucvu)";
                cmd = new SqlCommand(sql, a.cn);
                string pas = MaHoaPass(txtMK.Text);
                string d = comboBox1.Text;//lấy phần text hiển thị trên combobox khi đã click chọn nhân viên
                cmd.Parameters.AddWithValue("@manv", d);
                cmd.Parameters.AddWithValue("@tentk", txtTenTK.Text);
                cmd.Parameters.AddWithValue("@mk", pas);
                cmd.Parameters.AddWithValue("@idchucvu", comboBox1.SelectedValue);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataTable dt = (DataTable)tk.DataSource;
                    DataRow r = dt.NewRow();
                    r[0] = d;
                    r[1] = txtTenTK.Text;
                    r[2] = pas;
                    r[3] = comboBox1.SelectedValue;
                    dt.Rows.Add(r);
                    MessageBox.Show("Thêm thành công " + n + " tài khoản", "Thông báo");
                }
                else MessageBox.Show("Không thể thêm", "Thông báo");
                a.cn.Close();
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idnv = comboBox1.SelectedIndex;
        }

        private void btTabTKSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                if (txtMNV.Text == "")
                    MessageBox.Show("Xin vui lòng chọn tài khoản để chỉnh sửa", "Thông báo");
                else
                {
                    string sql = "update TaiKhoan Set TenTK = @tentk, pass = @pas, IDChucVu = @idchucvu where MaNV = @manv";
                    cmd = new SqlCommand(sql, a.cn);
                    string newpass = MaHoaPass(txtMK.Text);
                    cmd.Parameters.AddWithValue("@manv", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@tentk", txtTenTK.Text);
                    cmd.Parameters.AddWithValue("@pas", newpass);
                    cmd.Parameters.AddWithValue("@idchucvu", comboBox1.SelectedValue);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DataRowView rv = (DataRowView)tk.Current;
                        rv[1] = txtTenTK.Text;
                        rv[2] = newpass;
                        rv[3] = comboBox1.SelectedValue;
                        tk.ResetCurrentItem();
                        MessageBox.Show("Update thành công " + n + " tài khoản", "Thông báo");
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

        private void btTabTKXoa_Click(object sender, EventArgs e)
        {
            if (txtMNV.Text == "")
                MessageBox.Show("Vui lòng chọn tài khoản để xóa", "Thông báo");
            else
            {
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sql = "delete from TaiKhoan where MaNV = @manv";
                cmd = new SqlCommand(sql, a.cn);
                cmd.Parameters.AddWithValue("@manv", txtMNV.Text);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    DataRowView r = (DataRowView)tk.Current;
                    r.Delete();
                    MessageBox.Show("Xóa thành công " + n + " tài khoản", "Thông báo");
                }
                else MessageBox.Show("Xóa không thành công", "Thông báo");
            }
            a.cn.Close();
        }

        private void cbMail_SelectedIndexChanged(object sender, EventArgs e)
        {
 

        }

        private void checkNgay(string s)
        {
            if (s == "12")
                checkT2Sang.Checked = true;
            else if (s == "22")
                checkT2Chieu.Checked = true;
            else if (s == "32")
                checkT2Toi.Checked = true;
            else if (s == "13")
                checkT3Sang.Checked = true;
            else if (s == "23")
                checkT3Chieu.Checked = true;
            else if (s == "33")
                checkT3Toi.Checked = true;
            else if (s == "14")
                checkT4Sang.Checked = true;
            else if (s == "24")
                checkT4Chieu.Checked = true;
            else if (s == "34")
                checkT4Toi.Checked = true;
            else if (s == "15")
                checkT5Sang.Checked = true;
            else if (s == "25")
                checkT5Chieu.Checked = true;
            else if (s == "35")
                checkT5Toi.Checked = true;
            else if (s == "16")
                checkT6Sang.Checked = true;
            else if (s == "26")
                checkT6Chieu.Checked = true;
            else if (s == "36")
                checkT6Toi.Checked = true;
            else if (s == "17")
                checkT7Sang.Checked = true;
            else if (s == "27")
                checkT7Chieu.Checked = true;
            else if (s == "37")
                checkT7Toi.Checked = true;
            else if (s == "18")
                checkCNSang.Checked = true;
            else if (s == "28")
                checkCNChieu.Checked = true;
            else if (s == "38")
                checkCNToi.Checked = true;
        }

        private void setdisable()
        {
            checkT2Sang.Checked = false;
            checkT2Chieu.Checked = false;
            checkT2Toi.Checked = false;
            checkT3Sang.Checked = false;
            checkT3Chieu.Checked = false;
            checkT3Toi.Checked = false;
            checkT4Sang.Checked = false;
            checkT4Chieu.Checked = false;
            checkT4Toi.Checked = false;
            checkT5Sang.Checked = false;
            checkT5Chieu.Checked = false;
            checkT5Toi.Checked = false;
            checkT6Sang.Checked = false;
            checkT6Chieu.Checked = false;
            checkT6Toi.Checked = false;
            checkT7Sang.Checked = false;
            checkT7Chieu.Checked = false;
            checkT7Toi.Checked = false;
            checkCNSang.Checked = false;
            checkCNChieu.Checked = false;
            checkCNToi.Checked = false;
        }

        private void loadLich()
        {
            try
            {
                setdisable();
                taoSourceCBLR("select L.MaLich, L.CaNgay, L.MaNV,N.HoNV+' '+N.TenNV as HoTen from Lich L, NhanVien N where L.MaNV = N.MaNV and L.MaLich = " + cbChonNV.SelectedValue);
                DataTable dt = (DataTable)row1.DataSource;
                DataRow r = dt.Rows[0];
                string l = r[1].ToString();
                string[] lich;
                lich = l.Split(',');
                for (int c = 0; c < lich.Length; c ++)
                {
                    checkNgay(lich[c]);
                }
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void cbChonNV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadLich();
        }

        private void nhapCaNgay(int cngay)
        {
            cangayxn = cangayxn + cngay + ",";
        }

        private void LuuNgay()
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

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd2;
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                DataTable dt = (DataTable)row1.DataSource;
                DataRow r = dt.Rows[0];
                LuuNgay();
                ///////////////////////////////Luu Lich/////////////////////////////////////////////////////////
                string sql = "update Lich set CaNgay = @cangay, NgayQlCheck = @ngayql where MaNV = @manv";
                cmd = new SqlCommand(sql, a.cn);
                cmd.Parameters.AddWithValue("@cangay", cangayxn);
                cmd.Parameters.AddWithValue("@ngayql", DateTime.Today.ToString());
                cmd.Parameters.AddWithValue("@manv", r[2].ToString());
                cmd.ExecuteNonQuery();
                //Cap nhat MaLich vao bang NhanVien
                string sql2 = "update NhanVien set MaLich = @malich where MaNV = @manv";
                cmd2 = new SqlCommand(sql2, a.cn);
                cmd2.Parameters.AddWithValue("@malich", r[0].ToString());
                cmd2.Parameters.AddWithValue("@manv", r[2].ToString());
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Đã xác nhận lịch làm cho NV " + cbChonNV.SelectedText);
                taoSourceCBMail("select N.MaLich,N.MaNV, N.Email, N.HoNV+' '+N.TenNV as HoTen from NhanVien N, Lich L where L.MaLich = N.MaLich");
                cbMail.DataSource = mails;
                cbMail.DisplayMember = "HoTen";
                cbMail.ValueMember = "Email";
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
            finally
            {
                a.cn.Close();
            }
        }

        private void guiMail()
        {
            txtNoiDung.Text = "Chú thích ý nghĩa con số: [ca làm][thứ làm], ví dụ : 13 là ca sáng thứ ba.\n Lịch: " + cangayxn;
            mail = new MailMessage(txtMailNG.Text,cbMail.SelectedValue.ToString(),txtTieuDe.Text,txtNoiDung.Text);
            SmtpClient smtp = new SmtpClient()//cau hinh smtp
            {
                Host = "smtp.gmail.com", //may chu mail
                Port = 587,
                Credentials = new NetworkCredential(txtMailNG.Text, txtPass.Text),
                EnableSsl = true
            };
            smtp.Send(mail);
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                guiMail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Gửi thành công tới nhân viên " + cbChonNV.SelectedText.ToString());
        }
    }
}
