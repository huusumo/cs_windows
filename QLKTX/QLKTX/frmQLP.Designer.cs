namespace QLKTX
{
    partial class frmQLP
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
            this.cbxMaKN = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxMaPhong = new System.Windows.Forms.TextBox();
            this.cbxTruongPhong = new System.Windows.Forms.ComboBox();
            this.tbxTienDienNuoc = new System.Windows.Forms.TextBox();
            this.tbxChiTiet = new System.Windows.Forms.TextBox();
            this.dgvP = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaAll = new System.Windows.Forms.Button();
            this.tbxTim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng (*):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trưởng phòng:";
            // 
            // cbxMaKN
            // 
            this.cbxMaKN.FormattingEnabled = true;
            this.cbxMaKN.Location = new System.Drawing.Point(145, 40);
            this.cbxMaKN.Name = "cbxMaKN";
            this.cbxMaKN.Size = new System.Drawing.Size(121, 24);
            this.cbxMaKN.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chi tiết:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã khu nhà:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tiền điện nước:";
            // 
            // tbxMaPhong
            // 
            this.tbxMaPhong.Location = new System.Drawing.Point(145, 10);
            this.tbxMaPhong.Name = "tbxMaPhong";
            this.tbxMaPhong.Size = new System.Drawing.Size(121, 22);
            this.tbxMaPhong.TabIndex = 0;
            // 
            // cbxTruongPhong
            // 
            this.cbxTruongPhong.FormattingEnabled = true;
            this.cbxTruongPhong.Location = new System.Drawing.Point(145, 71);
            this.cbxTruongPhong.Name = "cbxTruongPhong";
            this.cbxTruongPhong.Size = new System.Drawing.Size(121, 24);
            this.cbxTruongPhong.TabIndex = 2;
            // 
            // tbxTienDienNuoc
            // 
            this.tbxTienDienNuoc.Location = new System.Drawing.Point(145, 101);
            this.tbxTienDienNuoc.Name = "tbxTienDienNuoc";
            this.tbxTienDienNuoc.Size = new System.Drawing.Size(121, 22);
            this.tbxTienDienNuoc.TabIndex = 3;
            // 
            // tbxChiTiet
            // 
            this.tbxChiTiet.Location = new System.Drawing.Point(145, 130);
            this.tbxChiTiet.Multiline = true;
            this.tbxChiTiet.Name = "tbxChiTiet";
            this.tbxChiTiet.Size = new System.Drawing.Size(177, 92);
            this.tbxChiTiet.TabIndex = 4;
            // 
            // dgvP
            // 
            this.dgvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP.Location = new System.Drawing.Point(16, 241);
            this.dgvP.Name = "dgvP";
            this.dgvP.Size = new System.Drawing.Size(566, 150);
            this.dgvP.TabIndex = 11;
            this.dgvP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvP_CellClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(351, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 39);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(463, 20);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(106, 39);
            this.btnQuayLai.TabIndex = 7;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(351, 64);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 39);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(463, 63);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 39);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(351, 108);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 39);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoaAll
            // 
            this.btnXoaAll.Location = new System.Drawing.Point(463, 108);
            this.btnXoaAll.Name = "btnXoaAll";
            this.btnXoaAll.Size = new System.Drawing.Size(106, 39);
            this.btnXoaAll.TabIndex = 11;
            this.btnXoaAll.Text = "Xóa tất cả";
            this.btnXoaAll.UseVisualStyleBackColor = true;
            this.btnXoaAll.Click += new System.EventHandler(this.btnXoaAll_Click);
            // 
            // tbxTim
            // 
            this.tbxTim.Location = new System.Drawing.Point(344, 200);
            this.tbxTim.Name = "tbxTim";
            this.tbxTim.Size = new System.Drawing.Size(238, 22);
            this.tbxTim.TabIndex = 5;
            this.tbxTim.TextChanged += new System.EventHandler(this.tbxTim_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nhập mã phòng để tìm;";
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(476, 400);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(106, 39);
            this.btnXuat.TabIndex = 19;
            this.btnXuat.Text = "Xuất Excel";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // frmQLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 451);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.tbxTim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXoaAll);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvP);
            this.Controls.Add(this.tbxChiTiet);
            this.Controls.Add(this.tbxTienDienNuoc);
            this.Controls.Add(this.cbxTruongPhong);
            this.Controls.Add(this.tbxMaPhong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxMaKN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÍ PHÒNG";
            this.Load += new System.EventHandler(this.frmQLP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMaKN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxMaPhong;
        private System.Windows.Forms.ComboBox cbxTruongPhong;
        private System.Windows.Forms.TextBox tbxTienDienNuoc;
        private System.Windows.Forms.TextBox tbxChiTiet;
        private System.Windows.Forms.DataGridView dgvP;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoaAll;
        private System.Windows.Forms.TextBox tbxTim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXuat;
    }
}