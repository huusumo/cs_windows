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
    public partial class frmQLTK : Form
    {
        BusinessLogicLayer BLL;

        public frmQLTK()
        {
            InitializeComponent();

            BLL = new BusinessLogicLayer();
        }

        private void btnlapdsKN_Click(object sender, EventArgs e)
        {
            lblds.Text = "Danh sách khu nhà:";

            lblTTP.Visible = true;
            tbxTTP.Visible = true;

            tbxMakn.Enabled = true;
            tbxMaphong.Enabled = false;
            tbxMasv.Enabled = false;

            DataTable datable = BLL.GetAllKN();
            dgvTK.DataSource = datable;
            dgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnlapdsP_Click(object sender, EventArgs e)
        {
            lblds.Text = "Danh sách phòng:";

            lblTTP.Visible = true;
            tbxTTP.Visible = true;

            tbxMakn.Enabled = true;
            tbxMaphong.Enabled = true;
            tbxMasv.Enabled = false;

            DataTable datable = BLL.GetAllPhong();
            dgvTK.DataSource = datable;
            dgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnlapdsSV_Click(object sender, EventArgs e)
        {
            lblds.Text = "Danh sách sinh viên:";

            lblTTP.Visible = false;
            tbxTTP.Visible = false;

            tbxMakn.Enabled = false;
            tbxMaphong.Enabled = true;
            tbxMasv.Enabled = true;

            DataTable datable = BLL.GetAllSV();
            dgvTK.DataSource = datable;
            dgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnlapdsSVno_Click(object sender, EventArgs e)
        {
            lblds.Text = "Danh sách sinh viên nợ:";

            lblTTP.Visible = false;
            tbxTTP.Visible = false;

            tbxMakn.Enabled = false;
            tbxMaphong.Enabled = false;
            tbxMasv.Enabled = false;

            DataTable datable = BLL.GetAllSVno();
            dgvTK.DataSource = datable;
            dgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLapdssvmv_Click(object sender, EventArgs e)
        {
            lblds.Text = "Danh sách sinh viên mới vào:";

            lblTTP.Visible = false;
            tbxTTP.Visible = false;

            tbxMakn.Enabled = false;
            tbxMaphong.Enabled = false;
            tbxMasv.Enabled = false;

            DataTable datable = BLL.GetAllSVMoiVao();
            dgvTK.DataSource = datable;
            dgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLapdssvhh_Click(object sender, EventArgs e)
        {
            lblds.Text = "Danh sách sinh viên hết hạn:";

            lblTTP.Visible = false;
            tbxTTP.Visible = false;

            tbxMakn.Enabled = false;
            tbxMaphong.Enabled = false;
            tbxMasv.Enabled = false;

            DataTable datable = BLL.GetAllSVHetHan();
            dgvTK.DataSource = datable;
            dgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnMienGiam_Click(object sender, EventArgs e)
        {
            lblds.Text = "Danh sách sinh viên miễn giảm:";

            lblTTP.Visible = false;
            tbxTTP.Visible = false;

            tbxMakn.Enabled = false;
            tbxMaphong.Enabled = false;
            tbxMasv.Enabled = false;

            DataTable datable = BLL.GetSVMienGiam();
            dgvTK.DataSource = datable;
            dgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (lblds.Text == "Danh sách khu nhà:")
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                app.Visible = true;

                worksheet.Cells[1, 1] = "THÔNG TIN KHU NHÀ";

                worksheet.Cells[3, 2] = "STT";
                worksheet.Cells[3, 3] = "Mã khu nhà";
                worksheet.Cells[3, 4] = "Số tầng";
                worksheet.Cells[3, 5] = "Số phòng";
                worksheet.Cells[3, 6] = "Vị trí";
                worksheet.Cells[3, 7] = "Tỉnh xây";
                worksheet.Cells[3, 8] = "Trưởng khu nhà";

                for (int i = 0; i < dgvTK.RowCount - 1; i++)
                {
                    worksheet.Cells[i + 4, 2] = i + 1;
                    for (int j = 0; j < dgvTK.ColumnCount; j++)
                        worksheet.Cells[i + 4, j + 3] = dgvTK.Rows[i].Cells[j].Value;
                }
            }
            if (lblds.Text == "Danh sách phòng:")
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                app.Visible = true;

                worksheet.Cells[1, 1] = "THÔNG TIN PHÒNG";

                worksheet.Cells[3, 2] = "STT";
                worksheet.Cells[3, 3] = "Mã phòng";
                worksheet.Cells[3, 4] = "Mã khu nhà";
                worksheet.Cells[3, 5] = "Trưởng phòng";
                worksheet.Cells[3, 6] = "Tiền điện nước";
                worksheet.Cells[3, 7] = "Chi tiết";

                for (int i = 0; i < dgvTK.RowCount - 1; i++)
                {
                    worksheet.Cells[i + 4, 2] = i + 1;
                    for (int j = 0; j < dgvTK.ColumnCount; j++)
                        worksheet.Cells[i + 4, j + 3] = dgvTK.Rows[i].Cells[j].Value;
                }
            }
            if (lblds.Text == "Danh sách sinh viên:")
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                app.Visible = true;

                worksheet.Cells[1, 1] = "THÔNG TIN SINH VIÊN";

                worksheet.Cells[3, 2] = "STT";
                worksheet.Cells[3, 3] = "Mã sinh viên";
                worksheet.Cells[3, 4] = "Họ tên";
                worksheet.Cells[3, 5] = "Mã phòng";
                worksheet.Cells[3, 6] = "Ngày sinh";
                worksheet.Cells[3, 7] = "Giới tính";
                worksheet.Cells[3, 8] = "Tình trạng";
                worksheet.Cells[3, 9] = "Miễn giảm";
                worksheet.Cells[3, 10] = "Ngày vào";
                worksheet.Cells[3, 11] = "Đóng tiền";
                worksheet.Cells[3, 12] = "Chức vụ";

                for (int i = 0; i < dgvTK.RowCount - 1; i++)
                {
                    worksheet.Cells[i + 4, 2] = i + 1;
                    for (int j = 0; j < dgvTK.ColumnCount; j++)
                        worksheet.Cells[i + 4, j + 3] = dgvTK.Rows[i].Cells[j].Value;
                }
            }

            if (lblds.Text == "Danh sách sinh viên nợ:")
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                app.Visible = true;

                worksheet.Cells[1, 1] = "THÔNG TIN SINH VIÊN NỢ";

                worksheet.Cells[3, 2] = "STT";
                worksheet.Cells[3, 3] = "Mã sinh viên";
                worksheet.Cells[3, 4] = "Họ tên";
                worksheet.Cells[3, 5] = "Mã phòng";
                worksheet.Cells[3, 6] = "Ngày sinh";
                worksheet.Cells[3, 7] = "Giới tính";
                worksheet.Cells[3, 8] = "Tình trạng";
                worksheet.Cells[3, 9] = "Miễn giảm";
                worksheet.Cells[3, 10] = "Ngày vào";
                worksheet.Cells[3, 11] = "Đóng tiền";
                worksheet.Cells[3, 12] = "Chức vụ";

                for (int i = 0; i < dgvTK.RowCount - 1; i++)
                {
                    worksheet.Cells[i + 4, 2] = i + 1;
                    for (int j = 0; j < dgvTK.ColumnCount; j++)
                        worksheet.Cells[i + 4, j + 3] = dgvTK.Rows[i].Cells[j].Value;
                }
            }

            if (lblds.Text == "Danh sách sinh viên mới vào:")
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                app.Visible = true;

                worksheet.Cells[1, 1] = "THÔNG TIN SINH VIÊN MỚI VÀO";

                worksheet.Cells[3, 2] = "STT";
                worksheet.Cells[3, 3] = "Mã sinh viên";
                worksheet.Cells[3, 4] = "Họ tên";
                worksheet.Cells[3, 5] = "Mã phòng";
                worksheet.Cells[3, 6] = "Ngày sinh";
                worksheet.Cells[3, 7] = "Giới tính";
                worksheet.Cells[3, 8] = "Tình trạng";
                worksheet.Cells[3, 9] = "Miễn giảm";
                worksheet.Cells[3, 10] = "Ngày vào";
                worksheet.Cells[3, 11] = "Đóng tiền";
                worksheet.Cells[3, 12] = "Chức vụ";

                for (int i = 0; i < dgvTK.RowCount - 1; i++)
                {
                    worksheet.Cells[i + 4, 2] = i + 1;
                    for (int j = 0; j < dgvTK.ColumnCount; j++)
                        worksheet.Cells[i + 4, j + 3] = dgvTK.Rows[i].Cells[j].Value;
                }
            }

            if (lblds.Text == "Danh sách sinh viên hết hạn:")
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                app.Visible = true;

                worksheet.Cells[1, 1] = "THÔNG TIN SINH VIÊN HẾT HẠN";

                worksheet.Cells[3, 2] = "STT";
                worksheet.Cells[3, 3] = "Mã sinh viên";
                worksheet.Cells[3, 4] = "Họ tên";
                worksheet.Cells[3, 5] = "Mã phòng";
                worksheet.Cells[3, 6] = "Ngày sinh";
                worksheet.Cells[3, 7] = "Giới tính";
                worksheet.Cells[3, 8] = "Tình trạng";
                worksheet.Cells[3, 9] = "Miễn giảm";
                worksheet.Cells[3, 10] = "Ngày vào";
                worksheet.Cells[3, 11] = "Đóng tiền";
                worksheet.Cells[3, 12] = "Chức vụ";

                for (int i = 0; i < dgvTK.RowCount - 1; i++)
                {
                    worksheet.Cells[i + 4, 2] = i + 1;
                    for (int j = 0; j < dgvTK.ColumnCount; j++)
                        worksheet.Cells[i + 4, j + 3] = dgvTK.Rows[i].Cells[j].Value;
                }
            }

            if (lblds.Text == "Danh sách sinh viên miễn giảm:")
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                app.Visible = true;

                worksheet.Cells[1, 1] = "THÔNG TIN SINH VIÊN MIỄN GIẢM";

                worksheet.Cells[3, 2] = "STT";
                worksheet.Cells[3, 3] = "Mã sinh viên";
                worksheet.Cells[3, 4] = "Họ tên";
                worksheet.Cells[3, 5] = "Mã phòng";
                worksheet.Cells[3, 6] = "Ngày sinh";
                worksheet.Cells[3, 7] = "Giới tính";
                worksheet.Cells[3, 8] = "Tình trạng";
                worksheet.Cells[3, 9] = "Miễn giảm";
                worksheet.Cells[3, 10] = "Ngày vào";
                worksheet.Cells[3, 11] = "Đóng tiền";
                worksheet.Cells[3, 12] = "Chức vụ";

                for (int i = 0; i < dgvTK.RowCount - 1; i++)
                {
                    worksheet.Cells[i + 4, 2] = i + 1;
                    for (int j = 0; j < dgvTK.ColumnCount; j++)
                        worksheet.Cells[i + 4, j + 3] = dgvTK.Rows[i].Cells[j].Value;
                }
            }
        }

        private void tbxMakn_TextChanged(object sender, EventArgs e)
        {
            string key = tbxMakn.Text;

            if (lblds.Text == "Danh sách khu nhà:")
            {
                DataTable datable = BLL.TimKN(key);
                dgvTK.DataSource = datable;
                dgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            if (lblds.Text == "Danh sách phòng:")
            {
                DataTable datable = BLL.TimPhongtheoKN(key);
                dgvTK.DataSource = datable;
                dgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void tbxMaphong_TextChanged(object sender, EventArgs e)
        {
            string key = tbxMaphong.Text;

            if (lblds.Text == "Danh sách phòng:")
            {
                DataTable datable = BLL.TimPhong(key);
                dgvTK.DataSource = datable;
                dgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            if (lblds.Text == "Danh sách sinh viên:")
            {
                DataTable datable = BLL.TimSVtheoP(key);
                dgvTK.DataSource = datable;
                dgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void tbxMasv_TextChanged(object sender, EventArgs e)
        {
            string key = tbxMasv.Text;

            DataTable datable = BLL.TimSV(key);
            dgvTK.DataSource = datable;
            dgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                if (lblds.Text == "Danh sách khu nhà:")
                {
                    string key = dgvTK.Rows[index].Cells[0].Value.ToString();

                    DataTable datable = BLL.TongTienPhong(key);
                    tbxTTP.Text = datable.Rows[0].ItemArray[0].ToString();
                }
                if (lblds.Text == "Danh sách phòng:")
                    tbxTTP.Text = dgvTK.Rows[index].Cells[3].Value.ToString();
            }
            catch { }           
        }       
    }
}
