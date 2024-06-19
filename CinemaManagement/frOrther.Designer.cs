namespace CinemaManagement
{
    partial class frOrther
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbQTP = new System.Windows.Forms.TabPage();
            this.txtQTPSL = new System.Windows.Forms.TextBox();
            this.dgvQTP = new System.Windows.Forms.DataGridView();
            this.lbTitleQTP = new System.Windows.Forms.Label();
            this.cbQTPMaNV = new System.Windows.Forms.ComboBox();
            this.btQTPXoa = new System.Windows.Forms.Button();
            this.btQTPSua = new System.Windows.Forms.Button();
            this.btQTPThem = new System.Windows.Forms.Button();
            this.lbQTPSL = new System.Windows.Forms.Label();
            this.txtQTPDV = new System.Windows.Forms.TextBox();
            this.lbQTPDV = new System.Windows.Forms.Label();
            this.txtQTPLSP = new System.Windows.Forms.TextBox();
            this.lbQTPLSP = new System.Windows.Forms.Label();
            this.lbQTPTenNV = new System.Windows.Forms.Label();
            this.txtQTPTSP = new System.Windows.Forms.TextBox();
            this.lbQTPTSP = new System.Windows.Forms.Label();
            this.txtQTPMSP = new System.Windows.Forms.TextBox();
            this.lbQTPMSP = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbQTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQTP)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbQTP);
            this.tabControl1.Location = new System.Drawing.Point(4, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(714, 586);
            this.tabControl1.TabIndex = 0;
            // 
            // tbQTP
            // 
            this.tbQTP.Controls.Add(this.txtQTPSL);
            this.tbQTP.Controls.Add(this.dgvQTP);
            this.tbQTP.Controls.Add(this.lbTitleQTP);
            this.tbQTP.Controls.Add(this.cbQTPMaNV);
            this.tbQTP.Controls.Add(this.btQTPXoa);
            this.tbQTP.Controls.Add(this.btQTPSua);
            this.tbQTP.Controls.Add(this.btQTPThem);
            this.tbQTP.Controls.Add(this.lbQTPSL);
            this.tbQTP.Controls.Add(this.txtQTPDV);
            this.tbQTP.Controls.Add(this.lbQTPDV);
            this.tbQTP.Controls.Add(this.txtQTPLSP);
            this.tbQTP.Controls.Add(this.lbQTPLSP);
            this.tbQTP.Controls.Add(this.lbQTPTenNV);
            this.tbQTP.Controls.Add(this.txtQTPTSP);
            this.tbQTP.Controls.Add(this.lbQTPTSP);
            this.tbQTP.Controls.Add(this.txtQTPMSP);
            this.tbQTP.Controls.Add(this.lbQTPMSP);
            this.tbQTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbQTP.Location = new System.Drawing.Point(4, 22);
            this.tbQTP.Margin = new System.Windows.Forms.Padding(2);
            this.tbQTP.Name = "tbQTP";
            this.tbQTP.Padding = new System.Windows.Forms.Padding(2);
            this.tbQTP.Size = new System.Drawing.Size(706, 560);
            this.tbQTP.TabIndex = 1;
            this.tbQTP.Text = "Quầy TP";
            this.tbQTP.UseVisualStyleBackColor = true;
            // 
            // txtQTPSL
            // 
            this.txtQTPSL.Location = new System.Drawing.Point(488, 150);
            this.txtQTPSL.Margin = new System.Windows.Forms.Padding(2);
            this.txtQTPSL.Name = "txtQTPSL";
            this.txtQTPSL.Size = new System.Drawing.Size(92, 28);
            this.txtQTPSL.TabIndex = 50;
            // 
            // dgvQTP
            // 
            this.dgvQTP.AllowUserToAddRows = false;
            this.dgvQTP.AllowUserToDeleteRows = false;
            this.dgvQTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQTP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvQTP.Location = new System.Drawing.Point(2, 257);
            this.dgvQTP.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQTP.Name = "dgvQTP";
            this.dgvQTP.RowTemplate.Height = 24;
            this.dgvQTP.Size = new System.Drawing.Size(702, 301);
            this.dgvQTP.TabIndex = 49;
            this.dgvQTP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQTP_CellClick);
            // 
            // lbTitleQTP
            // 
            this.lbTitleQTP.Location = new System.Drawing.Point(201, 18);
            this.lbTitleQTP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitleQTP.Name = "lbTitleQTP";
            this.lbTitleQTP.Size = new System.Drawing.Size(330, 39);
            this.lbTitleQTP.TabIndex = 48;
            this.lbTitleQTP.Text = "Quầy thực phẩm";
            this.lbTitleQTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbQTPMaNV
            // 
            this.cbQTPMaNV.FormattingEnabled = true;
            this.cbQTPMaNV.Location = new System.Drawing.Point(166, 145);
            this.cbQTPMaNV.Name = "cbQTPMaNV";
            this.cbQTPMaNV.Size = new System.Drawing.Size(192, 30);
            this.cbQTPMaNV.TabIndex = 46;
            // 
            // btQTPXoa
            // 
            this.btQTPXoa.Location = new System.Drawing.Point(471, 194);
            this.btQTPXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btQTPXoa.Name = "btQTPXoa";
            this.btQTPXoa.Size = new System.Drawing.Size(82, 46);
            this.btQTPXoa.TabIndex = 45;
            this.btQTPXoa.Text = "Xóa";
            this.btQTPXoa.UseVisualStyleBackColor = true;
            this.btQTPXoa.Click += new System.EventHandler(this.btQTPXoa_Click);
            // 
            // btQTPSua
            // 
            this.btQTPSua.Location = new System.Drawing.Point(307, 194);
            this.btQTPSua.Margin = new System.Windows.Forms.Padding(2);
            this.btQTPSua.Name = "btQTPSua";
            this.btQTPSua.Size = new System.Drawing.Size(82, 46);
            this.btQTPSua.TabIndex = 43;
            this.btQTPSua.Text = "Sửa";
            this.btQTPSua.UseVisualStyleBackColor = true;
            this.btQTPSua.Click += new System.EventHandler(this.btQTPSua_Click);
            // 
            // btQTPThem
            // 
            this.btQTPThem.Location = new System.Drawing.Point(143, 194);
            this.btQTPThem.Margin = new System.Windows.Forms.Padding(2);
            this.btQTPThem.Name = "btQTPThem";
            this.btQTPThem.Size = new System.Drawing.Size(82, 46);
            this.btQTPThem.TabIndex = 42;
            this.btQTPThem.Text = "Thêm";
            this.btQTPThem.UseVisualStyleBackColor = true;
            this.btQTPThem.Click += new System.EventHandler(this.btQTPThem_Click);
            // 
            // lbQTPSL
            // 
            this.lbQTPSL.Location = new System.Drawing.Point(405, 148);
            this.lbQTPSL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQTPSL.Name = "lbQTPSL";
            this.lbQTPSL.Size = new System.Drawing.Size(92, 24);
            this.lbQTPSL.TabIndex = 41;
            this.lbQTPSL.Text = "Số lượng";
            // 
            // txtQTPDV
            // 
            this.txtQTPDV.Location = new System.Drawing.Point(488, 109);
            this.txtQTPDV.Margin = new System.Windows.Forms.Padding(2);
            this.txtQTPDV.Name = "txtQTPDV";
            this.txtQTPDV.Size = new System.Drawing.Size(94, 28);
            this.txtQTPDV.TabIndex = 40;
            // 
            // lbQTPDV
            // 
            this.lbQTPDV.Location = new System.Drawing.Point(405, 111);
            this.lbQTPDV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQTPDV.Name = "lbQTPDV";
            this.lbQTPDV.Size = new System.Drawing.Size(68, 24);
            this.lbQTPDV.TabIndex = 39;
            this.lbQTPDV.Text = "Đơn vị";
            // 
            // txtQTPLSP
            // 
            this.txtQTPLSP.Location = new System.Drawing.Point(488, 72);
            this.txtQTPLSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtQTPLSP.Name = "txtQTPLSP";
            this.txtQTPLSP.Size = new System.Drawing.Size(94, 28);
            this.txtQTPLSP.TabIndex = 38;
            // 
            // lbQTPLSP
            // 
            this.lbQTPLSP.Location = new System.Drawing.Point(405, 72);
            this.lbQTPLSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQTPLSP.Name = "lbQTPLSP";
            this.lbQTPLSP.Size = new System.Drawing.Size(79, 24);
            this.lbQTPLSP.TabIndex = 37;
            this.lbQTPLSP.Text = "Loại SP";
            // 
            // lbQTPTenNV
            // 
            this.lbQTPTenNV.Location = new System.Drawing.Point(23, 150);
            this.lbQTPTenNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQTPTenNV.Name = "lbQTPTenNV";
            this.lbQTPTenNV.Size = new System.Drawing.Size(88, 24);
            this.lbQTPTenNV.TabIndex = 36;
            this.lbQTPTenNV.Text = "Mã NV";
            // 
            // txtQTPTSP
            // 
            this.txtQTPTSP.Location = new System.Drawing.Point(166, 108);
            this.txtQTPTSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtQTPTSP.Name = "txtQTPTSP";
            this.txtQTPTSP.Size = new System.Drawing.Size(192, 28);
            this.txtQTPTSP.TabIndex = 35;
            // 
            // lbQTPTSP
            // 
            this.lbQTPTSP.Location = new System.Drawing.Point(23, 111);
            this.lbQTPTSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQTPTSP.Name = "lbQTPTSP";
            this.lbQTPTSP.Size = new System.Drawing.Size(143, 24);
            this.lbQTPTSP.TabIndex = 34;
            this.lbQTPTSP.Text = "Tên sản phẩm";
            // 
            // txtQTPMSP
            // 
            this.txtQTPMSP.Location = new System.Drawing.Point(166, 72);
            this.txtQTPMSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtQTPMSP.Name = "txtQTPMSP";
            this.txtQTPMSP.Size = new System.Drawing.Size(192, 28);
            this.txtQTPMSP.TabIndex = 33;
            // 
            // lbQTPMSP
            // 
            this.lbQTPMSP.AutoSize = true;
            this.lbQTPMSP.Location = new System.Drawing.Point(23, 75);
            this.lbQTPMSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQTPMSP.Name = "lbQTPMSP";
            this.lbQTPMSP.Size = new System.Drawing.Size(124, 24);
            this.lbQTPMSP.TabIndex = 32;
            this.lbQTPMSP.Text = "Mã sản phẩm";
            // 
            // frOrther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 587);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frOrther";
            this.Text = "Quản Lý Thực Phẩm";
            this.Load += new System.EventHandler(this.frOrther_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbQTP.ResumeLayout(false);
            this.tbQTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQTP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbQTP;
        private System.Windows.Forms.DataGridView dgvQTP;
        private System.Windows.Forms.Label lbTitleQTP;
        private System.Windows.Forms.ComboBox cbQTPMaNV;
        private System.Windows.Forms.Button btQTPXoa;
        private System.Windows.Forms.Button btQTPSua;
        private System.Windows.Forms.Button btQTPThem;
        private System.Windows.Forms.Label lbQTPSL;
        private System.Windows.Forms.TextBox txtQTPDV;
        private System.Windows.Forms.Label lbQTPDV;
        private System.Windows.Forms.TextBox txtQTPLSP;
        private System.Windows.Forms.Label lbQTPLSP;
        private System.Windows.Forms.Label lbQTPTenNV;
        private System.Windows.Forms.TextBox txtQTPTSP;
        private System.Windows.Forms.Label lbQTPTSP;
        private System.Windows.Forms.TextBox txtQTPMSP;
        private System.Windows.Forms.Label lbQTPMSP;
        private System.Windows.Forms.TextBox txtQTPSL;

    }
}