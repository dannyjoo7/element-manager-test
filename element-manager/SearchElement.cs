using MySql.Data.MySqlClient;
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
    public partial class SearchElement : UserControl
    {
        public Main main;
        public int eid = 1; // element ID
        
        public SearchElement()
        {
            InitializeComponent();
        }

        public void getele(int i)
        {
            try
            {
                string myConnection = "Server = 127.0.0.1; Port=3306; Database=pbl; Uid=root; Pwd=1234;";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                myConn.Open();
                string sql = "select * from element where ele_id = " + i + ";";
                MySqlCommand cmd = new MySqlCommand(sql, myConn);
                MySqlDataReader table = cmd.ExecuteReader();

                while (table.Read())
                {
                    string? ele_name = table["ele_name"].ToString();
                    lblName.Text = ele_name;

                    string? ele_intro = table["ele_exp"].ToString();
                    lblDescription.Text = ele_intro;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Properties
        private string _name;
        private string _description;
        private Image _picture;

        public string Name
        {
            get { return _name; }
            set { _name = value; lblName.Text = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; lblDescription.Text = value; }
        }

        public Image Picture
        {
            get { return _picture; }
            set { _picture = value; pic.Image = value; }
        }

        #endregion

        private void lblName_Click(object sender, EventArgs e)
        {
            main.viewElement(eid);
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void lblTag_Click(object sender, EventArgs e)
        {

        }
    }
}
