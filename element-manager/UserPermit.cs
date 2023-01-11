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
    public partial class UserPermit : Form
    {
        public UserPermit()
        {
            InitializeComponent();
            populateItems();
        }

        public void populateItems()
        {
            UserList[] UserLists = new UserList[20];
            for (int i=0; i<UserLists.Length; i++)
            {
                UserLists[i] = new UserList();
                // to-do
                //if (flowLayoutPanel1.Controls.Count > 0)
                //{
                //    flowLayoutPanel1.Controls.Clear();
                //}
                //else
                flowLayoutPanel1.Controls.Add(UserLists[i]);
            }
        }
    }
}