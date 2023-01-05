using FontAwesome.Sharp;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace element_manager
{
    public partial class Main : Form
    {
        public static readonly UserUpdate Uesrupdate = new UserUpdate();
        public static readonly Search Search = new Search();
        public static readonly AddTag AddTag = new AddTag();
        

        public Main()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadForm(Uesrupdate);
            loadForm(Search);
            loadForm(AddTag);
            
        }

        //창 조절
        private void minButton_Click(object sender, EventArgs e)
        {

        }

        private void maxButton_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUp_Btn_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Search_Ib_Click(object sender, EventArgs e)
        {
            //검색 버튼
            changeColorBtnBackground(Search_Btn);
            changeForm(Search);
        }

        private void UesrMod_Btn_Click(object sender, EventArgs e)
        {
            //유저 정보 수정 버튼
            changeColorBtnBackground(UesrMod_Btn);
            changeForm(Uesrupdate);
        }

        private void SearchCategory_Btn_Click(object sender, EventArgs e)
        {
            changeColorBtnBackground(SearchCategory_Btn);
        }

        private void Setting_Btn_Click(object sender, EventArgs e)
        {
            changeColorBtnBackground(Setting_Btn);
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            changeColorBtnBackground(btnAddTag);
            changeForm(AddTag);
        }

        private void btnPermit_Click(object sender, EventArgs e)
        {
            changeColorBtnBackground(btnPermit);
        }

        private void panelInf_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //창 위치 변경
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

        

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            contactUs contactUs = new contactUs();
            contactUs.ShowDialog();
        }

        private void changeColorBtnBackground(IconButton obj)
        {
            List<IconButton> listBtn = new List<IconButton>();

            listBtn.Add(Search_Btn);
            listBtn.Add(SearchCategory_Btn);
            listBtn.Add(UesrMod_Btn);
            listBtn.Add(Setting_Btn);
            listBtn.Add(btnPermit);
            listBtn.Add(btnAddTag);

            for (int i = 0; i < listBtn.Count; i++)
            {
                listBtn[i].BackColor = Color.DarkGray;
            }
            obj.BackColor = Color.White;
        }

        private void changeForm(Form form)
        {
            List<Form> listForm = new List<Form>();
            listForm.Add(AddTag);
            listForm.Add(Uesrupdate);
            listForm.Add(Search);

            for (int i = 0; i < listForm.Count; i++)
            {
                listForm[i].Hide();
                panelInf.Controls.Remove(listForm[i]);
            }

            panelInf.Controls.Add(form);
            form.Show();
        }

        private void loadForm(Form form)
        {
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
        }

    }
}
