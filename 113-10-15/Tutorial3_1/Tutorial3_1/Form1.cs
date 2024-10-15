namespace Tutorial3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnshowDate_Click(object sender, EventArgs e)
        {
            string output;
            output = "國民" + txtyear.Text + "年" + txtMonth.Text + "月" + txtDate.Text + "日" + "星期" + txtDayOFweek.Text;

            lblshow.Text = output;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtDayOFweek.Text = "";
            txtDate.Text = "";
            txtMonth.Text = "";
            txtyear.Text = "";
            lblshow.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
