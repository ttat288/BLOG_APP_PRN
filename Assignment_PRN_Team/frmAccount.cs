using DataAccess.Repository;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BlogWinApp
{
    public partial class frmAccount : Form
    {
        IUserRepository repo = new UserRepository();
        public frmAccount()
        {
            InitializeComponent();
            //Style for gridview.
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void LoadUser()
        {
            try
            {
                var listUser = repo.GetAllUser();

                BindingSource source = new BindingSource();
                source.DataSource = listUser;

                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                cboMajor.DataBindings.Clear();
                cboRole.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "UserId");
                txtName.DataBindings.Add("Text", source, "Name");
                txtEmail.DataBindings.Add("Text", source, "Email");
                cboMajor.DataBindings.Add("Text", source, "Major");
                cboRole.DataBindings.Add("Text", source, "Role");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;
                dataGridView1.Columns["Password"].Visible = false;
                dataGridView1.Columns["Avatar"].Visible = false;
                dataGridView1.Columns["CommentTbls"].Visible = false;
                dataGridView1.Columns["LikeTbls"].Visible = false;
                dataGridView1.Columns["PostTbls"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of User");
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != "")
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        repo.DeleteUser(txtID.Text);
                        MessageBox.Show("Xóa thành công");
                        LoadUser();
                    }
                }
                else
                {
                    MessageBox.Show("Chọn một người dùng để xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi khi xóa người dùng");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem các trường thông tin cần thiết đã được điền đầy đủ hay chưa
                if (txtID.Text != "" && cboRole.Text != "" && cboMajor.Text != "")
                {
                    // Gọi phương thức UpdateUser để cập nhật thông tin người dùng
                    repo.UpdateUser(txtID.Text, cboRole.Text, cboMajor.Text);

                    // Hiển thị thông báo cập nhật thành công
                    MessageBox.Show("Cập nhật thành công");

                    // Tải lại danh sách người dùng sau khi cập nhật
                    LoadUser();
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin cần cập nhật");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi khi cập nhật người dùng");
            }
        }
    }
}
