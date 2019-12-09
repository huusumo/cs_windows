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
    public partial class frmQLKN : Form
    {
        BusinessLogicLayer BLL;

        public frmQLKN()
        {
            InitializeComponent();

            BLL = new BusinessLogicLayer();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLTT QLTT = new frmQLTT();
            QLTT.Show();
        }

        void ShowAllKN()
        {
            DataTable datable = BLL.GetAllKN();
            dgvKN.DataSource = datable;
            dgvKN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmQLKN_Load(object sender, EventArgs e)
        {
            ShowAllKN();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxMaKN.Clear();
            tbxSoTang.Clear();
            tbxSoPhong.Clear();
            tbxViTri.Clear();
            tbxTinhXay.Clear();
            tbxTruongKhuNha.Clear();
            //tbxTienDienNuoc.Clear();
        }

        private void dgvKN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                tbxMaKN.Text = dgvKN.Rows[index].Cells[0].Value.ToString();
                tbxSoTang.Text = dgvKN.Rows[index].Cells[1].Value.ToString();
                tbxSoPhong.Text = dgvKN.Rows[index].Cells[2].Value.ToString();
                tbxViTri.Text = dgvKN.Rows[index].Cells[3].Value.ToString();
                tbxTinhXay.Text = dgvKN.Rows[index].Cells[4].Value.ToString();
                tbxTruongKhuNha.Text = dgvKN.Rows[index].Cells[5].Value.ToString();
                //tbxTienDienNuoc.Text = dgvKN.Rows[index].Cells[6].Value.ToString();
            }
            catch { }
        }

        bool CheckData()
        {
            if (string.IsNullOrEmpty(tbxMaKN.Text))
            {
                MessageBox.Show("Chưa nhập mã khu nhà!", "Thông báo", MessageBoxButtons.OK);
                tbxMaKN.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                KhuNha kn = new KhuNha();
                kn.MaKN = tbxMaKN.Text;               
                kn.ViTri = tbxViTri.Text;
                kn.TinhXay = tbxTinhXay.Text;
                kn.TruongKN = tbxTruongKhuNha.Text;
                try
                {
                    kn.SoTang = int.Parse(tbxSoTang.Text);
                    kn.SoPhong = int.Parse(tbxSoPhong.Text);
                    kn.TienDienNuoc = double.Parse(tbxTienDienNuoc.Text);
                }
                catch { }

                if (BLL.ThemKN(kn))
                    ShowAllKN();
                else
                    MessageBox.Show("Đã xảy ra lỗi! Không thể thêm!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                KhuNha kn = new KhuNha();
                kn.MaKN = tbxMaKN.Text;
                kn.SoTang = int.Parse(tbxSoTang.Text);
                kn.SoPhong = int.Parse(tbxSoPhong.Text);
                kn.ViTri = tbxViTri.Text;
                kn.TinhXay = tbxTinhXay.Text;
                kn.TruongKN = tbxTruongKhuNha.Text;

                if (BLL.SuaKN(kn))
                    ShowAllKN();
                else
                    MessageBox.Show("Đã xảy ra lỗi! Không thể sửa!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                KhuNha kn = new KhuNha();
                kn.MaKN = tbxMaKN.Text;

                if (BLL.XoaKN(kn))
                    ShowAllKN();
                else
                    MessageBox.Show("Đã xảy ra lỗi! Không thể xóa!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            if (BLL.XoaAllKN())
                ShowAllKN();
            else
                MessageBox.Show("Đã xảy ra lỗi! Không thể xóa tất cả!", "Thông báo", MessageBoxButtons.OK);
        }

        private void tbxTim_TextChanged(object sender, EventArgs e)
        {
            string key = tbxTim.Text;

            DataTable datable = BLL.TimKN(key);
            dgvKN.DataSource = datable;
            dgvKN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

                worksheet.Cells[1, 1] = "THÔNG TIN KHU NHÀ";

                worksheet.Cells[3, 2] = "Mã khu nhà: " + tbxMaKN.Text;
                worksheet.Cells[4, 2] = "Số tầng: " + tbxSoTang.Text;
                worksheet.Cells[5, 2] = "Số phòng: " + tbxSoPhong.Text;
                worksheet.Cells[6, 2] = "Vị trí: " + tbxViTri.Text;
                worksheet.Cells[7, 2] = "Tỉnh xây: " + tbxTinhXay.Text;
                worksheet.Cells[8, 2] = "Trưởng khu nhà: " + tbxTruongKhuNha.Text;
                worksheet.Cells[9, 2] = "Tiền điện nước: " + tbxTienDienNuoc.Text;
            }
        }
    }
}
