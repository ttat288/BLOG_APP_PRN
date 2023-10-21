using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_PRN_Team
{
    public partial class frmNewBlog : Form
    {
        public frmNewBlog()
        {
            InitializeComponent();
        }

        private void txtContent_Enter(object sender, EventArgs e)
        {
            if (txtContent.Text == "Enter Content Here")
            {
                txtContent.Text = "";
            }
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            if (txtTitle.Text == "Enter Title Here")
            {
                txtTitle.Text = "";
            }
        }
    }
}
