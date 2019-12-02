namespace QLSV
{
    partial class frmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTK = new System.Windows.Forms.TextBox();
            this.tbxMK = new System.Windows.Forms.TextBox();
            this.lblSai = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chbxSMK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // tbxTK
            // 
            this.tbxTK.Location = new System.Drawing.Point(109, 18);
            this.tbxTK.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTK.Name = "tbxTK";
            this.tbxTK.Size = new System.Drawing.Size(161, 22);
            this.tbxTK.TabIndex = 2;
            // 
            // tbxMK
            // 
            this.tbxMK.Location = new System.Drawing.Point(109, 53);
            this.tbxMK.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMK.Name = "tbxMK";
            this.tbxMK.Size = new System.Drawing.Size(161, 22);
            this.tbxMK.TabIndex = 3;
            this.tbxMK.UseSystemPasswordChar = true;
            // 
            // lblSai
            // 
            this.lblSai.AutoSize = true;
            this.lblSai.ForeColor = System.Drawing.Color.Red;
            this.lblSai.Location = new System.Drawing.Point(39, 124);
            this.lblSai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSai.Name = "lblSai";
            this.lblSai.Size = new System.Drawing.Size(210, 16);
            this.lblSai.TabIndex = 4;
            this.lblSai.Text = "Sai tài khoản hoặc mật khẩu !";
            this.lblSai.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(23, 153);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 28);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(158, 153);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 28);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chbxSMK
            // 
            this.chbxSMK.AutoSize = true;
            this.chbxSMK.Location = new System.Drawing.Point(109, 91);
            this.chbxSMK.Name = "chbxSMK";
            this.chbxSMK.Size = new System.Drawing.Size(145, 20);
            this.chbxSMK.TabIndex = 7;
            this.chbxSMK.Text = "Hiển thị mật khẩu";
            this.chbxSMK.UseVisualStyleBackColor = true;
            this.chbxSMK.CheckedChanged += new System.EventHandler(this.chbxSMK_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(297, 204);
            this.Controls.Add(this.chbxSMK);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblSai);
            this.Controls.Add(this.tbxMK);
            this.Controls.Add(this.tbxTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM ĐĂNG NHẬP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTK;
        private System.Windows.Forms.TextBox tbxMK;
        private System.Windows.Forms.Label lblSai;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chbxSMK;
    }
}