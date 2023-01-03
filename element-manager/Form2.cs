using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace element_manager
{
    public partial class Form2 : Form
    {
        public static readonly Form1 Login = new Form1();
        public static readonly Form2 SignUp = new Form2();

        public Form2()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
