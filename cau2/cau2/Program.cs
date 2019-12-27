using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace cau2
{
    class Program : Form
    {
        Random rand;
        bool isDash;
        Timer timer;

        public Program()
        {
            this.Size = new Size(300, 250);

            isDash = false;

            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            rand = new Random();

            base.OnPaint(e);

            Pen solidPen = new Pen(Color.Blue, 5);
            solidPen.DashStyle = DashStyle.Solid;

            Pen dashPen = new Pen(Color.Blue, 5);
            dashPen.DashStyle = DashStyle.Dot;

            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                if (isDash)
                    g.DrawEllipse(dashPen, rand.Next(this.ClientRectangle.Width - 35), rand.Next(this.ClientRectangle.Height - 35), 30, 30);
                else
                    g.DrawEllipse(solidPen, rand.Next(this.ClientRectangle.Width - 35), rand.Next(this.ClientRectangle.Height - 35), 30, 30);
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            this.isDash = !this.isDash;

            Invalidate();
        }

        static void Main()
        {
            Application.Run(new Program());
        }
    }
}
