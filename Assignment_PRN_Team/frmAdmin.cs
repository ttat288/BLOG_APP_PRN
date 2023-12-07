using BlogWinApp;
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
        public frmAdmin()
        {
            InitializeComponent();

        }

        private void btnListAccount_Click(object sender, EventArgs e)
        {
            resetBtn();
            btnListAccount.BackColor = Color.DarkTurquoise;
            frmAccount frm = new frmAccount();
            openChildForm(frm);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != childForm)
            {
                if (activeForm != null)
                {

                    activeForm.Hide();
                }
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelUC.Controls.Add(childForm);
                panelUC.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }

        }


        private void btnTotalBlog_Click(object sender, EventArgs e)
        {
            resetBtn();
            btnTotalBlog.BackColor = Color.DarkTurquoise;
            frmTotal frm = new frmTotal();
            openChildForm(frm);
        }
        private void resetBtn()
        {
            btnListAccount.BackColor = Color.FromArgb(0, 64, 64);
            btnTotalBlog.BackColor = Color.FromArgb(0, 64, 64);
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
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
                this.Close();
            }
            else
            {
                close = false;
            }
        }
    }
}
