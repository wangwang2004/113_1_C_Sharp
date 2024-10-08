namespace tutonial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnShowBack_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = true;
            ptxForm.Visible = false;
        }

        private void ptxForm_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = false;
            ptxForm.Visible = true;

        }
    }
}
