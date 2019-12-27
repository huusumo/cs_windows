using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ktra
{
    public partial class Form1 : Form
    {
        int LanNhap = 0;

        struct PointNum
        {
            public Point p;
            public int stt;
        }

        public Form1()
        {
            InitializeComponent();
        }

        ArrayList arr = new ArrayList();

        System.Random rand = new Random();

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            //button4.Location = new Point(50, 55);

            Brush br1 = new LinearGradientBrush(new Point(0, 0), new Point(50, 50), Color.Red, Color.Yellow);
            Pen p1 = new Pen(br1, 20);
            p1.Alignment = PenAlignment.Inset;
            Rectangle rectClient = this.ClientRectangle;
            g.DrawRectangle(p1, rectClient);

            Brush br2 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.LightSkyBlue, Color.DarkBlue);
            Pen p2 = new Pen(br2, 20);
            p2.Alignment = PenAlignment.Center;
            //g.DrawLine(p2, 0, 0, rectClient.Width / 2, rectClient.Height / 2);
            //g.DrawLine(p2, rectClient.Width / 2, rectClient.Height / 2, rectClient.Width, 0);
            //g.FillEllipse(new SolidBrush(Color.DarkBlue), 50, 50, 50, 50);

            //Point[] ps = { new Point(rectClient.Width / 2, 0),
            //    new Point(0, rectClient.Height / 2),
            //    new Point(rectClient.Width / 2, rectClient.Height),
            //    new Point(rectClient.Width, rectClient.Height / 2 )};
            //g.DrawPolygon(p2, ps);

            foreach (PointNum pn in arr)
            {
                g.DrawEllipse(Pens.Black, pn.p.X - 8, pn.p.Y - 8, 16, 16);
                g.DrawString(pn.stt.ToString(), Font, Brushes.Black, pn.p.X - 10, pn.p.Y - 8);
            }
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen p = new Pen(Color.Orchid, 10);
            p.Alignment = PenAlignment.Center;

            g.DrawLine(p, 0, 0, button1.Width, button1.Height);
            g.DrawLine(p, 0, button1.Height, button1.Width, 0);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            LanNhap++;

            PointNum pn;
            pn.p = e.Location;
            pn.stt = LanNhap;

            Graphics g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.DrawEllipse(Pens.Black, e.X - 8, e.Y - 8, 16, 16);
            g.DrawString(pn.stt.ToString(), Font, Brushes.Black, e.X-6, e.Y-7);

            //Point[] ps = {new Point(e.X,e.Y-8),
            //                new Point(e.X-8,e.Y),
            //                new Point(e.X,e.Y+8),
            //                new Point(e.X+8,e.Y)};

            //g.FillPolygon(Brushes.Red, ps);

            //g.FillEllipse(Brushes.DarkBlue, e.X - 8, e.Y - 8, 16, 16);

            arr.Add(pn);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Location = new Point(rand.Next(this.ClientSize.Width - button4.Width), rand.Next(this.ClientSize.Height - button4.Height));
        }

        ArrayList arr3 = new ArrayList();
        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            LanNhap++;

            PointNum pn;
            pn.p = e.Location;
            pn.stt = LanNhap;

            arr3.Add(pn);
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen pp = new Pen(Color.Maroon, 10);
            pp.Alignment = PenAlignment.Inset;
            Rectangle rectClient = button3.ClientRectangle;
            g.DrawRectangle(pp, rectClient);

            foreach (PointNum pn in arr3)
            {
                g.DrawEllipse(Pens.Black, pn.p.X - 8, pn.p.Y - 8, 16, 16);
                g.DrawString(pn.stt.ToString(), Font, Brushes.Black, pn.p.X - 10, pn.p.Y - 8);
            }
        }

        ArrayList arr2 = new ArrayList();
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            LanNhap++;

            PointNum pn;
            pn.p = e.Location;
            pn.stt = LanNhap;

            arr2.Add(pn);
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            foreach (PointNum pn in arr2)
            {
                g.DrawEllipse(Pens.Black, pn.p.X - 8, pn.p.Y - 8, 16, 16);
                g.DrawString(pn.stt.ToString(), Font, Brushes.Black, pn.p.X - 10, pn.p.Y - 8);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Location.X == 71 && button1.Location.Y == 183)
                button1.Location = new Point(button4.Location.X, button4.Location.Y - button4.Height);
            else
                button1.Location = new Point(71, 183);
        }
    }
}
