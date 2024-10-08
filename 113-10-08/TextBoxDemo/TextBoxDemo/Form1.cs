namespace TextBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            string fullName;
            string firstName;
            string lastName;

            firstName = text.Text;
            lastName = txtLastName.Text;
            fullName = label4.Text;

            lblShow.Text = firstName;
        }
    }
}
