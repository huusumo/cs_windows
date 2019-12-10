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
    public partial class frmDoiMK : Form
    {
        BusinessLogicLayer BLL;

        public frmDoiMK()
        {
            InitializeComponent();

            BLL = new BusinessLogicLayer();
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.Taikhoan = this.Tag.ToString();
            tk.Matkhau = tbxDoiMK.Text;

            if (BLL.DoiMK(tk))
            {
                lblDoimktc.Visible = true;
                lblDoimktb.Visible = false;
            }
            else
            {
                lblDoimktc.Visible = false;
                lblDoimktb.Visible = true;
            }
                
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {
            lblTKdoi.Text = "Tài khoản: " + this.Tag.ToString();
        }
    }
}
