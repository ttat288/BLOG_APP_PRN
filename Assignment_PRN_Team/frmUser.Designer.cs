﻿namespace Assignment_PRN_Team
{
    partial class frmUser
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
            components = new System.ComponentModel.Container();
            topbarMenu = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            sidebarMenu = new System.Windows.Forms.Panel();
            btnApprove = new System.Windows.Forms.Button();
            btnMyBlog = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnHome = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            txtID = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.Label();
            avatar = new System.Windows.Forms.PictureBox();
            panel8 = new System.Windows.Forms.Panel();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            panelUC = new System.Windows.Forms.Panel();
            topbarMenu.SuspendLayout();
            sidebarMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            SuspendLayout();
            // 
            // topbarMenu
            // 
            topbarMenu.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            topbarMenu.Controls.Add(label1);
            topbarMenu.Dock = System.Windows.Forms.DockStyle.Top;
            topbarMenu.Location = new System.Drawing.Point(0, 0);
            topbarMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            topbarMenu.Name = "topbarMenu";
            topbarMenu.Size = new System.Drawing.Size(1198, 38);
            topbarMenu.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            label1.Location = new System.Drawing.Point(534, -2);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(110, 44);
            label1.TabIndex = 4;
            label1.Text = "BLOG";
            // 
            // sidebarMenu
            // 
            sidebarMenu.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            sidebarMenu.Controls.Add(btnApprove);
            sidebarMenu.Controls.Add(btnMyBlog);
            sidebarMenu.Controls.Add(btnLogout);
            sidebarMenu.Controls.Add(btnNew);
            sidebarMenu.Controls.Add(btnHome);
            sidebarMenu.Controls.Add(panel1);
            sidebarMenu.Dock = System.Windows.Forms.DockStyle.Left;
            sidebarMenu.Location = new System.Drawing.Point(0, 38);
            sidebarMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            sidebarMenu.MaximumSize = new System.Drawing.Size(210, 0);
            sidebarMenu.MinimumSize = new System.Drawing.Size(62, 0);
            sidebarMenu.Name = "sidebarMenu";
            sidebarMenu.Size = new System.Drawing.Size(210, 629);
            sidebarMenu.TabIndex = 7;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = System.Drawing.Color.Teal;
            btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnApprove.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnApprove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnApprove.Location = new System.Drawing.Point(1, 337);
            btnApprove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new System.Drawing.Size(210, 46);
            btnApprove.TabIndex = 24;
            btnApprove.Text = "Waiting Blog";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnMyBlog
            // 
            btnMyBlog.BackColor = System.Drawing.Color.Teal;
            btnMyBlog.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMyBlog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnMyBlog.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnMyBlog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnMyBlog.Location = new System.Drawing.Point(1, 287);
            btnMyBlog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnMyBlog.Name = "btnMyBlog";
            btnMyBlog.Size = new System.Drawing.Size(210, 46);
            btnMyBlog.TabIndex = 23;
            btnMyBlog.Text = "My Blog";
            btnMyBlog.UseVisualStyleBackColor = false;
            btnMyBlog.Click += btnMyBlog_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.Color.Teal;
            btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnLogout.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnLogout.Location = new System.Drawing.Point(0, 583);
            btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(210, 46);
            btnLogout.TabIndex = 22;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = System.Drawing.Color.Teal;
            btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnNew.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnNew.Location = new System.Drawing.Point(1, 237);
            btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(210, 46);
            btnNew.TabIndex = 21;
            btnNew.Text = "Create Post";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = System.Drawing.Color.Teal;
            btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnHome.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnHome.Location = new System.Drawing.Point(0, 188);
            btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new System.Drawing.Size(210, 46);
            btnHome.TabIndex = 20;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(avatar);
            panel1.Controls.Add(panel8);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(210, 184);
            panel1.TabIndex = 10;
            // 
            // txtID
            // 
            txtID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            txtID.Location = new System.Drawing.Point(1, 138);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(206, 28);
            txtID.TabIndex = 3;
            txtID.Text = "SE1123456";
            txtID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtName
            // 
            txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            txtName.Location = new System.Drawing.Point(3, 94);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(207, 44);
            txtName.TabIndex = 2;
            txtName.Text = "Name Name Name Name";
            txtName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // avatar
            // 
            avatar.Location = new System.Drawing.Point(69, 26);
            avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            avatar.Name = "avatar";
            avatar.Size = new System.Drawing.Size(57, 57);
            avatar.TabIndex = 0;
            avatar.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = System.Drawing.Color.Teal;
            panel8.Location = new System.Drawing.Point(1, 0);
            panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(209, 52);
            panel8.TabIndex = 1;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // panelUC
            // 
            panelUC.Dock = System.Windows.Forms.DockStyle.Fill;
            panelUC.Location = new System.Drawing.Point(210, 38);
            panelUC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panelUC.Name = "panelUC";
            panelUC.Size = new System.Drawing.Size(988, 629);
            panelUC.TabIndex = 8;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1198, 667);
            Controls.Add(panelUC);
            Controls.Add(sidebarMenu);
            Controls.Add(topbarMenu);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmUser";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmUser";
            FormClosing += frmUser_FormClosing;
            Load += frmUser_Load;
            Resize += frmUser_Resize;
            topbarMenu.ResumeLayout(false);
            topbarMenu.PerformLayout();
            sidebarMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnNewBlog;
        private System.Windows.Forms.Panel topbarMenu;
        private System.Windows.Forms.Panel sidebarMenu;
        private FontAwesome.Sharp.IconPictureBox iconLogo;
        //private FontAwesome.Sharp.IconButton btnLogout;
        //private FontAwesome.Sharp.IconButton btnSetting;
        //private FontAwesome.Sharp.IconButton btnMyBlog;
        //private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Timer sidebarTimer;
        //private FontAwesome.Sharp.IconButton btnNew;
        private System.Windows.Forms.Panel panelUC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnMyBlog;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label label1;
    }
}