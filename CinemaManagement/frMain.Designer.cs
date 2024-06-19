namespace CinemaManagement
{
    partial class frMain
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
            this.dgvGiaVe = new System.Windows.Forms.DataGridView();
            this.lbDangPhim = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.lbMG = new System.Windows.Forms.Label();
            this.txtMG = new System.Windows.Forms.TextBox();
            this.cbDangPhim = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGiaVe
            // 
            this.dgvGiaVe.AllowUserToAddRows = false;
            this.dgvGiaVe.AllowUserToDeleteRows = false;
            this.dgvGiaVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaVe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGiaVe.Location = new System.Drawing.Point(0, 144);
            this.dgvGiaVe.Name = "dgvGiaVe";
            this.dgvGiaVe.Size = new System.Drawing.Size(830, 132);
            this.dgvGiaVe.TabIndex = 0;
            this.dgvGiaVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaVe_CellClick);
            // 
            // lbDangPhim
            // 
            this.lbDangPhim.AutoSize = true;
            this.lbDangPhim.Location = new System.Drawing.Point(220, 36);
            this.lbDangPhim.Name = "lbDangPhim";
            this.lbDangPhim.Size = new System.Drawing.Size(103, 24);
            this.lbDangPhim.TabIndex = 1;
            this.lbDangPhim.Text = "Dạng Phim";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(547, 36);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(38, 24);
            this.lbGia.TabIndex = 1;
            this.lbGia.Text = "Giá";
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Location = new System.Drawing.Point(599, 34);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(184, 29);
            this.txtGiaVe.TabIndex = 2;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(202, 81);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(121, 40);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(355, 81);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(121, 40);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(508, 81);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(121, 40);
            this.btXoa.TabIndex = 3;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // lbMG
            // 
            this.lbMG.AutoSize = true;
            this.lbMG.Location = new System.Drawing.Point(48, 36);
            this.lbMG.Name = "lbMG";
            this.lbMG.Size = new System.Drawing.Size(69, 24);
            this.lbMG.TabIndex = 1;
            this.lbMG.Text = "Mã Giá";
            // 
            // txtMG
            // 
            this.txtMG.Location = new System.Drawing.Point(131, 34);
            this.txtMG.Name = "txtMG";
            this.txtMG.Size = new System.Drawing.Size(75, 29);
            this.txtMG.TabIndex = 2;
            // 
            // cbDangPhim
            // 
            this.cbDangPhim.FormattingEnabled = true;
            this.cbDangPhim.Location = new System.Drawing.Point(337, 32);
            this.cbDangPhim.Name = "cbDangPhim";
            this.cbDangPhim.Size = new System.Drawing.Size(196, 32);
            this.cbDangPhim.TabIndex = 4;
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 276);
            this.Controls.Add(this.cbDangPhim);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtMG);
            this.Controls.Add(this.txtGiaVe);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbMG);
            this.Controls.Add(this.lbDangPhim);
            this.Controls.Add(this.dgvGiaVe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giá Vé";
            this.Load += new System.EventHandler(this.frMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGiaVe;
        private System.Windows.Forms.Label lbDangPhim;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label lbMG;
        private System.Windows.Forms.TextBox txtMG;
        private System.Windows.Forms.ComboBox cbDangPhim;

    }
}

