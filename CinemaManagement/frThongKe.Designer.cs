namespace CinemaManagement
{
    partial class frThongKe
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
            this.dgvTK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTK
            // 
            this.dgvTK.AllowUserToAddRows = false;
            this.dgvTK.AllowUserToDeleteRows = false;
            this.dgvTK.AllowUserToOrderColumns = true;
            this.dgvTK.AllowUserToResizeColumns = false;
            this.dgvTK.AllowUserToResizeRows = false;
            this.dgvTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTK.Location = new System.Drawing.Point(0, 0);
            this.dgvTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.Size = new System.Drawing.Size(915, 443);
            this.dgvTK.TabIndex = 0;
            // 
            // frThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 443);
            this.Controls.Add(this.dgvTK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frThongKe";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.frThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTK;

    }
}