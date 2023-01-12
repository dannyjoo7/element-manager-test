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
    public partial class Search : Form
    {
        public Main main;

        public Search()
        {
            InitializeComponent();
            comboSearch.SelectedIndex = 0;
        }

        public Search(Main main)
        {
            InitializeComponent();
            this.main = main;
            populateItems();
            comboSearch.SelectedIndex = 0;
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textUpdateName_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void populateItems()
        {
            SearchElement[] elementList;

            try
            {
                //DB연결 정보
                string myConnection = "Server = 127.0.0.1; Port=3306; Database=pbl; Uid=root; Pwd=1234;";
                //연결문 선언
                MySqlConnection myConn = new MySqlConnection(myConnection);

                myConn.Open();
                string sql = "select * from element order by ele_id;";

                MySqlCommand cmd = new MySqlCommand(sql, myConn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    //
                    count = count + 1;
                }
                elementList = new SearchElement[count];
                for (int i = 0; i < count; i++)
                {
                    int j = i + 1;
                    elementList[i] = new SearchElement();
                    elementList[i].main = main;
                    elementList[i].getele(j);
                    elementList[i].eid = i;
                    searchPanel.Controls.Add(elementList[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
