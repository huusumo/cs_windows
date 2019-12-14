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

            DataTable datable = BLL.GetAllMaPhong();
            for (int i = 0; i < datable.Rows.Count; i++)
                cbxMaP.Items.Add(datable.Rows[i].ItemArray[0]);
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
                cbxMaP.Text= dgvSV.Rows[index].Cells[2].Value.ToString();
                dtpNgaySinh.Text = dgvSV.Rows[index].Cells[3].Value.ToString();
                if (dgvSV.Rows[index].Cells[4].Value.ToString() == "True")
                {
                    chbxNam.Checked = true;
                    chbxNu.Checked = false;
                }
                else
                {
                    chbxNam.Checked = false;
                    chbxNu.Checked = true;
                }
                tbxTrangThai.Text = dgvSV.Rows[index].Cells[5].Value.ToString();
                cbxMienGiam.Text = dgvSV.Rows[index].Cells[6].Value.ToString();
                dtpNgayVao.Text = dgvSV.Rows[index].Cells[7].Value.ToString();
                if (dgvSV.Rows[index].Cells[8].Value.ToString() == "True")
                    chbxDadongtien.Checked = true;
                else
                    chbxDadongtien.Checked = false;
                tbxChucVu.Text = dgvSV.Rows[index].Cells[9].Value.ToString();
            }
            catch { }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxMaSV.Clear();
            tbxHoTenSV.Clear();
            cbxMaP.Text = "";
            dtpNgaySinh.Text = "";
            chbxNam.Checked = false;
            chbxNu.Checked = false;
            tbxTrangThai.Text = "";
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
                sv.MaPhong = cbxMaP.Text;
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
                sv.MaPhong = cbxMaP.Text;
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

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                app.Visible = true;

                worksheet.Cells[1, 1] = "THÔNG TIN SINH VIÊN";

                worksheet.Cells[3, 2] = "Mã sinh viên: " + tbxMaSV.Text;
                worksheet.Cells[4, 2] = "Họ tên: " + tbxHoTenSV.Text;
                worksheet.Cells[5, 2] = "Mã phòng: " + cbxMaP.Text;
                worksheet.Cells[6, 2] = "Ngày sinh: " + dtpNgaySinh.Text;
                if (chbxNam.Checked)
                    worksheet.Cells[7, 2] = "Giới tính: Nam";
                else
                    worksheet.Cells[7, 2] = "Giới tính: Nữ";
                worksheet.Cells[8, 2] = "Trạng thái: " + tbxTrangThai.Text;
                worksheet.Cells[9, 2] = "Miễn giảm: " + cbxMienGiam.Text;
                worksheet.Cells[10, 2] = "Ngày vào: " + dtpNgayVao.Text;
                if (chbxDadongtien.Checked)
                    worksheet.Cells[11, 2] = "Đã đóng tiền";
                else
                    worksheet.Cells[11, 2] = "Chưa đóng tiền";
                worksheet.Cells[12, 2] = "Chức vụ: " + tbxChucVu.Text;
            }
        }
    }
}
