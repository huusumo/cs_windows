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

namespace cau4
{
    public partial class Form1 : Form
    {
        Timer timer;

        Button btn;
        bool isQuay;

        public Form1()
        {
            InitializeComponent();

            this.ClientSize = new Size(300, 300);

            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();

            btn = new Button();
            btn.Parent = this;            
            btn.Click += btn_Click;
            isQuay = true;
        }

        int startAngle = 10;
        int sweepAngle = 20;
        int Quay = 0;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (isQuay)
                btn.Text = "Stop";
            else
                btn.Text = "Quay";

            if (isQuay)
                startAngle += Quay;

            int xC = this.ClientSize.Width / 2;
            int yC = this.ClientSize.Height / 2;

            int CanhQuat = this.ClientSize.Width / 4;
            int rQuat = CanhQuat + 12;

            Rectangle rectOut = new Rectangle(xC - rQuat, yC - rQuat, rQuat * 2, rQuat * 2);
            Rectangle rectIn = new Rectangle(xC - CanhQuat, yC - CanhQuat, CanhQuat * 2, CanhQuat * 2);

            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Pen pen = new Pen(Color.Black, 3);
                g.DrawEllipse(pen, rectOut);

                Brush brush = new SolidBrush(Color.BlueViolet);

                g.FillPie(brush, rectIn, startAngle, sweepAngle);

                startAngle += 72;
                g.FillPie(brush, rectIn, startAngle, sweepAngle);

                startAngle += 72;
                g.FillPie(brush, rectIn, startAngle, sweepAngle);

                startAngle += 72;
                g.FillPie(brush, rectIn, startAngle, sweepAngle);

                startAngle += 72;
                g.FillPie(brush, rectIn, startAngle, sweepAngle);
            }
        }

        void Timer_Tick(object sender,EventArgs e)
        {
            Quay += 20;

            Invalidate();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }

        void btn_Click(object sender,EventArgs e)
        {
            this.isQuay = !isQuay;

            if (isQuay)
                timer.Start();
            else
                timer.Stop();

            Invalidate();
        }
    }
}
