namespace CinemaManagement
{
    partial class frMain2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbPosition = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTabNVChucVuHT = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEmployeeCode = new System.Windows.Forms.Label();
            this.lbFName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btPhim = new System.Windows.Forms.Button();
            this.btVe = new System.Windows.Forms.Button();
            this.btSKKM = new System.Windows.Forms.Button();
            this.btPC = new System.Windows.Forms.Button();
            this.btDKL = new System.Windows.Forms.Button();
            this.btThucPham = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1005, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSizeToolStripMenuItem,
            this.themeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fontSizeToolStripMenuItem
            // 
            this.fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.fontSizeToolStripMenuItem.Text = "Font Size";
            this.fontSizeToolStripMenuItem.Click += new System.EventHandler(this.fontSizeToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.whiteToolStripMenuItem,
            this.defaultToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Location = new System.Drawing.Point(26, 191);
            this.lbPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(95, 20);
            this.lbPosition.TabIndex = 18;
            this.lbPosition.Text = "Chức Vụ HT";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(156, 383);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(336, 26);
            this.txtDiaChi.TabIndex = 23;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(159, 251);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(336, 26);
            this.txtEmail.TabIndex = 19;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(156, 53);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(187, 26);
            this.txtMaNV.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(156, 317);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(336, 26);
            this.txtSDT.TabIndex = 22;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(154, 119);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(336, 26);
            this.txtTenNV.TabIndex = 21;
            // 
            // txtTabNVChucVuHT
            // 
            this.txtTabNVChucVuHT.Location = new System.Drawing.Point(159, 185);
            this.txtTabNVChucVuHT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTabNVChucVuHT.Name = "txtTabNVChucVuHT";
            this.txtTabNVChucVuHT.ReadOnly = true;
            this.txtTabNVChucVuHT.Size = new System.Drawing.Size(336, 26);
            this.txtTabNVChucVuHT.TabIndex = 20;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(66, 257);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(48, 20);
            this.lbEmail.TabIndex = 13;
            this.lbEmail.Text = "Email";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(61, 389);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(60, 20);
            this.lbDiaChi.TabIndex = 16;
            this.lbDiaChi.Text = "Địa Chỉ";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(61, 323);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(41, 20);
            this.lbPhone.TabIndex = 15;
            this.lbPhone.Text = "SĐT";
            // 
            // lbEmployeeCode
            // 
            this.lbEmployeeCode.AutoSize = true;
            this.lbEmployeeCode.Location = new System.Drawing.Point(61, 59);
            this.lbEmployeeCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmployeeCode.Name = "lbEmployeeCode";
            this.lbEmployeeCode.Size = new System.Drawing.Size(57, 20);
            this.lbEmployeeCode.TabIndex = 24;
            this.lbEmployeeCode.Text = "Mã NV";
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.Location = new System.Drawing.Point(59, 125);
            this.lbFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(62, 20);
            this.lbFName.TabIndex = 17;
            this.lbFName.Text = "Tên NV";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(542, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 109);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // btPhim
            // 
            this.btPhim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPhim.BackgroundImage")));
            this.btPhim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPhim.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btPhim.FlatAppearance.BorderSize = 210;
            this.btPhim.Location = new System.Drawing.Point(706, 168);
            this.btPhim.Name = "btPhim";
            this.btPhim.Size = new System.Drawing.Size(115, 109);
            this.btPhim.TabIndex = 25;
            this.btPhim.UseVisualStyleBackColor = true;
            this.btPhim.Click += new System.EventHandler(this.btPhim_Click);
            this.btPhim.MouseHover += new System.EventHandler(this.btPhim_MouseHover);
            // 
            // btVe
            // 
            this.btVe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btVe.BackgroundImage")));
            this.btVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVe.Location = new System.Drawing.Point(542, 300);
            this.btVe.Name = "btVe";
            this.btVe.Size = new System.Drawing.Size(115, 109);
            this.btVe.TabIndex = 25;
            this.btVe.UseVisualStyleBackColor = true;
            this.btVe.Click += new System.EventHandler(this.btVe_Click);
            this.btVe.MouseHover += new System.EventHandler(this.btVe_MouseHover);
            // 
            // btSKKM
            // 
            this.btSKKM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSKKM.BackgroundImage")));
            this.btSKKM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSKKM.Location = new System.Drawing.Point(701, 300);
            this.btSKKM.Name = "btSKKM";
            this.btSKKM.Size = new System.Drawing.Size(115, 109);
            this.btSKKM.TabIndex = 25;
            this.btSKKM.UseVisualStyleBackColor = true;
            this.btSKKM.Click += new System.EventHandler(this.btSKKM_Click);
            this.btSKKM.MouseHover += new System.EventHandler(this.btSKKM_MouseHover);
            // 
            // btPC
            // 
            this.btPC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPC.BackgroundImage")));
            this.btPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPC.Location = new System.Drawing.Point(865, 168);
            this.btPC.Name = "btPC";
            this.btPC.Size = new System.Drawing.Size(115, 109);
            this.btPC.TabIndex = 25;
            this.btPC.UseVisualStyleBackColor = true;
            this.btPC.Click += new System.EventHandler(this.btPC_Click);
            this.btPC.MouseHover += new System.EventHandler(this.btDong_MouseHover);
            // 
            // btDKL
            // 
            this.btDKL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDKL.Enabled = false;
            this.btDKL.Location = new System.Drawing.Point(542, 53);
            this.btDKL.Name = "btDKL";
            this.btDKL.Size = new System.Drawing.Size(438, 92);
            this.btDKL.TabIndex = 26;
            this.btDKL.Text = "Đăng Ký Lịch Làm";
            this.btDKL.UseVisualStyleBackColor = true;
            this.btDKL.Click += new System.EventHandler(this.btDKL_Click);
            // 
            // btThucPham
            // 
            this.btThucPham.AutoSize = true;
            this.btThucPham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThucPham.BackgroundImage")));
            this.btThucPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThucPham.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThucPham.ForeColor = System.Drawing.Color.Red;
            this.btThucPham.Location = new System.Drawing.Point(865, 300);
            this.btThucPham.Name = "btThucPham";
            this.btThucPham.Size = new System.Drawing.Size(115, 109);
            this.btThucPham.TabIndex = 25;
            this.btThucPham.UseVisualStyleBackColor = true;
            this.btThucPham.Click += new System.EventHandler(this.btThucPham_Click);
            this.btThucPham.MouseHover += new System.EventHandler(this.btExit_MouseHover);
            // 
            // frMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.btDKL);
            this.Controls.Add(this.btPhim);
            this.Controls.Add(this.btPC);
            this.Controls.Add(this.btThucPham);
            this.Controls.Add(this.btSKKM);
            this.Controls.Add(this.btVe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtTabNVChucVuHT);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbEmployeeCode);
            this.Controls.Add(this.lbFName);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frMain2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý rạp phim @ by Lương Ngọc Quảng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frMain2_FormClosed);
            this.Load += new System.EventHandler(this.frMain2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtTabNVChucVuHT;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEmployeeCode;
        private System.Windows.Forms.Label lbFName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btPhim;
        private System.Windows.Forms.Button btVe;
        private System.Windows.Forms.Button btSKKM;
        private System.Windows.Forms.Button btPC;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.Button btDKL;
        private System.Windows.Forms.Button btThucPham;
    }
}