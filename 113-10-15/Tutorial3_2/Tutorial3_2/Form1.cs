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
            double kms;
            double liters;
            double average;

            kms = double.Parse(txbKm.Text);
            liters = double.Parse(txbliter.Text);
            average = kms / liters;


            lblshow.Text = (kms/liters).ToString("n3");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
