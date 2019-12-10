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
    public partial class frmQLKTX : Form
    {
        public frmQLKTX()
        {
            InitializeComponent();
        }

        private void btnQLTT_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLTT QLTT = new frmQLTT();
            QLTT.Show();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDN DN = new frmDN();
            DN.Show();
        }

        private void frmQLKTX_Load(object sender, EventArgs e)
        {
            lblTK.Text = "Tài khoản: " + this.Tag.ToString();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMK DoiMK = new frmDoiMK();
            DoiMK.Tag = this.Tag;
            DoiMK.Show();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            frmThemTK ThemTK = new frmThemTK();
            ThemTK.Show();
        }
    }
}
