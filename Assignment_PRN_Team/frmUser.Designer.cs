namespace Assignment_PRN_Team
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
            btnNewBlog = new FontAwesome.Sharp.IconButton();
            topbarMenu = new System.Windows.Forms.Panel();
            panel7 = new System.Windows.Forms.Panel();
            btnMenu = new FontAwesome.Sharp.IconButton();
            sidebarMenu = new System.Windows.Forms.Panel();
            btnNew = new FontAwesome.Sharp.IconButton();
            panel6 = new System.Windows.Forms.Panel();
            btnLogout = new FontAwesome.Sharp.IconButton();
            panel8 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            btnSetting = new FontAwesome.Sharp.IconButton();
            panel4 = new System.Windows.Forms.Panel();
            btnMyBlog = new FontAwesome.Sharp.IconButton();
            panel3 = new System.Windows.Forms.Panel();
            btnHome = new FontAwesome.Sharp.IconButton();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            panelUC = new System.Windows.Forms.Panel();
            topbarMenu.SuspendLayout();
            panel7.SuspendLayout();
            sidebarMenu.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnNewBlog
            // 
            btnNewBlog.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNewBlog.IconColor = System.Drawing.Color.Black;
            btnNewBlog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNewBlog.Location = new System.Drawing.Point(0, 0);
            btnNewBlog.Name = "btnNewBlog";
            btnNewBlog.Size = new System.Drawing.Size(75, 23);
            btnNewBlog.TabIndex = 0;
            // 
            // topbarMenu
            // 
            topbarMenu.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            topbarMenu.Controls.Add(panel7);
            topbarMenu.Dock = System.Windows.Forms.DockStyle.Top;
            topbarMenu.Location = new System.Drawing.Point(0, 0);
            topbarMenu.Name = "topbarMenu";
            topbarMenu.Size = new System.Drawing.Size(1366, 50);
            topbarMenu.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnMenu);
            panel7.Location = new System.Drawing.Point(3, 0);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(68, 50);
            panel7.TabIndex = 8;
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            btnMenu.IconColor = System.Drawing.Color.WhiteSmoke;
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.Location = new System.Drawing.Point(-6, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new System.Drawing.Size(71, 50);
            btnMenu.TabIndex = 7;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // sidebarMenu
            // 
            sidebarMenu.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            sidebarMenu.Controls.Add(btnHome);
            sidebarMenu.Controls.Add(panel6);
            sidebarMenu.Controls.Add(panel8);
            sidebarMenu.Controls.Add(panel5);
            sidebarMenu.Controls.Add(panel4);
            sidebarMenu.Controls.Add(panel3);
            sidebarMenu.Dock = System.Windows.Forms.DockStyle.Left;
            sidebarMenu.Location = new System.Drawing.Point(0, 50);
            sidebarMenu.MaximumSize = new System.Drawing.Size(240, 0);
            sidebarMenu.MinimumSize = new System.Drawing.Size(71, 0);
            sidebarMenu.Name = "sidebarMenu";
            sidebarMenu.Size = new System.Drawing.Size(240, 634);
            sidebarMenu.TabIndex = 7;
            // 
            // btnNew
            // 
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNew.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNew.ForeColor = System.Drawing.Color.WhiteSmoke;
            btnNew.IconChar = FontAwesome.Sharp.IconChar.SquarePlus;
            btnNew.IconColor = System.Drawing.Color.WhiteSmoke;
            btnNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNew.Location = new System.Drawing.Point(-9, -10);
            btnNew.Name = "btnNew";
            btnNew.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnNew.Size = new System.Drawing.Size(268, 110);
            btnNew.TabIndex = 8;
            btnNew.Text = "             NewBlog";
            btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnLogout);
            panel6.Location = new System.Drawing.Point(4, 490);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(236, 86);
            panel6.TabIndex = 3;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnLogout.IconColor = System.Drawing.Color.WhiteSmoke;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogout.Location = new System.Drawing.Point(-9, -13);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnLogout.Size = new System.Drawing.Size(268, 110);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "             Logout";
            btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel8
            // 
            panel8.BackgroundImage = BlogWinApp.Properties.Resources.logo1;
            panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            panel8.Location = new System.Drawing.Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(234, 112);
            panel8.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnSetting);
            panel5.Location = new System.Drawing.Point(4, 398);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(236, 86);
            panel5.TabIndex = 3;
            // 
            // btnSetting
            // 
            btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSetting.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSetting.ForeColor = System.Drawing.Color.WhiteSmoke;
            btnSetting.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            btnSetting.IconColor = System.Drawing.Color.WhiteSmoke;
            btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSetting.Location = new System.Drawing.Point(-9, -13);
            btnSetting.Name = "btnSetting";
            btnSetting.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnSetting.Size = new System.Drawing.Size(268, 110);
            btnSetting.TabIndex = 2;
            btnSetting.Text = "             Setting";
            btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSetting.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnMyBlog);
            panel4.Location = new System.Drawing.Point(4, 306);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(236, 86);
            panel4.TabIndex = 9;
            // 
            // btnMyBlog
            // 
            btnMyBlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMyBlog.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnMyBlog.ForeColor = System.Drawing.Color.WhiteSmoke;
            btnMyBlog.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btnMyBlog.IconColor = System.Drawing.Color.WhiteSmoke;
            btnMyBlog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMyBlog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMyBlog.Location = new System.Drawing.Point(-9, -13);
            btnMyBlog.Name = "btnMyBlog";
            btnMyBlog.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnMyBlog.Size = new System.Drawing.Size(268, 110);
            btnMyBlog.TabIndex = 2;
            btnMyBlog.Text = "             My Blogs";
            btnMyBlog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMyBlog.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnNew);
            panel3.Location = new System.Drawing.Point(4, 214);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(236, 86);
            panel3.TabIndex = 8;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            btnHome.IconColor = System.Drawing.Color.WhiteSmoke;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHome.Location = new System.Drawing.Point(-5, 121);
            btnHome.Name = "btnHome";
            btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnHome.Size = new System.Drawing.Size(268, 110);
            btnHome.TabIndex = 2;
            btnHome.Text = "             Blogs";
            btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // panelUC
            // 
            panelUC.Dock = System.Windows.Forms.DockStyle.Fill;
            panelUC.Location = new System.Drawing.Point(240, 50);
            panelUC.Name = "panelUC";
            panelUC.Size = new System.Drawing.Size(1126, 634);
            panelUC.TabIndex = 8;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1366, 684);
            Controls.Add(panelUC);
            Controls.Add(sidebarMenu);
            Controls.Add(topbarMenu);
            Name = "frmUser";
            Text = "frmUser";
            FormClosing += frmUser_FormClosing;
            Load += frmUser_Load;
            Resize += frmUser_Resize;
            topbarMenu.ResumeLayout(false);
            panel7.ResumeLayout(false);
            sidebarMenu.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnNewBlog;
        private System.Windows.Forms.Panel topbarMenu;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel sidebarMenu;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconPictureBox iconLogo;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnSetting;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnMyBlog;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Timer sidebarTimer;
        private FontAwesome.Sharp.IconButton btnNew;
        private System.Windows.Forms.Panel panelUC;
    }
}