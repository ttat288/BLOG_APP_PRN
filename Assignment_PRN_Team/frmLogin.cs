using DataAccess.Repository;
using BlogObject;  // Add this line
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment_PRN_Team
{
    public partial class frmLogin : Form
    {
        UserRepository userRepository = new UserRepository();
        Account RememberAcc;

        public frmLogin()
        {
            InitializeComponent();
            RememberAcc = userRepository.remember();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userRepository.Login(txtEmail.Text, txtPassword.Text, rememberCb.Checked))
            {
                this.Hide();
                frmUser user = new frmUser();
                user.ShowDialog();
            }
            else
            {
                MessageBox.Show("email or password is not correct!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (RememberAcc.Remember)
            {
                txtEmail.Text = RememberAcc.Email;
                txtPassword.Text = RememberAcc.Pass;
                rememberCb.Checked = true;
            }
            else
            {
                txtEmail.Text = "";
                txtPassword.Text = "";
                rememberCb.Checked = false;
            }
        }

        private void registerBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
