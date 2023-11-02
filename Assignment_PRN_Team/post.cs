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
    public partial class post : UserControl
    {
        public post()
        {
            InitializeComponent();
        }


        #region Properties
        private string _title;
        private string _major;
        private string _content;
        private string _img;
        private string _avt;
        private string _likes;
        private string _comments;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }
        [Category("Custom Props")]
        public string Major
        {
            get { return _major; }
            set { _major = value; lblMajor.Text = value; }
        }

        [Category("Custom Props")]
        public string Content
        {
            get { return _content; }
            set { _content = value; lblContent.Text = value; }
        }

        [Category("Custom Props")]
        public string Avatar
        {
            get { return _avt; }
            set
            {
                _avt = value;
                avatar.ImageLocation = value;
                avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        [Category("Custom Props")]
        public string Img
        {
            get { return _img; }
            set
            {
                _img = value;
                img.ImageLocation = value;
                img.SizeMode = PictureBoxSizeMode.StretchImage; // Đặt chế độ là StretchImage
            }
        }

        [Category("Custom Props")]
        public string Likes
        {
            get { return _likes; }
            set { _likes = value; likeBtn.Text = "👍 " + value; }
        }

        [Category("Custom Props")]
        public string Comments
        {
            get { return _comments; }
            set { _comments = value; commentBtn.Text = "💬 " + value; }
        }


        
        #endregion
    }
}
