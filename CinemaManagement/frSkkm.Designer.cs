namespace CinemaManagement
{
    partial class frSkkm
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
            this.tbSKKM = new System.Windows.Forms.TabPage();
            this.txtSKKMMGG = new System.Windows.Forms.TextBox();
            this.dgvSKKM = new System.Windows.Forms.DataGridView();
            this.lbTitleSKKM = new System.Windows.Forms.Label();
            this.btSKKMXoa = new System.Windows.Forms.Button();
            this.btSKKMSua = new System.Windows.Forms.Button();
            this.btSKKMThem = new System.Windows.Forms.Button();
            this.txtSKKMHA = new System.Windows.Forms.TextBox();
            this.lbHAskkm = new System.Windows.Forms.Label();
            this.lbMGGskkm = new System.Windows.Forms.Label();
            this.txtSKKMTSK = new System.Windows.Forms.TextBox();
            this.lbTSK = new System.Windows.Forms.Label();
            this.lbNKTskkm = new System.Windows.Forms.Label();
            this.lbNBDskkm = new System.Windows.Forms.Label();
            this.txtSKKMND = new System.Windows.Forms.TextBox();
            this.lbND = new System.Windows.Forms.Label();
            this.txtSKKMMSK = new System.Windows.Forms.TextBox();
            this.lbMSK = new System.Windows.Forms.Label();
            this.dateNBD = new System.Windows.Forms.DateTimePicker();
            this.dateNKT = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tbSKKM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSKKM)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbSKKM);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(818, 587);
            this.tabControl1.TabIndex = 0;
            // 
            // tbSKKM
            // 
            this.tbSKKM.Controls.Add(this.dateNKT);
            this.tbSKKM.Controls.Add(this.dateNBD);
            this.tbSKKM.Controls.Add(this.txtSKKMMGG);
            this.tbSKKM.Controls.Add(this.dgvSKKM);
            this.tbSKKM.Controls.Add(this.lbTitleSKKM);
            this.tbSKKM.Controls.Add(this.btSKKMXoa);
            this.tbSKKM.Controls.Add(this.btSKKMSua);
            this.tbSKKM.Controls.Add(this.btSKKMThem);
            this.tbSKKM.Controls.Add(this.txtSKKMHA);
            this.tbSKKM.Controls.Add(this.lbHAskkm);
            this.tbSKKM.Controls.Add(this.lbMGGskkm);
            this.tbSKKM.Controls.Add(this.txtSKKMTSK);
            this.tbSKKM.Controls.Add(this.lbTSK);
            this.tbSKKM.Controls.Add(this.lbNKTskkm);
            this.tbSKKM.Controls.Add(this.lbNBDskkm);
            this.tbSKKM.Controls.Add(this.txtSKKMND);
            this.tbSKKM.Controls.Add(this.lbND);
            this.tbSKKM.Controls.Add(this.txtSKKMMSK);
            this.tbSKKM.Controls.Add(this.lbMSK);
            this.tbSKKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSKKM.Location = new System.Drawing.Point(4, 22);
            this.tbSKKM.Margin = new System.Windows.Forms.Padding(2);
            this.tbSKKM.Name = "tbSKKM";
            this.tbSKKM.Padding = new System.Windows.Forms.Padding(2);
            this.tbSKKM.Size = new System.Drawing.Size(810, 561);
            this.tbSKKM.TabIndex = 0;
            this.tbSKKM.Text = "Sự Kiện KM";
            this.tbSKKM.UseVisualStyleBackColor = true;
            // 
            // txtSKKMMGG
            // 
            this.txtSKKMMGG.Location = new System.Drawing.Point(619, 171);
            this.txtSKKMMGG.Margin = new System.Windows.Forms.Padding(2);
            this.txtSKKMMGG.Name = "txtSKKMMGG";
            this.txtSKKMMGG.Size = new System.Drawing.Size(164, 28);
            this.txtSKKMMGG.TabIndex = 54;
            // 
            // dgvSKKM
            // 
            this.dgvSKKM.AllowUserToAddRows = false;
            this.dgvSKKM.AllowUserToDeleteRows = false;
            this.dgvSKKM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSKKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSKKM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSKKM.Location = new System.Drawing.Point(2, 323);
            this.dgvSKKM.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSKKM.Name = "dgvSKKM";
            this.dgvSKKM.RowTemplate.Height = 24;
            this.dgvSKKM.Size = new System.Drawing.Size(806, 236);
            this.dgvSKKM.TabIndex = 53;
            this.dgvSKKM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSKKM_CellClick);
            // 
            // lbTitleSKKM
            // 
            this.lbTitleSKKM.Location = new System.Drawing.Point(267, 11);
            this.lbTitleSKKM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitleSKKM.Name = "lbTitleSKKM";
            this.lbTitleSKKM.Size = new System.Drawing.Size(277, 39);
            this.lbTitleSKKM.TabIndex = 52;
            this.lbTitleSKKM.Text = "Sự Kiện Khuyến Mãi";
            this.lbTitleSKKM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSKKMXoa
            // 
            this.btSKKMXoa.Location = new System.Drawing.Point(526, 259);
            this.btSKKMXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btSKKMXoa.Name = "btSKKMXoa";
            this.btSKKMXoa.Size = new System.Drawing.Size(89, 46);
            this.btSKKMXoa.TabIndex = 51;
            this.btSKKMXoa.Text = "Xóa";
            this.btSKKMXoa.UseVisualStyleBackColor = true;
            this.btSKKMXoa.Click += new System.EventHandler(this.btSKKMXoa_Click);
            // 
            // btSKKMSua
            // 
            this.btSKKMSua.Location = new System.Drawing.Point(361, 259);
            this.btSKKMSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSKKMSua.Name = "btSKKMSua";
            this.btSKKMSua.Size = new System.Drawing.Size(89, 46);
            this.btSKKMSua.TabIndex = 50;
            this.btSKKMSua.Text = "Sửa";
            this.btSKKMSua.UseVisualStyleBackColor = true;
            this.btSKKMSua.Click += new System.EventHandler(this.btSKKMSua_Click);
            // 
            // btSKKMThem
            // 
            this.btSKKMThem.Location = new System.Drawing.Point(196, 259);
            this.btSKKMThem.Margin = new System.Windows.Forms.Padding(2);
            this.btSKKMThem.Name = "btSKKMThem";
            this.btSKKMThem.Size = new System.Drawing.Size(89, 46);
            this.btSKKMThem.TabIndex = 49;
            this.btSKKMThem.Text = "Thêm";
            this.btSKKMThem.UseVisualStyleBackColor = true;
            this.btSKKMThem.Click += new System.EventHandler(this.btSKKMThem_Click);
            // 
            // txtSKKMHA
            // 
            this.txtSKKMHA.Location = new System.Drawing.Point(143, 213);
            this.txtSKKMHA.Margin = new System.Windows.Forms.Padding(2);
            this.txtSKKMHA.Name = "txtSKKMHA";
            this.txtSKKMHA.Size = new System.Drawing.Size(640, 28);
            this.txtSKKMHA.TabIndex = 48;
            // 
            // lbHAskkm
            // 
            this.lbHAskkm.Location = new System.Drawing.Point(45, 213);
            this.lbHAskkm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHAskkm.Name = "lbHAskkm";
            this.lbHAskkm.Size = new System.Drawing.Size(90, 28);
            this.lbHAskkm.TabIndex = 47;
            this.lbHAskkm.Text = "Hình ảnh";
            // 
            // lbMGGskkm
            // 
            this.lbMGGskkm.Location = new System.Drawing.Point(530, 171);
            this.lbMGGskkm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMGGskkm.Name = "lbMGGskkm";
            this.lbMGGskkm.Size = new System.Drawing.Size(85, 28);
            this.lbMGGskkm.TabIndex = 46;
            this.lbMGGskkm.Text = "Giảm giá";
            // 
            // txtSKKMTSK
            // 
            this.txtSKKMTSK.Location = new System.Drawing.Point(529, 65);
            this.txtSKKMTSK.Margin = new System.Windows.Forms.Padding(2);
            this.txtSKKMTSK.Name = "txtSKKMTSK";
            this.txtSKKMTSK.Size = new System.Drawing.Size(254, 28);
            this.txtSKKMTSK.TabIndex = 45;
            // 
            // lbTSK
            // 
            this.lbTSK.Location = new System.Drawing.Point(406, 65);
            this.lbTSK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTSK.Name = "lbTSK";
            this.lbTSK.Size = new System.Drawing.Size(119, 28);
            this.lbTSK.TabIndex = 44;
            this.lbTSK.Text = "Tên sự kiện";
            // 
            // lbNKTskkm
            // 
            this.lbNKTskkm.Location = new System.Drawing.Point(272, 171);
            this.lbNKTskkm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNKTskkm.Name = "lbNKTskkm";
            this.lbNKTskkm.Size = new System.Drawing.Size(130, 28);
            this.lbNKTskkm.TabIndex = 42;
            this.lbNKTskkm.Text = "Ngày kết thúc";
            // 
            // lbNBDskkm
            // 
            this.lbNBDskkm.Location = new System.Drawing.Point(5, 171);
            this.lbNBDskkm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNBDskkm.Name = "lbNBDskkm";
            this.lbNBDskkm.Size = new System.Drawing.Size(130, 28);
            this.lbNBDskkm.TabIndex = 40;
            this.lbNBDskkm.Text = "Ngày bắt đầu";
            // 
            // txtSKKMND
            // 
            this.txtSKKMND.Location = new System.Drawing.Point(143, 98);
            this.txtSKKMND.Margin = new System.Windows.Forms.Padding(2);
            this.txtSKKMND.Multiline = true;
            this.txtSKKMND.Name = "txtSKKMND";
            this.txtSKKMND.Size = new System.Drawing.Size(640, 60);
            this.txtSKKMND.TabIndex = 39;
            // 
            // lbND
            // 
            this.lbND.Location = new System.Drawing.Point(45, 101);
            this.lbND.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbND.Name = "lbND";
            this.lbND.Size = new System.Drawing.Size(90, 28);
            this.lbND.TabIndex = 38;
            this.lbND.Text = "Nội dung ";
            // 
            // txtSKKMMSK
            // 
            this.txtSKKMMSK.Location = new System.Drawing.Point(146, 62);
            this.txtSKKMMSK.Margin = new System.Windows.Forms.Padding(2);
            this.txtSKKMMSK.Name = "txtSKKMMSK";
            this.txtSKKMMSK.Size = new System.Drawing.Size(256, 28);
            this.txtSKKMMSK.TabIndex = 37;
            // 
            // lbMSK
            // 
            this.lbMSK.Location = new System.Drawing.Point(25, 68);
            this.lbMSK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMSK.Name = "lbMSK";
            this.lbMSK.Size = new System.Drawing.Size(110, 28);
            this.lbMSK.TabIndex = 36;
            this.lbMSK.Text = "Mã sự kiện";
            // 
            // dateNBD
            // 
            this.dateNBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNBD.Location = new System.Drawing.Point(141, 171);
            this.dateNBD.Name = "dateNBD";
            this.dateNBD.Size = new System.Drawing.Size(126, 28);
            this.dateNBD.TabIndex = 55;
            // 
            // dateNKT
            // 
            this.dateNKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNKT.Location = new System.Drawing.Point(399, 171);
            this.dateNKT.Name = "dateNKT";
            this.dateNKT.Size = new System.Drawing.Size(126, 28);
            this.dateNKT.TabIndex = 55;
            // 
            // frSkkm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 587);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frSkkm";
            this.Text = "frSkkm";
            this.Load += new System.EventHandler(this.frSkkm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbSKKM.ResumeLayout(false);
            this.tbSKKM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSKKM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbSKKM;
        private System.Windows.Forms.DataGridView dgvSKKM;
        private System.Windows.Forms.Label lbTitleSKKM;
        private System.Windows.Forms.Button btSKKMXoa;
        private System.Windows.Forms.Button btSKKMSua;
        private System.Windows.Forms.Button btSKKMThem;
        private System.Windows.Forms.TextBox txtSKKMHA;
        private System.Windows.Forms.Label lbHAskkm;
        private System.Windows.Forms.Label lbMGGskkm;
        private System.Windows.Forms.TextBox txtSKKMTSK;
        private System.Windows.Forms.Label lbTSK;
        private System.Windows.Forms.Label lbNKTskkm;
        private System.Windows.Forms.Label lbNBDskkm;
        private System.Windows.Forms.TextBox txtSKKMND;
        private System.Windows.Forms.Label lbND;
        private System.Windows.Forms.TextBox txtSKKMMSK;
        private System.Windows.Forms.Label lbMSK;
        private System.Windows.Forms.TextBox txtSKKMMGG;
        private System.Windows.Forms.DateTimePicker dateNKT;
        private System.Windows.Forms.DateTimePicker dateNBD;
    }
}