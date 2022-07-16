namespace FirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String firstName = tbFirtsName.Text;
            String lastName = tbLastName.Text;
            lbWelcome.Text = "Hello" + firstName + " " + lastName;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFirtsName.Text = "";
            tbLastName.Text = "";
            lbWelcome.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "";
        }
    }
}