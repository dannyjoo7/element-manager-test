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
        public SearchElement()
        {
            InitializeComponent();
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
    }
}
