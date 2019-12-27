using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau1
{
    public partial class Form1 : Form
    {
        bool isDash = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen dashPen = new Pen(Brushes.Brown, 35);
            dashPen.DashStyle = DashStyle.Dash;

            Pen solidPen = new Pen(Brushes.Brown, 35);
            solidPen.DashStyle = DashStyle.Solid;

            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                if (isDash)
                {
                    g.DrawRectangle(dashPen, this.ClientRectangle);
                    this.Text = "DASH LINE RECTANGLE";
                }
                else
                {
                    g.DrawRectangle(solidPen, this.ClientRectangle);
                    this.Text = "SOLID LINE RECTANGLE";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            isDash = !isDash;
            Invalidate();
        }
    }
}
