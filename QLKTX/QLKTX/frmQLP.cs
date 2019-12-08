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
                phg.TienDienNuoc = double.Parse(tbxTienDienNuoc.Text);
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
    }
}
