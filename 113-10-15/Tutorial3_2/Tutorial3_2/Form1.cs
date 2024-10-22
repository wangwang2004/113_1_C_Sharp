namespace Tutorial3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kms;
            int liters;
            int average;

            kms = int.Parse(txbKm.Text);
            liters = int.Parse(txbliter.Text);
            average = kms / liters;


            lblshow.Text = ((double)kms/liters).ToString("n3");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
