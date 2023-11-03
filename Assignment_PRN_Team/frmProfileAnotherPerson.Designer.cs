namespace BlogWinApp
{
    partial class frmProfileAnotherPerson
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
            panel1 = new System.Windows.Forms.Panel();
            avatar = new System.Windows.Forms.PictureBox();
            userName = new System.Windows.Forms.Label();
            userID = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            totalPost = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(542, 82);
            panel1.TabIndex = 0;
            // 
            // avatar
            // 
            avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            avatar.Location = new System.Drawing.Point(218, 47);
            avatar.Name = "avatar";
            avatar.Size = new System.Drawing.Size(100, 95);
            avatar.TabIndex = 1;
            avatar.TabStop = false;
            // 
            // userName
            // 
            userName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            userName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            userName.Location = new System.Drawing.Point(86, 167);
            userName.Name = "userName";
            userName.Size = new System.Drawing.Size(364, 55);
            userName.TabIndex = 2;
            userName.Text = "Name Name Name Name";
            userName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userID
            // 
            userID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            userID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            userID.Location = new System.Drawing.Point(187, 222);
            userID.Name = "userID";
            userID.Size = new System.Drawing.Size(162, 35);
            userID.TabIndex = 3;
            userID.Text = "SE123456";
            userID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            panel2.Controls.Add(totalPost);
            panel2.Controls.Add(label1);
            panel2.Location = new System.Drawing.Point(162, 328);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(218, 155);
            panel2.TabIndex = 4;
            // 
            // totalPost
            // 
            totalPost.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            totalPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            totalPost.Location = new System.Drawing.Point(3, 44);
            totalPost.Name = "totalPost";
            totalPost.Size = new System.Drawing.Size(212, 111);
            totalPost.TabIndex = 1;
            totalPost.Text = "1";
            totalPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(41, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(138, 32);
            label1.TabIndex = 0;
            label1.Text = "Total posts";
            // 
            // Close
            // 
            Close.BackColor = System.Drawing.Color.Teal;
            Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Close.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Close.Location = new System.Drawing.Point(216, 533);
            Close.Name = "Close";
            Close.Size = new System.Drawing.Size(111, 40);
            Close.TabIndex = 6;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // frmProfileAnotherPerson
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Teal;
            ClientSize = new System.Drawing.Size(541, 585);
            Controls.Add(Close);
            Controls.Add(panel2);
            Controls.Add(userID);
            Controls.Add(userName);
            Controls.Add(avatar);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmProfileAnotherPerson";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmProfileAnotherPerson";
            Load += frmProfileAnotherPerson_Load;
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label userID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label totalPost;
        private System.Windows.Forms.Label label1;
    }
}