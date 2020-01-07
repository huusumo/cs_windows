using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau5
{
    public partial class Form1 : Form
    {
        int l1;
        int l2;
        int l3;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point p1 = new Point(150, 160);
            Point p2 = new Point(p1.X + 100, 160);
            Point p3 = new Point(p2.X + 100, 160);
            Point p4 = new Point(p3.X + 100, 160);
            Point p5 = new Point(p4.X + 100, 160);
            Point p6 = new Point(p5.X + 100, 160);

            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                g.FillEllipse(Brushes.Red, p1.X - 2, p1.Y - 3, 5, 5);
                g.DrawLine(Pens.Red, p1, p2);
                g.FillEllipse(Brushes.Red, p2.X - 2, p2.Y - 3, 5, 5);
                g.DrawLine(Pens.Red, p2, p3);
                g.FillEllipse(Brushes.Red, p3.X - 2, p3.Y - 3, 5, 5);
                g.DrawLine(Pens.Red, p3, p4);
                g.FillEllipse(Brushes.Red, p4.X - 2, p4.Y - 3, 5, 5);
                g.DrawLine(Pens.Red, p4, p5);
                g.FillEllipse(Brushes.Red, p5.X - 2, p5.Y - 3, 5, 5);
                g.DrawLine(Pens.Red, p5, p6);
                g.FillEllipse(Brushes.Red, p6.X - 2, p6.Y - 3, 5, 5);

                g.DrawString("0", Font, Brushes.Red, p1.X - 5, p1.Y + 5);
                g.DrawString("100", Font, Brushes.Red, p2.X - 13, p2.Y + 5);
                g.DrawString("200", Font, Brushes.Red, p3.X - 13, p3.Y + 5);
                g.DrawString("300", Font, Brushes.Red, p4.X - 13, p4.Y + 5);
                g.DrawString("400", Font, Brushes.Red, p5.X - 13, p5.Y + 5);
                g.DrawString("500", Font, Brushes.Red, p6.X - 13, p6.Y + 5);

                g.FillRectangle(Brushes.Red, p1.X, textBox1.Location.Y, l1, textBox1.Size.Height);
                g.FillRectangle(Brushes.Red, p1.X, textBox2.Location.Y, l2, textBox1.Size.Height);
                g.FillRectangle(Brushes.Red, p1.X, textBox3.Location.Y, l3, textBox1.Size.Height);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                l1 = int.Parse(textBox1.Text);
                if (l1 <= 0 || l1 > 500)
                {
                    textBox1.Clear();
                }
            }
            catch
            {
                textBox1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                l2 = int.Parse(textBox2.Text);
                if (l2 <= 0 || l2 > 500)
                {
                    textBox2.Clear();
                }
            }
            catch
            {
                textBox2.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                l3 = int.Parse(textBox3.Text);
                if (l3 <= 0 || l3 > 500)
                {
                    textBox3.Clear();
                }
            }
            catch
            {
                textBox3.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            l1 = 0;
            l2 = 0;
            l3 = 0;

            Invalidate();
        }
    }
}
