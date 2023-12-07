using BlogObject;
using BlogWinApp;
using DataAccess.Repository;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment_PRN_Team
{
    public partial class frmUser : Form
    {
        public static frmUser formUser;
        bool sidebarExpand = false;
        IUserRepository userRepository = new UserRepository();
        Account account;
        public frmUser()
        {
            InitializeComponent();
            account = userRepository.remember();
            if (account.Role != "lecturer") btnApprove.Visible = false;
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

        private void frmUser_Load(object sender, EventArgs e)
        {
            avatar.ImageLocation = account.avt;
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            txtName.Text = userRepository.user(account.id).Name;
            txtID.Text = account.id;
        }

        private void frmUser_Resize(object sender, EventArgs e)
        {



        }
        Form fNewBlog = new frmNewBlog();
        private void btnNew_Click(object sender, EventArgs e)
        {
            rsBtn();
            //sidebarTimer.Start();
            btnNew.BackColor = Color.DarkTurquoise;
            openChildForm(fNewBlog);

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

        public void showPost(string msg)
        {
            frmPost formPost = new frmPost(this, msg);
            rsBtn();
            if (msg == "allpost")
            {
                btnHome.BackColor = Color.DarkTurquoise;
            }
            if (msg == "approve")
            {
                btnApprove.BackColor = Color.DarkTurquoise;
            }
            openChildForm(formPost);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            showPost("allpost");
        }

        // hiện thông báo ....(tin nhắn, thời gian hiển thị);
        //private void ShowToast(string message, int duration)
        //{
        //    var toast = new Form();
        //    toast.TopMost = true;
        //    toast.FormBorderStyle = FormBorderStyle.None;
        //    toast.Size = new System.Drawing.Size(300, 60);
        //    toast.StartPosition = FormStartPosition.CenterScreen;
        //    toast.BackColor = System.Drawing.Color.White; // Thay đổi màu nền thành màu trắng
        //    toast.TransparencyKey = System.Drawing.Color.White;

        //    var label = new System.Windows.Forms.Label();
        //    label.Text = message;
        //    label.TextAlign = ContentAlignment.MiddleCenter;
        //    label.Dock = DockStyle.Fill;

        //    toast.Controls.Add(label);
        //    toast.Show();

        //    Task.Delay(duration).ContinueWith(t => {
        //        if (!toast.IsDisposed && toast.Created)
        //        {
        //            toast.Invoke(new Action(() => toast.Close()));
        //        }
        //    });
        //}

        private void rsBtn()
        {
            btnHome.BackColor = Color.FromArgb(0, 64, 64);
            btnLogout.BackColor = Color.FromArgb(0, 64, 64);
            btnMyBlog.BackColor = Color.FromArgb(0, 64, 64);
            btnNew.BackColor = Color.FromArgb(0, 64, 64);
            btnApprove.BackColor = Color.FromArgb(0, 64, 64);
        }
        private void panelUC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMyBlog_Click(object sender, EventArgs e)
        {
            frmPost formPost = new frmPost(this, account.id);
            rsBtn();
            btnMyBlog.BackColor = Color.DarkTurquoise;
            openChildForm(formPost);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            frmPost formPost = new frmPost(this, "approve");
            rsBtn();
            btnApprove.BackColor = Color.DarkTurquoise;
            openChildForm(formPost);
        }
    }
}

