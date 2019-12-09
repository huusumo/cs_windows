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
                lblTK.Visible = true;
                lblMK.Visible = false;
                lblSai.Visible = false;
                tbxTK.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbxMK.Text))
            {
                lblTK.Visible = false;
                lblMK.Visible = true;
                lblSai.Visible = false;
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
                {
                    this.Hide();
                    frmQLKTX QLKTX = new frmQLKTX();
                    QLKTX.Show();
                }
                else
                {
                    lblTK.Visible = false;
                    lblMK.Visible = false;
                    lblSai.Visible = true;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chbxMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxMK.Checked)
                tbxMK.UseSystemPasswordChar = false;
            else
                tbxMK.UseSystemPasswordChar = true;
        }
    }
}
