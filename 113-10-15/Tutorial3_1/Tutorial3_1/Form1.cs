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
            output = "���" + txtyear.Text + "�~" + txtMonth.Text + "��" + txtDate.Text + "��" + "�P��" + txtDayOFweek.Text;

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
