using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class Star : Form
{
    Rectangle rec;
    Point[] triangle1;
    Point[] triangle2;
    Point[] triangle3;
    Point[] triangle4;

    public Star()
    {
        this.Size = new Size(300, 300);

        rec = new Rectangle(this.ClientRectangle.Width / 2 - this.ClientRectangle.Width / 8, this.ClientRectangle.Height / 2 - this.ClientRectangle.Height / 8, this.ClientRectangle.Width / 4, this.ClientRectangle.Height / 4);
        triangle1 = new Point[3] { new Point(this.ClientRectangle.Width / 2, 0),
                    new Point(this.ClientRectangle.Width / 2 - this.ClientRectangle.Width / 8, this.ClientRectangle.Height / 2 - this.ClientRectangle.Height / 8),
                    new Point(this.ClientRectangle.Width / 2 + this.ClientRectangle.Width / 8, this.ClientRectangle.Height / 2 - this.ClientRectangle.Height / 8) };
        triangle2 = new Point[3] { new Point(0, this.ClientRectangle.Height / 2),
                    new Point(this.ClientRectangle.Width / 2 - this.ClientRectangle.Width / 8, this.ClientRectangle.Height / 2 + this.ClientRectangle.Height / 8),
                    new Point(this.ClientRectangle.Width / 2 - this.ClientRectangle.Width / 8, this.ClientRectangle.Height / 2 - this.ClientRectangle.Height / 8) };
        triangle3 = new Point[3] { new Point(this.ClientRectangle.Width / 2, this.ClientRectangle.Height),
                    new Point(this.ClientRectangle.Width / 2 - this.ClientRectangle.Width / 8, this.ClientRectangle.Height / 2 + this.ClientRectangle.Height / 8),
                    new Point(this.ClientRectangle.Width / 2 + this.ClientRectangle.Width / 8, this.ClientRectangle.Height / 2 + this.ClientRectangle.Height / 8) };
        triangle4 = new Point[3] { new Point(this.ClientRectangle.Width, this.ClientRectangle.Height / 2),
                    new Point(this.ClientRectangle.Width / 2 + this.ClientRectangle.Width / 8, this.ClientRectangle.Height / 2 - this.ClientRectangle.Height / 8),
                    new Point(this.ClientRectangle.Width / 2 + this.ClientRectangle.Width / 8, this.ClientRectangle.Height / 2 + this.ClientRectangle.Height / 8) };
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (Graphics g = e.Graphics)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.FillRectangle(Brushes.Red, rec);
            g.FillPolygon(Brushes.Red, triangle1);
            g.FillPolygon(Brushes.Red, triangle2);
            g.FillPolygon(Brushes.Red, triangle3);
            g.FillPolygon(Brushes.Red, triangle4);
        }
    }

    static void Main()
    {
        Application.Run(new Star());
    }
}