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
    }
}
