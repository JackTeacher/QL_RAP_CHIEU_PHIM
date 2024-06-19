namespace CinemaManagement
{
    partial class frConfig
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
            this.lbServer = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Location = new System.Drawing.Point(91, 35);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(69, 23);
            this.lbServer.TabIndex = 0;
            this.lbServer.Text = "Server:";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(69, 75);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(91, 23);
            this.lbData.TabIndex = 0;
            this.lbData.Text = "Database:";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(180, 35);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(231, 31);
            this.txtServer.TabIndex = 0;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(180, 72);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(231, 31);
            this.txtData.TabIndex = 1;
            // 
            // btConfirm
            // 
            this.btConfirm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.Location = new System.Drawing.Point(102, 132);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(135, 42);
            this.btConfirm.TabIndex = 2;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(243, 132);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(135, 42);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // frConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 196);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbServer);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frConfig_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Button btClose;
    }
}