namespace element_manager
{
    public partial class Form1 : Form
    {
        public static readonly Form1 Login = new Form1();
        public static readonly Form2 SignUp = new Form2();
        public static readonly Form3 Main = new Form3();

        public Form1()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minButton_Click(object sender, EventArgs e)
        {

        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Main.Show();
            this.Hide();
        }
    }
}