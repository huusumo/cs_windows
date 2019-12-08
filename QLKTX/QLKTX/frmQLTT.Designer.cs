namespace QLKTX
{
    partial class frmQLTT
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
            this.btnQLKN = new System.Windows.Forms.Button();
            this.btnQLP = new System.Windows.Forms.Button();
            this.btnQLSV = new System.Windows.Forms.Button();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLKN
            // 
            this.btnQLKN.Location = new System.Drawing.Point(14, 70);
            this.btnQLKN.Name = "btnQLKN";
            this.btnQLKN.Size = new System.Drawing.Size(104, 86);
            this.btnQLKN.TabIndex = 0;
            this.btnQLKN.Text = "QUẢN LÍ KHU NHÀ";
            this.btnQLKN.UseVisualStyleBackColor = true;
            this.btnQLKN.Click += new System.EventHandler(this.btnQLKN_Click);
            // 
            // btnQLP
            // 
            this.btnQLP.Location = new System.Drawing.Point(130, 70);
            this.btnQLP.Name = "btnQLP";
            this.btnQLP.Size = new System.Drawing.Size(104, 86);
            this.btnQLP.TabIndex = 1;
            this.btnQLP.Text = "QUẢN LÍ PHÒNG";
            this.btnQLP.UseVisualStyleBackColor = true;
            this.btnQLP.Click += new System.EventHandler(this.btnQLP_Click);
            // 
            // btnQLSV
            // 
            this.btnQLSV.Location = new System.Drawing.Point(243, 70);
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.Size = new System.Drawing.Size(104, 86);
            this.btnQLSV.TabIndex = 2;
            this.btnQLSV.Text = "QUẢN LÍ SINH VIÊN";
            this.btnQLSV.UseVisualStyleBackColor = true;
            this.btnQLSV.Click += new System.EventHandler(this.btnQLSV_Click);
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Location = new System.Drawing.Point(272, 12);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(75, 31);
            this.btnQuaylai.TabIndex = 3;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // frmQLTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 206);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.btnQLSV);
            this.Controls.Add(this.btnQLP);
            this.Controls.Add(this.btnQLKN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÍ THÔNG TIN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQLKN;
        private System.Windows.Forms.Button btnQLP;
        private System.Windows.Forms.Button btnQLSV;
        private System.Windows.Forms.Button btnQuaylai;
    }
}