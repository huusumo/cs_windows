using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
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
            dgvQLSV.DataSource = datable;
            
        }

        private void frmQLSV_Load(object sender, EventArgs e)
        {
            ShowAllSV();
        }
    }
}
