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
    public partial class frmThemTK : Form
    {
        BusinessLogicLayer BLL;

        public frmThemTK()
        {
            InitializeComponent();

            BLL = new BusinessLogicLayer();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.Taikhoan = tbxTK.Text;
            tk.Matkhau = tbxMK.Text;

            if (BLL.ThemTK(tk))
            {
                lblThemtktc.Visible = true;
                lblThemtktb.Visible = false;
            }
            else
            {
                lblThemtktc.Visible = false;
                lblThemtktb.Visible = true;
            }
        }
    }
}
