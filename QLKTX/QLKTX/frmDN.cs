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
    public partial class frmDN : Form
    {
        BusinessLogicLayer BLL;

        public frmDN()
        {
            InitializeComponent();

            BLL = new BusinessLogicLayer();
        }

        bool CheckData()
        {
            if (string.IsNullOrEmpty(tbxTK.Text))
            {
                MessageBox.Show("Chưa nhập tài khoản!", "Thông báo", MessageBoxButtons.OK);
                tbxTK.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbxMK.Text))
            {
                MessageBox.Show("Chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK);
                tbxMK.Focus();
                return false;
            }
            return true;
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                TaiKhoan tk = new TaiKhoan();
                tk.Taikhoan = tbxTK.Text;
                tk.Matkhau = tbxMK.Text;

                if (BLL.CheckTK(tk))
                    MessageBox.Show("success!", "Thông báo", MessageBoxButtons.OK);
                else
                    lblSai.Visible = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
