namespace BlogWinApp
{
    partial class post
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(post));
            img = new System.Windows.Forms.PictureBox();
            avatar = new System.Windows.Forms.PictureBox();
            lblTitle = new System.Windows.Forms.Label();
            lblMajor = new System.Windows.Forms.Label();
            lblContent = new System.Windows.Forms.Label();
            likeBtn = new System.Windows.Forms.Button();
            commentBtn = new System.Windows.Forms.Button();
            deletePost = new System.Windows.Forms.Label();
            btnApprove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            SuspendLayout();
            // 
            // img
            // 
            img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            img.Cursor = System.Windows.Forms.Cursors.Hand;
            img.Location = new System.Drawing.Point(47, 239);
            img.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            img.Name = "img";
            img.Size = new System.Drawing.Size(769, 356);
            img.TabIndex = 0;
            img.TabStop = false;
            img.Click += post_click;
            img.MouseEnter += post_enter;
            img.MouseLeave += post_leave;
            // 
            // avatar
            // 
            avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            avatar.Location = new System.Drawing.Point(47, 23);
            avatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            avatar.Name = "avatar";
            avatar.Size = new System.Drawing.Size(50, 56);
            avatar.TabIndex = 1;
            avatar.TabStop = false;
            avatar.Click += avatar_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(104, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(360, 41);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "SWP / What is firebase ?";
            lblTitle.Click += post_click;
            lblTitle.MouseEnter += post_enter;
            lblTitle.MouseLeave += post_leave;
            // 
            // lblMajor
            // 
            lblMajor.AutoSize = true;
            lblMajor.Cursor = System.Windows.Forms.Cursors.Hand;
            lblMajor.Location = new System.Drawing.Point(114, 59);
            lblMajor.Name = "lblMajor";
            lblMajor.Size = new System.Drawing.Size(158, 20);
            lblMajor.TabIndex = 3;
            lblMajor.Text = "#software engineering";
            lblMajor.Click += post_click;
            lblMajor.MouseEnter += post_enter;
            lblMajor.MouseLeave += post_leave;
            // 
            // lblContent
            // 
            lblContent.Cursor = System.Windows.Forms.Cursors.Hand;
            lblContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblContent.Location = new System.Drawing.Point(47, 107);
            lblContent.Name = "lblContent";
            lblContent.Size = new System.Drawing.Size(769, 128);
            lblContent.TabIndex = 6;
            lblContent.Text = resources.GetString("lblContent.Text");
            lblContent.Click += post_click;
            lblContent.MouseEnter += post_enter;
            lblContent.MouseLeave += post_leave;
            // 
            // likeBtn
            // 
            likeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            likeBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            likeBtn.Location = new System.Drawing.Point(47, 603);
            likeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            likeBtn.Name = "likeBtn";
            likeBtn.Size = new System.Drawing.Size(112, 41);
            likeBtn.TabIndex = 7;
            likeBtn.Text = "👍1k";
            likeBtn.UseVisualStyleBackColor = true;
            likeBtn.Click += likeBtn_Click;
            // 
            // commentBtn
            // 
            commentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            commentBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            commentBtn.Location = new System.Drawing.Point(704, 603);
            commentBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            commentBtn.Name = "commentBtn";
            commentBtn.Size = new System.Drawing.Size(112, 41);
            commentBtn.TabIndex = 8;
            commentBtn.Text = "💬800";
            commentBtn.UseVisualStyleBackColor = true;
            commentBtn.Click += commentBtn_Click;
            // 
            // deletePost
            // 
            deletePost.AutoSize = true;
            deletePost.Cursor = System.Windows.Forms.Cursors.Hand;
            deletePost.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            deletePost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            deletePost.Location = new System.Drawing.Point(791, 23);
            deletePost.Name = "deletePost";
            deletePost.Size = new System.Drawing.Size(59, 41);
            deletePost.TabIndex = 9;
            deletePost.Text = "🗑️";
            deletePost.Click += deletePost_Click;
            deletePost.MouseEnter += delete_enter;
            deletePost.MouseLeave += delete_leave;
            // 
            // btnApprove
            // 
            btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            btnApprove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnApprove.Location = new System.Drawing.Point(747, 23);
            btnApprove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new System.Drawing.Size(103, 44);
            btnApprove.TabIndex = 10;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = true;
            btnApprove.Visible = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // post
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            Controls.Add(btnApprove);
            Controls.Add(deletePost);
            Controls.Add(commentBtn);
            Controls.Add(likeBtn);
            Controls.Add(lblContent);
            Controls.Add(lblMajor);
            Controls.Add(lblTitle);
            Controls.Add(avatar);
            Controls.Add(img);
            Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            Name = "post";
            Size = new System.Drawing.Size(859, 648);
            Click += post_click;
            MouseEnter += post_enter;
            MouseLeave += post_leave;
            ((System.ComponentModel.ISupportInitialize)img).EndInit();
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Button likeBtn;
        private System.Windows.Forms.Button commentBtn;
        private System.Windows.Forms.Label deletePost;
        private System.Windows.Forms.Button btnApprove;
    }
}
