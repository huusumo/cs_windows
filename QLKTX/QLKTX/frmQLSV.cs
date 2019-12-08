using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX
{
    public partial class frmQLSV : Form
    {
        BusinessLogicLayer BLL;

        public frmQLSV()
        {
            InitializeComponent();

            BLL = new BusinessLogicLayer();
        }

        void ShowAllSV()
        {
            DataTable datable = BLL.GetAllSV();
            dgvSV.DataSource = datable;
            dgvSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmQLSV_Load(object sender, EventArgs e)
        {
            ShowAllSV();
        }

        private void dgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                tbxMaSV.Text = dgvSV.Rows[index].Cells[0].Value.ToString();
                tbxHoTenSV.Text = dgvSV.Rows[index].Cells[1].Value.ToString();
                dtpNgaySinh.Text = dgvSV.Rows[index].Cells[2].Value.ToString();
                if (dgvSV.Rows[index].Cells[3].Value.ToString() == "True")
                {
                    chbxNam.Checked = true;
                    chbxNu.Checked = false;
                }
                else
                {
                    chbxNam.Checked = false;
                    chbxNu.Checked = true;
                }
                tbxTrangThai.Text = dgvSV.Rows[index].Cells[4].Value.ToString();
                cbxMienGiam.Text = dgvSV.Rows[index].Cells[5].Value.ToString();
                dtpNgayVao.Text = dgvSV.Rows[index].Cells[6].Value.ToString();
                if (dgvSV.Rows[index].Cells[7].Value.ToString() == "True")
                    chbxDadongtien.Checked = true;
                else
                    chbxDadongtien.Checked = false;
                tbxChucVu.Text = dgvSV.Rows[index].Cells[8].Value.ToString();
            }
            catch { }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxMaSV.Clear();
            tbxHoTenSV.Clear();
            dtpNgaySinh.Text = "";
            chbxNam.Checked = false;
            chbxNu.Checked = false;
            tbxTrangThai.Clear();
            cbxMienGiam.Text = "";
            dtpNgayVao.Text = "";
            chbxDadongtien.Checked = false;
            tbxChucVu.Clear();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLTT QLTT = new frmQLTT();
            QLTT.Show();
        }

        bool CheckData()
        {
            if (string.IsNullOrEmpty(tbxMaSV.Text))
            {
                MessageBox.Show("Chưa nhập mã sinh viên!", "Thông báo", MessageBoxButtons.OK);
                tbxMaSV.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                SinhVien sv = new SinhVien();
                sv.MaSV = tbxMaSV.Text;
                sv.HoTenSV = tbxHoTenSV.Text;
                sv.NgaySinh = dtpNgaySinh.Value;
                sv.GioiTinh = chbxNam.Checked;
                sv.TrangThai = tbxTrangThai.Text;
                sv.MienGiam = cbxMienGiam.Text;
                sv.NgayVao = dtpNgayVao.Value;
                sv.DongTien = chbxDadongtien.Checked;
                sv.ChucVu = tbxChucVu.Text;

                if (BLL.ThemSV(sv))
                    ShowAllSV();
                else
                    MessageBox.Show("Đã xảy ra lỗi! Không thể thêm!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                SinhVien sv = new SinhVien();
                sv.MaSV = tbxMaSV.Text;
                sv.HoTenSV = tbxHoTenSV.Text;
                sv.NgaySinh = dtpNgaySinh.Value;
                sv.GioiTinh = chbxNam.Checked;
                sv.TrangThai = tbxTrangThai.Text;
                sv.MienGiam = cbxMienGiam.Text;
                sv.NgayVao = dtpNgayVao.Value;
                sv.DongTien = chbxDadongtien.Checked;
                sv.ChucVu = tbxChucVu.Text;

                if (BLL.SuaSV(sv))
                    ShowAllSV();
                else
                    MessageBox.Show("Đã xảy ra lỗi! Không thể sửa!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                SinhVien sv = new SinhVien();
                sv.MaSV = tbxMaSV.Text;

                if (BLL.XoaSV(sv))
                    ShowAllSV();
                else
                    MessageBox.Show("Đã xảy ra lỗi! Không thể xóa!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void tbxTimSV_TextChanged(object sender, EventArgs e)
        {
            string key = tbxTimSV.Text;

            DataTable datable = BLL.TimSV(key);
            dgvSV.DataSource = datable;
            dgvSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            if (BLL.XoaAllSV())
                ShowAllSV();
            else
                MessageBox.Show("Đã xảy ra lỗi!", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
