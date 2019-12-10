namespace QLKTX
{
    partial class frmDoiMK
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDoiMK = new System.Windows.Forms.TextBox();
            this.btnDoi = new System.Windows.Forms.Button();
            this.lblDoimktc = new System.Windows.Forms.Label();
            this.lblTKdoi = new System.Windows.Forms.Label();
            this.lblDoimktb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu mới:";
            // 
            // tbxDoiMK
            // 
            this.tbxDoiMK.Location = new System.Drawing.Point(126, 49);
            this.tbxDoiMK.Name = "tbxDoiMK";
            this.tbxDoiMK.Size = new System.Drawing.Size(164, 22);
            this.tbxDoiMK.TabIndex = 1;
            // 
            // btnDoi
            // 
            this.btnDoi.Location = new System.Drawing.Point(93, 115);
            this.btnDoi.Name = "btnDoi";
            this.btnDoi.Size = new System.Drawing.Size(115, 30);
            this.btnDoi.TabIndex = 2;
            this.btnDoi.Text = "Đổi mật khẩu";
            this.btnDoi.UseVisualStyleBackColor = true;
            this.btnDoi.Click += new System.EventHandler(this.btnDoi_Click);
            // 
            // lblDoimktc
            // 
            this.lblDoimktc.AutoSize = true;
            this.lblDoimktc.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblDoimktc.Location = new System.Drawing.Point(62, 84);
            this.lblDoimktc.Name = "lblDoimktc";
            this.lblDoimktc.Size = new System.Drawing.Size(184, 16);
            this.lblDoimktc.TabIndex = 3;
            this.lblDoimktc.Text = "Đổi mật khẩu thành công !";
            this.lblDoimktc.Visible = false;
            // 
            // lblTKdoi
            // 
            this.lblTKdoi.AutoSize = true;
            this.lblTKdoi.Location = new System.Drawing.Point(17, 24);
            this.lblTKdoi.Name = "lblTKdoi";
            this.lblTKdoi.Size = new System.Drawing.Size(0, 16);
            this.lblTKdoi.TabIndex = 4;
            // 
            // lblDoimktb
            // 
            this.lblDoimktb.AutoSize = true;
            this.lblDoimktb.ForeColor = System.Drawing.Color.Red;
            this.lblDoimktb.Location = new System.Drawing.Point(74, 84);
            this.lblDoimktb.Name = "lblDoimktb";
            this.lblDoimktb.Size = new System.Drawing.Size(160, 16);
            this.lblDoimktb.TabIndex = 5;
            this.lblDoimktb.Text = "Đổi mật khẩu thất bại !";
            this.lblDoimktb.Visible = false;
            // 
            // frmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 165);
            this.Controls.Add(this.lblDoimktb);
            this.Controls.Add(this.lblTKdoi);
            this.Controls.Add(this.lblDoimktc);
            this.Controls.Add(this.btnDoi);
            this.Controls.Add(this.tbxDoiMK);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐỔI MẬT KHẨU";
            this.Load += new System.EventHandler(this.frmDoiMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDoiMK;
        private System.Windows.Forms.Button btnDoi;
        private System.Windows.Forms.Label lblDoimktc;
        private System.Windows.Forms.Label lblTKdoi;
        private System.Windows.Forms.Label lblDoimktb;
    }
}