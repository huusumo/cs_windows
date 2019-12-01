using System;
using System.Windows.Forms;
using System.Drawing;

class CaculateFuel : Form
{
    #region Properties

    Label lbl1;
    Label lbl2;
    Label lbl3;

    TextBox tbx1;
    ListBox lbx2;
    TextBox tbx3;

    Button btn;

    #endregion

    #region Initialize

    public CaculateFuel()
    {
        Text = "Tính nhiên liệu";

        // Label
        lbl1 = new Label();
        lbl1.Parent = this;
        lbl1.Text = "Tiền nhiên liệu:";
        lbl1.Location = new Point(20, 30);

        lbl2 = new Label();
        lbl2.Parent = this;
        lbl2.Text = "Loại nhiên liệu:";
        lbl2.Location = new Point(20, 70);

        lbl3 = new Label();
        lbl3.Parent = this;
        lbl3.Text = "Số lít:";
        lbl3.Location = new Point(20, 150);

        // Box
        tbx1 = new TextBox();
        tbx1.Parent = this;
        tbx1.Location = new Point(130, 30);
        tbx1.Size = new Size(130, 0);
        tbx1.TextChanged += bx12_Changed;

        lbx2 = new ListBox();
        lbx2.Parent = this;
        lbx2.Location = new Point(130, 70);
        lbx2.Size = new Size(130, 60);
        lbx2.Items.Add("Xăng");
        lbx2.Items.Add("Dầu");
        lbx2.Items.Add("Nhớt");
        lbx2.SelectedIndexChanged += bx12_Changed;

        tbx3 = new TextBox();
        tbx3.Parent = this;
        tbx3.Location = new Point(130, 150);
        tbx3.Size = new Size(130, 0);
        tbx3.Enabled = false;

        // Button
        btn = new Button();
        btn.Parent = this;
        btn.Text = "Xóa";
        btn.Location = new Point(105, 210);
        btn.Click += btn_Click;
    }

    #endregion

    #region Methods

    static void Main()
    {
        Application.Run(new CaculateFuel());
    }

    void btn_Click(object sender, EventArgs e)
    {
        tbx1.Clear();
        lbx2.ClearSelected();
        tbx3.Clear();
    }

    void bx12_Changed(object sender, EventArgs e)
    {
        double money = 0;
        string Type;

        try
        {
            money = double.Parse(tbx1.Text);
        }
        catch
        {
            tbx1.Clear();
        }

        Type = lbx2.Text;
        if (Type == "Xăng")
            tbx3.Text = Convert.ToString(Math.Round(money / 16000, 2, MidpointRounding.AwayFromZero));
        if (Type == "Dầu")
            tbx3.Text = Convert.ToString(Math.Round(money / 14000, 2, MidpointRounding.AwayFromZero));
        if (Type == "Nhớt")
            tbx3.Text = Convert.ToString(Math.Round(money / 35000, 2, MidpointRounding.AwayFromZero));
    }
    
    #endregion
}
