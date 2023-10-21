namespace Assignment_PRN_Team
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new System.Windows.Forms.Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconEmail = new FontAwesome.Sharp.IconButton();
            iconPassword = new FontAwesome.Sharp.IconButton();
            panel2 = new System.Windows.Forms.Panel();
            btnClose = new FontAwesome.Sharp.IconButton();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(iconPictureBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Right;
            panel1.Location = new System.Drawing.Point(417, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(308, 465);
            panel1.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            iconPictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("iconPictureBox1.BackgroundImage");
            iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 305;
            iconPictureBox1.Location = new System.Drawing.Point(3, 0);
            iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new System.Drawing.Size(305, 465);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            label1.Location = new System.Drawing.Point(120, 62);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(131, 47);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblEmail.Location = new System.Drawing.Point(32, 146);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(53, 18);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblPassword.Location = new System.Drawing.Point(32, 190);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(88, 18);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtEmail.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            txtEmail.Location = new System.Drawing.Point(142, 143);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new System.Drawing.Size(206, 18);
            txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            txtPassword.Location = new System.Drawing.Point(142, 187);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new System.Drawing.Size(206, 20);
            txtPassword.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            checkBox1.Location = new System.Drawing.Point(142, 228);
            checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(104, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = System.Drawing.Color.Teal;
            iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            iconButton1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            iconButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = System.Drawing.Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new System.Drawing.Point(70, 280);
            iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new System.Drawing.Size(252, 44);
            iconButton1.TabIndex = 9;
            iconButton1.Text = "Login";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            iconButton2.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            iconButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = System.Drawing.Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new System.Drawing.Point(94, 328);
            iconButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new System.Drawing.Size(204, 22);
            iconButton2.TabIndex = 10;
            iconButton2.Text = "Register";
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconEmail
            // 
            iconEmail.Enabled = false;
            iconEmail.FlatAppearance.BorderSize = 0;
            iconEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconEmail.IconChar = FontAwesome.Sharp.IconChar.User;
            iconEmail.IconColor = System.Drawing.Color.WhiteSmoke;
            iconEmail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEmail.IconSize = 23;
            iconEmail.Location = new System.Drawing.Point(10, 143);
            iconEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            iconEmail.Name = "iconEmail";
            iconEmail.Size = new System.Drawing.Size(24, 25);
            iconEmail.TabIndex = 12;
            iconEmail.UseVisualStyleBackColor = true;
            // 
            // iconPassword
            // 
            iconPassword.Enabled = false;
            iconPassword.FlatAppearance.BorderSize = 0;
            iconPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPassword.IconColor = System.Drawing.Color.WhiteSmoke;
            iconPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPassword.IconSize = 20;
            iconPassword.Location = new System.Drawing.Point(10, 187);
            iconPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            iconPassword.Name = "iconPassword";
            iconPassword.Size = new System.Drawing.Size(24, 25);
            iconPassword.TabIndex = 13;
            iconPassword.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            panel2.Controls.Add(btnClose);
            panel2.Location = new System.Drawing.Point(-1, 0);
            panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(726, 17);
            panel2.TabIndex = 14;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.DarkSlateGray;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            btnClose.IconColor = System.Drawing.Color.WhiteSmoke;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnClose.IconSize = 20;
            btnClose.Location = new System.Drawing.Point(694, -10);
            btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(32, 40);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.White;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(142, 162);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(206, 2);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.White;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(142, 206);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(206, 2);
            label3.TabIndex = 15;
            label3.Text = "label3";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ClientSize = new System.Drawing.Size(725, 465);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(iconPassword);
            Controls.Add(iconEmail);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(checkBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximumSize = new System.Drawing.Size(725, 465);
            MinimumSize = new System.Drawing.Size(725, 457);
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmLogin";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox checkBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconEmail;
        private FontAwesome.Sharp.IconButton iconPassword;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}