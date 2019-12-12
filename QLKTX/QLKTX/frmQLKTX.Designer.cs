namespace QLKTX
{
    partial class frmQLKTX
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
            this.btnQLTT = new System.Windows.Forms.Button();
            this.btnQLTK = new System.Windows.Forms.Button();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.lblTK = new System.Windows.Forms.Label();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLTT
            // 
            this.btnQLTT.Location = new System.Drawing.Point(31, 133);
            this.btnQLTT.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLTT.Name = "btnQLTT";
            this.btnQLTT.Size = new System.Drawing.Size(214, 74);
            this.btnQLTT.TabIndex = 0;
            this.btnQLTT.Text = "QUẢN LÍ THÔNG TIN";
            this.btnQLTT.UseVisualStyleBackColor = true;
            this.btnQLTT.Click += new System.EventHandler(this.btnQLTT_Click);
            // 
            // btnQLTK
            // 
            this.btnQLTK.Location = new System.Drawing.Point(275, 133);
            this.btnQLTK.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLTK.Name = "btnQLTK";
            this.btnQLTK.Size = new System.Drawing.Size(214, 74);
            this.btnQLTK.TabIndex = 1;
            this.btnQLTK.Text = "QUẢN LÍ THỐNG KÊ";
            this.btnQLTK.UseVisualStyleBackColor = true;
            this.btnQLTK.Click += new System.EventHandler(this.btnQLTK_Click);
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Location = new System.Drawing.Point(399, 12);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(90, 32);
            this.btnQuaylai.TabIndex = 2;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Location = new System.Drawing.Point(31, 15);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(0, 16);
            this.lblTK.TabIndex = 3;
            // 
            // btnThemTK
            // 
            this.btnThemTK.Location = new System.Drawing.Point(31, 80);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(126, 32);
            this.btnThemTK.TabIndex = 4;
            this.btnThemTK.Text = "Thêm tài khoản";
            this.btnThemTK.UseVisualStyleBackColor = true;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(31, 42);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(126, 32);
            this.btnDoiMatKhau.TabIndex = 5;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // frmQLKTX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 227);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.btnThemTK);
            this.Controls.Add(this.lblTK);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.btnQLTK);
            this.Controls.Add(this.btnQLTT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLKTX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÍ KÝ TÚC XÁ";
            this.Load += new System.EventHandler(this.frmQLKTX_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQLTT;
        private System.Windows.Forms.Button btnQLTK;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.Button btnDoiMatKhau;
    }
}