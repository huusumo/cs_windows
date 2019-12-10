namespace QLKTX
{
    partial class frmThemTK
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
            this.btnThemTK = new System.Windows.Forms.Button();
            this.lblThemtktc = new System.Windows.Forms.Label();
            this.lblThemtktb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // tbxTK
            // 
            this.tbxTK.Location = new System.Drawing.Point(118, 25);
            this.tbxTK.Name = "tbxTK";
            this.tbxTK.Size = new System.Drawing.Size(199, 22);
            this.tbxTK.TabIndex = 2;
            // 
            // tbxMK
            // 
            this.tbxMK.Location = new System.Drawing.Point(118, 58);
            this.tbxMK.Name = "tbxMK";
            this.tbxMK.Size = new System.Drawing.Size(199, 22);
            this.tbxMK.TabIndex = 3;
            // 
            // btnThemTK
            // 
            this.btnThemTK.Location = new System.Drawing.Point(107, 137);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(137, 29);
            this.btnThemTK.TabIndex = 4;
            this.btnThemTK.Text = "Thêm tài khoản";
            this.btnThemTK.UseVisualStyleBackColor = true;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // lblThemtktc
            // 
            this.lblThemtktc.AutoSize = true;
            this.lblThemtktc.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblThemtktc.Location = new System.Drawing.Point(76, 99);
            this.lblThemtktc.Name = "lblThemtktc";
            this.lblThemtktc.Size = new System.Drawing.Size(201, 16);
            this.lblThemtktc.TabIndex = 5;
            this.lblThemtktc.Text = "Thêm tài khoản thành công !";
            this.lblThemtktc.Visible = false;
            // 
            // lblThemtktb
            // 
            this.lblThemtktb.AutoSize = true;
            this.lblThemtktb.ForeColor = System.Drawing.Color.Red;
            this.lblThemtktb.Location = new System.Drawing.Point(90, 99);
            this.lblThemtktb.Name = "lblThemtktb";
            this.lblThemtktb.Size = new System.Drawing.Size(177, 16);
            this.lblThemtktb.TabIndex = 6;
            this.lblThemtktb.Text = "Thêm tài khoản thất bại !";
            this.lblThemtktb.Visible = false;
            // 
            // frmThemTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 184);
            this.Controls.Add(this.lblThemtktb);
            this.Controls.Add(this.lblThemtktc);
            this.Controls.Add(this.btnThemTK);
            this.Controls.Add(this.tbxMK);
            this.Controls.Add(this.tbxTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmThemTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM TÀI KHOẢN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTK;
        private System.Windows.Forms.TextBox tbxMK;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.Label lblThemtktc;
        private System.Windows.Forms.Label lblThemtktb;
    }
}