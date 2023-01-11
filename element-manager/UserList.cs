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
    public partial class UserList : UserControl
    {
        public UserList()
        {
            InitializeComponent();
        }

        #region Properties
        private string _username;
        private string _company;
        private Image _pic;

        [Category("Custom props")]
        public string Username
        {
            get { return _username; }
            set { _username = value; lblName.Text = value; }
        }

        [Category("Custom props")]
        public string Company
        {
            get { return _company; }
            set { _company = value; lblCompany.Text = value; }
        }

        [Category("Custom props")]
        public Image Pic
        {
            get { return _pic; }
            set { _pic = value; picture.Image = value; }
        }

        #endregion


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
