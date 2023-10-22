using DataAccess.Repository;
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
    public partial class frmLogin : Form
    {
        UserRepository userRepository = new UserRepository();

        frmUser user;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userRepository.Login(txtEmail.Text, txtPassword.Text))
            {
                this.Hide();
                user = new frmUser();
                user.ShowDialog();
                this.Close();
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
    }
}
