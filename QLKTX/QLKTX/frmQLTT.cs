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
    public partial class frmQLTT : Form
    {
        public frmQLTT()
        {
            InitializeComponent();
        }

        private void btnQLKN_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLKN QLKN = new frmQLKN();
            QLKN.Show();
        }

        private void btnQLP_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLP QLP = new frmQLP();
            QLP.Show();
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLSV QLSV = new frmQLSV();
            QLSV.Show();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            //frmQLKTX QLKTX = new frmQLKTX();
            //QLKTX.Show();
        }
    }
}
