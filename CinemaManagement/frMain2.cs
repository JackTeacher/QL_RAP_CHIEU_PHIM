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
    public partial class frMain2 : Form
    {
        BindingSource s;
        FontDialog font = new FontDialog();
        LopDungChung a = new LopDungChung();
        public frMain2()
        {
            InitializeComponent();
        }


        private void lod()
        {
            txtMaNV.Text = TruyenData.MaNV;
            txtTenNV.Text = TruyenData.Ten;
            txtDiaChi.Text = TruyenData.DiaChi;
            txtTabNVChucVuHT.Text = TruyenData.ChucVu;
            txtEmail.Text = TruyenData.Email;
            txtSDT.Text = TruyenData.SDT;
        }

        private void kiemtraquyen()
        {
            if (TruyenData.id == 1)
            {
                btDKL.Visible = false;
                button1.Enabled = true;
                btPhim.Enabled = true;
                btPC.Enabled = true;
                btSKKM.Enabled = true;
                btVe.Enabled = true;
            }
            else if (TruyenData.id == 2)
            {
                button1.Enabled = false;
                btPhim.Enabled = false;
                btPC.Enabled = false;
                btThucPham.Enabled = false;
                btSKKM.Enabled = true;
                btVe.Enabled = true;
            }
            else if (TruyenData.id == 3)
            {
                button1.Enabled = false;
                btPhim.Enabled = false;
                btPC.Enabled = false;
                btSKKM.Enabled = false;
                btVe.Enabled = false;
                btThucPham.Enabled = true;
            }
            else if (TruyenData.id == 4)
            {
                button1.Enabled = false;
                btPhim.Enabled = false;
                btPC.Enabled = true;
                btSKKM.Enabled = false;
                btVe.Enabled = false;
                btThucPham.Enabled = false;
            }
            else if (TruyenData.id == 5)
            {
                button1.Enabled = false;
                btPhim.Enabled = true;
                btPC.Enabled = false;
                btSKKM.Enabled = false;
                btVe.Enabled = false;
                btThucPham.Enabled = false;
            }
        }

        private void frMain2_Load(object sender, EventArgs e)
        {
            if (TruyenData.ktdong == 1)
            {
                this.Enabled = true;
                lod();
                kiemtraquyen();
                if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
                {
                    btDKL.Enabled = true;
                }
                else btDKL.Enabled = false;
            }
        }

        private void frMain2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.IsBalloon = true;
            t.SetToolTip(button1, "Quản lý");
        }

        private void btPhim_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.IsBalloon = true;
            t.SetToolTip(btPhim, "Quản lý Phim");
        }

        private void btVe_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.IsBalloon = true;
            t.SetToolTip(btVe, "Quản lý Vé");
        }

        private void btSKKM_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.IsBalloon = true;
            t.SetToolTip(btSKKM, "Quản lý Sự Kiện Khuyến Mãi");
        }

        private void btExit_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.IsBalloon = true;
            t.SetToolTip(btPC, "Thoát");
        }

        private void btDong_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.IsBalloon = true;
            t.SetToolTip(btPC, "Quản lý Phòng Chiếu");
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frLogin login = new frLogin();
            login.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            font.ShowDialog();
            this.Font = font.Font;
            this.FontHeight = font.Font.Height;
        }

        private void SetColor(Color nen, Color chu)
        {
            this.txtTenNV.BackColor = nen;
            this.txtTenNV.ForeColor = chu;
            this.txtDiaChi.BackColor = nen;
            this.txtDiaChi.ForeColor = chu;
            this.txtEmail.BackColor = nen;
            this.txtEmail.ForeColor = chu;
            this.txtMaNV.BackColor = nen;
            this.txtMaNV.ForeColor = chu;
            this.txtTabNVChucVuHT.BackColor = nen;
            this.txtTabNVChucVuHT.ForeColor = chu;
            this.txtSDT.BackColor = nen;
            this.txtSDT.ForeColor = chu;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image i = Image.FromFile(Application.StartupPath + "\\a.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = i;
            this.ForeColor = Color.White;
            this.lbDiaChi.BackColor = this.lbEmail.BackColor = this.lbEmployeeCode.BackColor = this.lbFName.BackColor = this.lbPhone.BackColor = this.lbPosition.BackColor = Color.Transparent;
            SetColor(Color.Black, Color.WhiteSmoke);
            menuStrip1.BackColor = Color.Indigo;
            menuStrip1.ForeColor = Color.WhiteSmoke;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image i = Image.FromFile(Application.StartupPath + "\\b.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = i;
            this.ForeColor = Color.Black;
            this.lbDiaChi.BackColor = this.lbEmail.BackColor = this.lbEmployeeCode.BackColor = this.lbFName.BackColor = this.lbPhone.BackColor = this.lbPosition.BackColor = Color.Transparent;
            SetColor(Color.Gray, Color.Lavender);
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.ForeColor = Color.Black;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.ForeColor = Color.Black;
            this.lbDiaChi.BackColor = this.lbEmail.BackColor = this.lbEmployeeCode.BackColor = this.lbFName.BackColor = this.lbPhone.BackColor = this.lbPosition.BackColor = Color.Transparent;
            SetColor(Color.White, Color.Black);
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frAdmin admin = new frAdmin();
            admin.Show();
        }

        private void btPhim_Click(object sender, EventArgs e)
        {
            frPhim phim = new frPhim();
            phim.Show();
        }

        private void btPC_Click(object sender, EventArgs e)
        {
            FrSuatChieu sc = new FrSuatChieu();
            sc.Show();
        }

        private void btVe_Click(object sender, EventArgs e)
        {
            forminthongtin ve = new forminthongtin();
            ve.Show();
        }

        private void btQTP_Click(object sender, EventArgs e)
        {
            frOrther or = new frOrther();
            or.Show();
        }

        private void kiemtra()
        {
            try
            {
                a.TaoKetNoi();
                if (a.cn.State == ConnectionState.Closed)
                    a.cn.Open();
                string sql = "select L.MaNV, T.TenTK from Lich L, TaiKhoan T where L.MaNV = T.MaNV and T.TenTK = '" + TruyenData.tentk + "'";
                taoSource(sql);
                if (s.Count <= 0)
                {
                    frLich l = new frLich();
                    l.Show();
                }
                else
                {
                    MessageBox.Show("Bạn đã đăng ký lịch làm", "Thông báo");
                }

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

        private void taoSource(string sql)
        {
            s = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter(sql, a.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            s.DataSource = dt;
        }

        private void btDKL_Click(object sender, EventArgs e)
        {
            try
            {
                kiemtra();
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void btSKKM_Click(object sender, EventArgs e)
        {
            frSkkm skkm = new frSkkm();
            skkm.Show();
        }

        private void btThucPham_Click(object sender, EventArgs e)
        {
            frOrther or = new frOrther();
            or.Show();
        }
    }
}
