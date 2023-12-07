using System.Windows.Forms.PropertyGridInternal;

namespace Assignment_PRN_Team
{
    partial class frmAdmin
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
            panelUC = new System.Windows.Forms.Panel();
            topbarMenu = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            sidebarMenu = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnLogout = new System.Windows.Forms.Button();
            btnTotalBlog = new System.Windows.Forms.Button();
            btnListAccount = new System.Windows.Forms.Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            topbarMenu.SuspendLayout();
            sidebarMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelUC
            // 
            panelUC.Dock = System.Windows.Forms.DockStyle.Fill;
            panelUC.Location = new System.Drawing.Point(240, 51);
            panelUC.Name = "panelUC";
            panelUC.Size = new System.Drawing.Size(1129, 738);
            panelUC.TabIndex = 11;
            // 
            // topbarMenu
            // 
            topbarMenu.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            topbarMenu.Controls.Add(label1);
            topbarMenu.Dock = System.Windows.Forms.DockStyle.Top;
            topbarMenu.Location = new System.Drawing.Point(240, 0);
            topbarMenu.Name = "topbarMenu";
            topbarMenu.Size = new System.Drawing.Size(1129, 51);
            topbarMenu.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            label1.Location = new System.Drawing.Point(469, -5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(136, 54);
            label1.TabIndex = 4;
            label1.Text = "BLOG";
            // 
            // sidebarMenu
            // 
            sidebarMenu.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            sidebarMenu.Controls.Add(pictureBox1);
            sidebarMenu.Controls.Add(btnLogout);
            sidebarMenu.Controls.Add(btnTotalBlog);
            sidebarMenu.Controls.Add(btnListAccount);
            sidebarMenu.Dock = System.Windows.Forms.DockStyle.Left;
            sidebarMenu.Location = new System.Drawing.Point(0, 0);
            sidebarMenu.MaximumSize = new System.Drawing.Size(240, 0);
            sidebarMenu.MinimumSize = new System.Drawing.Size(71, 0);
            sidebarMenu.Name = "sidebarMenu";
            sidebarMenu.Size = new System.Drawing.Size(240, 789);
            sidebarMenu.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = BlogWinApp.Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(3, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(233, 184);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.Color.Teal;
            btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnLogout.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnLogout.Location = new System.Drawing.Point(0, 728);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(240, 61);
            btnLogout.TabIndex = 22;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnTotalBlog
            // 
            btnTotalBlog.BackColor = System.Drawing.Color.Teal;
            btnTotalBlog.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTotalBlog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnTotalBlog.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTotalBlog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnTotalBlog.Location = new System.Drawing.Point(0, 258);
            btnTotalBlog.Name = "btnTotalBlog";
            btnTotalBlog.Size = new System.Drawing.Size(240, 61);
            btnTotalBlog.TabIndex = 21;
            btnTotalBlog.Text = "Blog";
            btnTotalBlog.UseVisualStyleBackColor = false;
            btnTotalBlog.Click += btnTotalBlog_Click;
            // 
            // btnListAccount
            // 
            btnListAccount.BackColor = System.Drawing.Color.Teal;
            btnListAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            btnListAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnListAccount.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnListAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnListAccount.Location = new System.Drawing.Point(0, 191);
            btnListAccount.Name = "btnListAccount";
            btnListAccount.Size = new System.Drawing.Size(240, 61);
            btnListAccount.TabIndex = 20;
            btnListAccount.Text = "List Account";
            btnListAccount.UseVisualStyleBackColor = false;
            btnListAccount.Click += btnListAccount_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1369, 789);
            Controls.Add(panelUC);
            Controls.Add(topbarMenu);
            Controls.Add(sidebarMenu);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmAdmin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmAdmin";
            topbarMenu.ResumeLayout(false);
            topbarMenu.PerformLayout();
            sidebarMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelUC;
        private System.Windows.Forms.Panel topbarMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel sidebarMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnTotalBlog;
        private System.Windows.Forms.Button btnListAccount;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}