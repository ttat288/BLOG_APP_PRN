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
            ((System.ComponentModel.ISupportInitialize)img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            SuspendLayout();
            // 
            // img
            // 
            img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            img.Cursor = System.Windows.Forms.Cursors.Hand;
            img.Location = new System.Drawing.Point(41, 179);
            img.Name = "img";
            img.Size = new System.Drawing.Size(673, 267);
            img.TabIndex = 0;
            img.TabStop = false;
            img.Click += post_click;
            img.MouseEnter += post_enter;
            img.MouseLeave += post_leave;
            // 
            // avatar
            // 
            avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            avatar.Location = new System.Drawing.Point(41, 17);
            avatar.Name = "avatar";
            avatar.Size = new System.Drawing.Size(44, 42);
            avatar.TabIndex = 1;
            avatar.TabStop = false;
            avatar.Click += avatar_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(91, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(292, 32);
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
            lblMajor.Location = new System.Drawing.Point(100, 44);
            lblMajor.Name = "lblMajor";
            lblMajor.Size = new System.Drawing.Size(125, 15);
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
            lblContent.Location = new System.Drawing.Point(41, 80);
            lblContent.Name = "lblContent";
            lblContent.Size = new System.Drawing.Size(673, 96);
            lblContent.TabIndex = 6;
            lblContent.Text = resources.GetString("lblContent.Text");
            lblContent.Click += post_click;
            lblContent.MouseEnter += post_enter;
            lblContent.MouseLeave += post_leave;
            // 
            // likeBtn
            // 
            likeBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            likeBtn.Location = new System.Drawing.Point(41, 452);
            likeBtn.Name = "likeBtn";
            likeBtn.Size = new System.Drawing.Size(98, 31);
            likeBtn.TabIndex = 7;
            likeBtn.Text = "👍1k";
            likeBtn.UseVisualStyleBackColor = true;
            likeBtn.Click += likeBtn_Click;
            // 
            // commentBtn
            // 
            commentBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            commentBtn.Location = new System.Drawing.Point(616, 452);
            commentBtn.Name = "commentBtn";
            commentBtn.Size = new System.Drawing.Size(98, 31);
            commentBtn.TabIndex = 8;
            commentBtn.Text = "💬800";
            commentBtn.UseVisualStyleBackColor = true;
            commentBtn.Click += commentBtn_Click;
            // 
            // deletePost
            // 
            deletePost.AutoSize = true;
            deletePost.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            deletePost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            deletePost.Location = new System.Drawing.Point(692, 17);
            deletePost.Name = "deletePost";
            deletePost.Size = new System.Drawing.Size(47, 32);
            deletePost.TabIndex = 9;
            deletePost.Text = "🗑️";
            deletePost.Click += deletePost_Click;
            deletePost.MouseEnter += delete_enter;
            deletePost.MouseLeave += delete_leave;
            // 
            // post
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            Controls.Add(deletePost);
            Controls.Add(commentBtn);
            Controls.Add(likeBtn);
            Controls.Add(lblContent);
            Controls.Add(lblMajor);
            Controls.Add(lblTitle);
            Controls.Add(avatar);
            Controls.Add(img);
            Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            Name = "post";
            Size = new System.Drawing.Size(752, 486);
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
    }
}
