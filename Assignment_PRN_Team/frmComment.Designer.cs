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
            txtName.Location = new System.Drawing.Point(94, 789);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(235, 25);
            txtName.TabIndex = 5;
            txtName.Text = "Name Name Name Name";
            // 
            // avatar
            // 
            avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            avatar.Location = new System.Drawing.Point(12, 803);
            avatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            avatar.Name = "avatar";
            avatar.Size = new System.Drawing.Size(79, 75);
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
            btnComment.Location = new System.Drawing.Point(362, 891);
            btnComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnComment.Name = "btnComment";
            btnComment.Size = new System.Drawing.Size(151, 43);
            btnComment.TabIndex = 6;
            btnComment.Text = "comment";
            btnComment.UseVisualStyleBackColor = false;
            btnComment.Click += btnComment_Click;
            // 
            // txtComment
            // 
            txtComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtComment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtComment.Location = new System.Drawing.Point(98, 820);
            txtComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtComment.MaxLength = 260;
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.PlaceholderText = "Enter comment";
            txtComment.Size = new System.Drawing.Size(415, 65);
            txtComment.TabIndex = 7;
            txtComment.TextChanged += txtComment_TextChanged;
            // 
            // pnlComment
            // 
            pnlComment.AutoScroll = true;
            pnlComment.Location = new System.Drawing.Point(0, 0);
            pnlComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlComment.Name = "pnlComment";
            pnlComment.Size = new System.Drawing.Size(535, 787);
            pnlComment.TabIndex = 8;
            // 
            // frmComment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Teal;
            ClientSize = new System.Drawing.Size(534, 939);
            Controls.Add(pnlComment);
            Controls.Add(txtComment);
            Controls.Add(btnComment);
            Controls.Add(txtName);
            Controls.Add(avatar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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