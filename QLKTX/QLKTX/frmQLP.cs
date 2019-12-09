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
    public partial class frmQLP : Form
    {
        BusinessLogicLayer BLL;

        public frmQLP()
        {
            InitializeComponent();

            BLL = new BusinessLogicLayer();

            DataTable adapter = BLL.GetAllMaKN();
            for (int i = 0; i < adapter.Rows.Count; i++)
                cbxMaKN.Items.Add(adapter.Rows[i].ItemArray[0]);
        }

        void ShowAllPhong()
        {
            DataTable datable = BLL.GetAllPhong();
            dgvP.DataSource = datable;
            dgvP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmQLP_Load(object sender, EventArgs e)
        {
            ShowAllPhong();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxMaPhong.Clear();
            cbxMaKN.Text = "";
            cbxTruongPhong.Text = "";
            tbxTienDienNuoc.Clear();
            tbxChiTiet.Clear();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLTT QLTT = new frmQLTT();
            QLTT.Show();
        }

        bool CheckData()
        {
            if (string.IsNullOrEmpty(tbxMaPhong.Text))
            {
                MessageBox.Show("Chưa nhập mã phòng!", "Thông báo", MessageBoxButtons.OK);
                tbxMaPhong.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Phong phg = new Phong();
                phg.MaPhong = tbxMaPhong.Text;
                phg.MaKN = cbxMaKN.Text;
                phg.TruongPhong = cbxTruongPhong.Text;
                try
                {
                    phg.TienDienNuoc = double.Parse(tbxTienDienNuoc.Text);
                }
                catch { }
                phg.ChiTiet = tbxChiTiet.Text;

                if (BLL.ThemPhong(phg))
                    ShowAllPhong();
                else
                    MessageBox.Show("Đã xảy ra lỗi! Không thể thêm!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dgvP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            tbxMaPhong.Text = dgvP.Rows[index].Cells[0].Value.ToString();
            cbxMaKN.Text = dgvP.Rows[index].Cells[1].Value.ToString();
            cbxTruongPhong.Text = dgvP.Rows[index].Cells[2].Value.ToString();
            tbxTienDienNuoc.Text = dgvP.Rows[index].Cells[3].Value.ToString();
            tbxChiTiet.Text = dgvP.Rows[index].Cells[4].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Phong phg = new Phong();
                phg.MaPhong = tbxMaPhong.Text;
                phg.MaKN = cbxMaKN.Text;
                phg.TruongPhong = cbxTruongPhong.Text;
                phg.TienDienNuoc = double.Parse(tbxTienDienNuoc.Text);
                phg.ChiTiet = tbxChiTiet.Text;

                if (BLL.SuaPhong(phg))
                    ShowAllPhong();
                else
                    MessageBox.Show("Đã xảy ra lỗi! Không thể sửa!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Phong phg = new Phong();
                phg.MaPhong = tbxMaPhong.Text;

                if (BLL.XoaPhong(phg))
                    ShowAllPhong();
                else
                    MessageBox.Show("Đã xảy ra lỗi! Không thể xóa!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            if (BLL.XoaAllPhong())
                ShowAllPhong();
            else
                MessageBox.Show("Đã xảy ra lỗi! Không thể xóa tất cả!", "Thông báo", MessageBoxButtons.OK);
        }

        private void tbxTim_TextChanged(object sender, EventArgs e)
        {
            string key = tbxTim.Text;

            DataTable datable = BLL.TimPhong(key);
            dgvP.DataSource = datable;
            dgvP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

                worksheet.Cells[1, 1] = "THÔNG TIN PHÒNG";

                worksheet.Cells[3, 2] = "Mã phòng: " + tbxMaPhong.Text;
                worksheet.Cells[4, 2] = "Mã khu nhà: " + cbxMaKN.Text;
                worksheet.Cells[5, 2] = "Trưởng phòng: " + cbxTruongPhong.Text;
                worksheet.Cells[6, 2] = "Tiền điện nước: " + tbxTienDienNuoc.Text;
                worksheet.Cells[7, 2] = "Chi tiết: " + tbxChiTiet.Text;
            }
        }
    }
}
