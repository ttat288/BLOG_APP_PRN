using BlogObject;
using BlogObject.Models;
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

namespace BlogWinApp
{
    public partial class frmProfileAnotherPerson : Form
    {
        IUserRepository userRepository = new UserRepository();
        IPostRepository postRepository = new PostRepository();
        UserTbl user = new UserTbl();
        string totalPosts;
        public frmProfileAnotherPerson(string id)
        {
            InitializeComponent();
            user = userRepository.user(id);
            totalPosts = postRepository.CountPostsByIdPrefix(id).ToString();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProfileAnotherPerson_Load(object sender, EventArgs e)
        {
            avatar.ImageLocation = user.Avatar;
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            userName.Text = user.Name;
            userID.Text = user.UserId;
            totalPost.Text = totalPosts;
        }
    }
}
