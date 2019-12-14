namespace QLKTX
{
    partial class frmQLTK
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
            this.btnlapdsKN = new System.Windows.Forms.Button();
            this.btnlapdsP = new System.Windows.Forms.Button();
            this.btnlapdsSVno = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnlapdsSV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMienGiam = new System.Windows.Forms.Button();
            this.btnLapdssvmv = new System.Windows.Forms.Button();
            this.btnLapdssvhh = new System.Windows.Forms.Button();
            this.lblds = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMakn = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxMasv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMaphong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.tbxTTP = new System.Windows.Forms.TextBox();
            this.lblTTP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTK
            // 
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.Location = new System.Drawing.Point(26, 243);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.Size = new System.Drawing.Size(652, 188);
            this.dgvTK.TabIndex = 0;
            this.dgvTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTK_CellClick);
            // 
            // btnlapdsKN
            // 
            this.btnlapdsKN.Location = new System.Drawing.Point(9, 25);
            this.btnlapdsKN.Name = "btnlapdsKN";
            this.btnlapdsKN.Size = new System.Drawing.Size(101, 46);
            this.btnlapdsKN.TabIndex = 1;
            this.btnlapdsKN.Text = "Khu nhà";
            this.btnlapdsKN.UseVisualStyleBackColor = true;
            this.btnlapdsKN.Click += new System.EventHandler(this.btnlapdsKN_Click);
            // 
            // btnlapdsP
            // 
            this.btnlapdsP.Location = new System.Drawing.Point(119, 25);
            this.btnlapdsP.Name = "btnlapdsP";
            this.btnlapdsP.Size = new System.Drawing.Size(101, 46);
            this.btnlapdsP.TabIndex = 2;
            this.btnlapdsP.Text = "Phòng";
            this.btnlapdsP.UseVisualStyleBackColor = true;
            this.btnlapdsP.Click += new System.EventHandler(this.btnlapdsP_Click);
            // 
            // btnlapdsSVno
            // 
            this.btnlapdsSVno.Location = new System.Drawing.Point(119, 79);
            this.btnlapdsSVno.Name = "btnlapdsSVno";
            this.btnlapdsSVno.Size = new System.Drawing.Size(101, 46);
            this.btnlapdsSVno.TabIndex = 3;
            this.btnlapdsSVno.Text = "Sinh viên nợ";
            this.btnlapdsSVno.UseVisualStyleBackColor = true;
            this.btnlapdsSVno.Click += new System.EventHandler(this.btnlapdsSVno_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(562, 449);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(116, 44);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnlapdsSV
            // 
            this.btnlapdsSV.Location = new System.Drawing.Point(229, 25);
            this.btnlapdsSV.Name = "btnlapdsSV";
            this.btnlapdsSV.Size = new System.Drawing.Size(101, 46);
            this.btnlapdsSV.TabIndex = 5;
            this.btnlapdsSV.Text = "Sinh viên";
            this.btnlapdsSV.UseVisualStyleBackColor = true;
            this.btnlapdsSV.Click += new System.EventHandler(this.btnlapdsSV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMienGiam);
            this.groupBox1.Controls.Add(this.btnLapdssvmv);
            this.groupBox1.Controls.Add(this.btnLapdssvhh);
            this.groupBox1.Controls.Add(this.btnlapdsKN);
            this.groupBox1.Controls.Add(this.btnlapdsSV);
            this.groupBox1.Controls.Add(this.btnlapdsSVno);
            this.groupBox1.Controls.Add(this.btnlapdsP);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 195);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập danh sách";
            // 
            // btnMienGiam
            // 
            this.btnMienGiam.Location = new System.Drawing.Point(119, 132);
            this.btnMienGiam.Name = "btnMienGiam";
            this.btnMienGiam.Size = new System.Drawing.Size(101, 46);
            this.btnMienGiam.TabIndex = 8;
            this.btnMienGiam.Text = "Sinh viên miễn giảm";
            this.btnMienGiam.UseVisualStyleBackColor = true;
            this.btnMienGiam.Click += new System.EventHandler(this.btnMienGiam_Click);
            // 
            // btnLapdssvmv
            // 
            this.btnLapdssvmv.Location = new System.Drawing.Point(9, 79);
            this.btnLapdssvmv.Name = "btnLapdssvmv";
            this.btnLapdssvmv.Size = new System.Drawing.Size(101, 46);
            this.btnLapdssvmv.TabIndex = 7;
            this.btnLapdssvmv.Text = "Sinh viên mới vào";
            this.btnLapdssvmv.UseVisualStyleBackColor = true;
            this.btnLapdssvmv.Click += new System.EventHandler(this.btnLapdssvmv_Click);
            // 
            // btnLapdssvhh
            // 
            this.btnLapdssvhh.Location = new System.Drawing.Point(9, 132);
            this.btnLapdssvhh.Name = "btnLapdssvhh";
            this.btnLapdssvhh.Size = new System.Drawing.Size(101, 46);
            this.btnLapdssvhh.TabIndex = 6;
            this.btnLapdssvhh.Text = "Sinh viên hết hạn";
            this.btnLapdssvhh.UseVisualStyleBackColor = true;
            this.btnLapdssvhh.Click += new System.EventHandler(this.btnLapdssvhh_Click);
            // 
            // lblds
            // 
            this.lblds.AutoSize = true;
            this.lblds.Location = new System.Drawing.Point(23, 224);
            this.lblds.Name = "lblds";
            this.lblds.Size = new System.Drawing.Size(0, 16);
            this.lblds.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã khu nhà:";
            // 
            // tbxMakn
            // 
            this.tbxMakn.Enabled = false;
            this.tbxMakn.Location = new System.Drawing.Point(135, 34);
            this.tbxMakn.Name = "tbxMakn";
            this.tbxMakn.Size = new System.Drawing.Size(129, 22);
            this.tbxMakn.TabIndex = 9;
            this.tbxMakn.TextChanged += new System.EventHandler(this.tbxMakn_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxMasv);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxMaphong);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbxMakn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(385, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 141);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập để tìm";
            // 
            // tbxMasv
            // 
            this.tbxMasv.Enabled = false;
            this.tbxMasv.Location = new System.Drawing.Point(135, 90);
            this.tbxMasv.Name = "tbxMasv";
            this.tbxMasv.Size = new System.Drawing.Size(129, 22);
            this.tbxMasv.TabIndex = 13;
            this.tbxMasv.TextChanged += new System.EventHandler(this.tbxMasv_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã sinh viên:";
            // 
            // tbxMaphong
            // 
            this.tbxMaphong.Enabled = false;
            this.tbxMaphong.Location = new System.Drawing.Point(135, 62);
            this.tbxMaphong.Name = "tbxMaphong";
            this.tbxMaphong.Size = new System.Drawing.Size(129, 22);
            this.tbxMaphong.TabIndex = 11;
            this.tbxMaphong.TextChanged += new System.EventHandler(this.tbxMaphong_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã phòng:";
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Location = new System.Drawing.Point(578, 12);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(100, 33);
            this.btnQuaylai.TabIndex = 11;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // tbxTTP
            // 
            this.tbxTTP.Enabled = false;
            this.tbxTTP.Location = new System.Drawing.Point(153, 460);
            this.tbxTTP.Name = "tbxTTP";
            this.tbxTTP.Size = new System.Drawing.Size(128, 22);
            this.tbxTTP.TabIndex = 15;
            this.tbxTTP.Visible = false;
            // 
            // lblTTP
            // 
            this.lblTTP.AutoSize = true;
            this.lblTTP.Location = new System.Drawing.Point(23, 463);
            this.lblTTP.Name = "lblTTP";
            this.lblTTP.Size = new System.Drawing.Size(124, 16);
            this.lblTTP.TabIndex = 14;
            this.lblTTP.Text = "Tổng tiền phòng:";
            this.lblTTP.Visible = false;
            // 
            // frmQLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 510);
            this.Controls.Add(this.tbxTTP);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.lblTTP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblds);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgvTK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ THỐNG KÊ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTK;
        private System.Windows.Forms.Button btnlapdsKN;
        private System.Windows.Forms.Button btnlapdsP;
        private System.Windows.Forms.Button btnlapdsSVno;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnlapdsSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMakn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxMasv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMaphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.Button btnLapdssvmv;
        private System.Windows.Forms.Button btnLapdssvhh;
        private System.Windows.Forms.TextBox tbxTTP;
        private System.Windows.Forms.Label lblTTP;
        private System.Windows.Forms.Button btnMienGiam;
    }
}