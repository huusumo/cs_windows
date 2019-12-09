namespace QLKTX
{
    partial class frmDN
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
            this.btnDN = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTK = new System.Windows.Forms.TextBox();
            this.tbxMK = new System.Windows.Forms.TextBox();
            this.chbxMK = new System.Windows.Forms.CheckBox();
            this.lblSai = new System.Windows.Forms.Label();
            this.lblTK = new System.Windows.Forms.Label();
            this.lblMK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDN
            // 
            this.btnDN.Location = new System.Drawing.Point(53, 136);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(97, 33);
            this.btnDN.TabIndex = 2;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(174, 136);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 33);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu:";
            // 
            // tbxTK
            // 
            this.tbxTK.Location = new System.Drawing.Point(121, 15);
            this.tbxTK.Name = "tbxTK";
            this.tbxTK.Size = new System.Drawing.Size(189, 22);
            this.tbxTK.TabIndex = 0;
            // 
            // tbxMK
            // 
            this.tbxMK.Location = new System.Drawing.Point(121, 43);
            this.tbxMK.Name = "tbxMK";
            this.tbxMK.Size = new System.Drawing.Size(189, 22);
            this.tbxMK.TabIndex = 1;
            this.tbxMK.UseSystemPasswordChar = true;
            // 
            // chbxMK
            // 
            this.chbxMK.AutoSize = true;
            this.chbxMK.Location = new System.Drawing.Point(121, 71);
            this.chbxMK.Name = "chbxMK";
            this.chbxMK.Size = new System.Drawing.Size(145, 20);
            this.chbxMK.TabIndex = 6;
            this.chbxMK.Text = "Hiển thị mật khẩu";
            this.chbxMK.UseVisualStyleBackColor = true;
            this.chbxMK.CheckedChanged += new System.EventHandler(this.chbxMK_CheckedChanged);
            // 
            // lblSai
            // 
            this.lblSai.AutoSize = true;
            this.lblSai.ForeColor = System.Drawing.Color.Red;
            this.lblSai.Location = new System.Drawing.Point(62, 101);
            this.lblSai.Name = "lblSai";
            this.lblSai.Size = new System.Drawing.Size(210, 16);
            this.lblSai.TabIndex = 7;
            this.lblSai.Text = "Sai tài khoản hoặc mật khẩu !";
            this.lblSai.Visible = false;
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.ForeColor = System.Drawing.Color.Red;
            this.lblTK.Location = new System.Drawing.Point(89, 101);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(156, 16);
            this.lblTK.TabIndex = 8;
            this.lblTK.Text = "Chưa nhập tài khoản !";
            this.lblTK.Visible = false;
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.ForeColor = System.Drawing.Color.Red;
            this.lblMK.Location = new System.Drawing.Point(89, 101);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(155, 16);
            this.lblMK.TabIndex = 9;
            this.lblMK.Text = "Chưa nhập mật khẩu !";
            this.lblMK.Visible = false;
            // 
            // frmDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 192);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.lblTK);
            this.Controls.Add(this.lblSai);
            this.Controls.Add(this.chbxMK);
            this.Controls.Add(this.tbxMK);
            this.Controls.Add(this.tbxTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTK;
        private System.Windows.Forms.TextBox tbxMK;
        private System.Windows.Forms.CheckBox chbxMK;
        private System.Windows.Forms.Label lblSai;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblMK;
    }
}

