using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace element_manager
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void minButton_Click(object sender, EventArgs e)
        {

        }

        private void maxButton_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void SignUp_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Search_Ib_Click(object sender, EventArgs e)
        {
            Search_Btn.BackColor= Color.White;
            SearchCategory_Btn.BackColor = Color.DarkGray;
            UesrMod_Btn.BackColor = Color.DarkGray;
            Setting_Btn.BackColor = Color.DarkGray;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UesrMod_Btn_Click(object sender, EventArgs e)
        {
            Search_Btn.BackColor = Color.DarkGray;
            SearchCategory_Btn.BackColor = Color.DarkGray;
            UesrMod_Btn.BackColor = Color.White;
            Setting_Btn.BackColor = Color.DarkGray;
        }

        private void SearchCategory_Btn_Click(object sender, EventArgs e)
        {
            Search_Btn.BackColor = Color.DarkGray;
            SearchCategory_Btn.BackColor = Color.White;
            UesrMod_Btn.BackColor = Color.DarkGray;
            Setting_Btn.BackColor = Color.DarkGray;
        }

        private void Setting_Btn_Click(object sender, EventArgs e)
        {
            Search_Btn.BackColor = Color.DarkGray;
            SearchCategory_Btn.BackColor = Color.DarkGray;
            UesrMod_Btn.BackColor = Color.DarkGray;
            Setting_Btn.BackColor = Color.White;
        }

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            contactUs contactUs = new contactUs();
            contactUs.ShowDialog();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
 
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void SignUplabel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
