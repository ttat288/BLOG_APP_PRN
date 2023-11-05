namespace BlogWinApp
{
    partial class frmComment
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new System.Windows.Forms.Label();
            avatar = new System.Windows.Forms.PictureBox();
            btnComment = new System.Windows.Forms.Button();
            txtComment = new System.Windows.Forms.TextBox();
            pnlComment = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            txtName.Location = new System.Drawing.Point(82, 592);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(189, 20);
            txtName.TabIndex = 5;
            txtName.Text = "Name Name Name Name";
            // 
            // avatar
            // 
            avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            avatar.Location = new System.Drawing.Point(15, 596);
            avatar.Name = "avatar";
            avatar.Size = new System.Drawing.Size(65, 68);
            avatar.TabIndex = 3;
            avatar.TabStop = false;
            // 
            // btnComment
            // 
            btnComment.BackColor = System.Drawing.Color.LightSeaGreen;
            btnComment.Cursor = System.Windows.Forms.Cursors.Hand;
            btnComment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnComment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnComment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnComment.Location = new System.Drawing.Point(317, 668);
            btnComment.Name = "btnComment";
            btnComment.Size = new System.Drawing.Size(132, 32);
            btnComment.TabIndex = 6;
            btnComment.Text = "comment";
            btnComment.UseVisualStyleBackColor = false;
            btnComment.Click += btnComment_Click;
            // 
            // txtComment
            // 
            txtComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtComment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtComment.Location = new System.Drawing.Point(86, 615);
            txtComment.MaxLength = 260;
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.PlaceholderText = "Enter comment";
            txtComment.Size = new System.Drawing.Size(363, 49);
            txtComment.TabIndex = 7;
            txtComment.TextChanged += txtComment_TextChanged;
            // 
            // pnlComment
            // 
            pnlComment.AutoScroll = true;
            pnlComment.Location = new System.Drawing.Point(0, 0);
            pnlComment.Name = "pnlComment";
            pnlComment.Size = new System.Drawing.Size(468, 590);
            pnlComment.TabIndex = 8;
            // 
            // frmComment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Teal;
            ClientSize = new System.Drawing.Size(467, 704);
            Controls.Add(pnlComment);
            Controls.Add(txtComment);
            Controls.Add(btnComment);
            Controls.Add(txtName);
            Controls.Add(avatar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmComment";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmComment";
            Load += frmComment_Load;
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.FlowLayoutPanel pnlComment;
    }
}