using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
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

        bool CheckData()
        {
            if (string.IsNullOrEmpty(tbxMaSV.Text))
            {
                MessageBox.Show("Chưa nhập mã sinh viên!", "Thông báo", MessageBoxButtons.OK);
                tbxMaSV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbxTenSV.Text))
            {
                MessageBox.Show("Chưa nhập tên sinh viên!", "Thông báo", MessageBoxButtons.OK);
                tbxTenSV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbxNamsinh.Text))
            {
                MessageBox.Show("Chưa nhập năm sinh sinh viên!", "Thông báo", MessageBoxButtons.OK);
                tbxNamsinh.Focus();
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
                sv.TenSV = tbxTenSV.Text;
                sv.Namsinh = int.Parse(tbxNamsinh.Text);

                if (BLL.ThemSV(sv))
                    ShowAllSV();
                else
                    MessageBox.Show("Đã xảy ra lỗi!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            tbxMaSV.Text = dgvSV.Rows[index].Cells[0].Value.ToString();
            tbxTenSV.Text = dgvSV.Rows[index].Cells[1].Value.ToString();
            tbxNamsinh.Text = dgvSV.Rows[index].Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(CheckData())
            {
                SinhVien sv = new SinhVien();
                sv.MaSV = tbxMaSV.Text;
                sv.TenSV = tbxTenSV.Text;
                sv.Namsinh = int.Parse(tbxNamsinh.Text);

                if (BLL.SuaSV(sv))
                    ShowAllSV();
                else
                    MessageBox.Show("Đã xảy ra lỗi!", "Thông báo", MessageBoxButtons.OK);
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
                    MessageBox.Show("Đã xảy ra lỗi!", "Thông báo", MessageBoxButtons.OK);
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
