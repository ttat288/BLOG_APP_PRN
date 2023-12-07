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
    public partial class comment : UserControl
    {
        string userID;
        public comment(string id)
        {
            InitializeComponent();
            userID = id;
        }

        private void avatar_Click(object sender, EventArgs e)
        {
            frmProfileAnotherPerson frm = new frmProfileAnotherPerson(userID);
            frm.ShowDialog();
        }

        #region Properties_Comment
        private string avt;
        private string name;
        private string _comment;

        

        [Category("Custom comments")]
        public string Name
        {
            get { return name; }
            set { name = value; txtName.Text = value; }
        }

        [Category("Custom comments")]
        public string Avatar
        {
            get { return avt; }
            set
            {
                avt = value;
                avatar.ImageLocation = value;
                avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        [Category("Custom comments")]
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; txtComment.Text = value; }
        }
        #endregion
    }
}
