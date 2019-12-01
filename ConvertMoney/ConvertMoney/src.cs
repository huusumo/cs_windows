using System;
using System.Windows.Forms;
using System.Drawing;

class ConvertMoney : Form
{
    #region Properties

    Label lbl1;
    Label lbl2;
    Label lbl3;

    TextBox tbx1;
    ComboBox cbx2;
    TextBox tbx3;

    Button btn;

    #endregion

    #region Initialize

    public ConvertMoney()
    {
        Text = "Đổi ngoại tệ";
        FormClosing += form_Closing;

        // Label
        lbl1 = new Label();
        lbl1.Parent = this;
        lbl1.Text = "VN Đồng:";
        lbl1.Location = new Point(20, 30 );

        lbl2 = new Label();
        lbl2.Parent = this;
        lbl2.Text = "Loại ngoại tệ:";
        lbl2.Location = new Point(20, 90);

        lbl3 = new Label();
        lbl3.Parent = this;
        lbl3.Text = "Ngoại tệ:";
        lbl3.Location = new Point(20, 150);

        // Box
        tbx1 = new TextBox();
        tbx1.Parent = this;
        tbx1.Location = new Point(130, 30);
        tbx1.Size = new Size(130, 0);
        tbx1.TextChanged += bx12_Changed;

        cbx2 = new ComboBox();
        cbx2.Parent = this;
        cbx2.Location = new Point(130, 90);
        cbx2.Size = new Size(130, 0);
        cbx2.Items.Add("US Dollar");
        cbx2.Items.Add("Euro");
        cbx2.Items.Add("Japan Yen");
        cbx2.SelectedIndexChanged += bx12_Changed;

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
        Application.Run(new ConvertMoney());
    }

    void btn_Click(object sender, EventArgs e)
    {
        tbx1.Clear();
        cbx2.Text = "";
        tbx3.Clear();
    }

    void bx12_Changed(object sender, EventArgs e)
    {
        double vnd = 0;
        string TypeMoney;

        try
        {
            vnd = double.Parse(tbx1.Text);
        }
        catch
        {
            tbx1.Clear();
        }

        TypeMoney = cbx2.Text;
        if (TypeMoney == "US Dollar")
            tbx3.Text = Convert.ToString(Math.Round(vnd / 19000, 2, MidpointRounding.AwayFromZero));
        if (TypeMoney == "Euro")
            tbx3.Text = Convert.ToString(Math.Round(vnd / 23500, 2, MidpointRounding.AwayFromZero));
        if (TypeMoney == "Japan Yen")
            tbx3.Text = Convert.ToString(Math.Round(vnd / 200, 2, MidpointRounding.AwayFromZero));
    }

    void form_Closing(object sender, FormClosingEventArgs e)
    {
        if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            e.Cancel = true;
    }

    #endregion
}
