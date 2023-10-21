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
    public partial class frmAdmin : Form
    {
        bool sidebarExpand = false;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == false)
            {
                //      iconLogo.Visible = false;
                sidebarMenu.Width -= 10;
                if (sidebarMenu.Width <= sidebarMenu.MinimumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
            else if (sidebarExpand == true)
            {
                //     iconLogo.Visible = true;
                sidebarMenu.Width += 10;
                if (sidebarMenu.Width >= sidebarMenu.MaximumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            sidebarTimer.Start();
        }
        bool close = false;
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure?", "Exit Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                close = true;
                this.Hide();
                this.Close();
            }
            else
            {
                close = false;
            }

        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close == false)
            {
                close = true;
                DialogResult result;
                result = MessageBox.Show("Are you sure?", "Exit Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) { Application.Exit(); }
                else { e.Cancel = true; close = false; }
            }

        }

    }
}
