namespace BlogWinApp
{
    partial class comment
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
            avatar = new System.Windows.Forms.PictureBox();
            txtComment = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            SuspendLayout();
            // 
            // avatar
            // 
            avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            avatar.Location = new System.Drawing.Point(15, 33);
            avatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            avatar.Name = "avatar";
            avatar.Size = new System.Drawing.Size(74, 75);
            avatar.TabIndex = 0;
            avatar.TabStop = false;
            avatar.Click += avatar_Click;
            // 
            // txtComment
            // 
            txtComment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtComment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            txtComment.Location = new System.Drawing.Point(96, 47);
            txtComment.Name = "txtComment";
            txtComment.Size = new System.Drawing.Size(410, 69);
            txtComment.TabIndex = 1;
            txtComment.Text = "dddddddddddddddaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            txtComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            txtName.Location = new System.Drawing.Point(96, 20);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(235, 25);
            txtName.TabIndex = 2;
            txtName.Text = "Name Name Name Name";
            // 
            // comment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Teal;
            Controls.Add(txtName);
            Controls.Add(txtComment);
            Controls.Add(avatar);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "comment";
            Size = new System.Drawing.Size(523, 139);
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label txtComment;
        private System.Windows.Forms.Label txtName;
    }
}
