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
            label1 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            rememberCb = new System.Windows.Forms.CheckBox();
            loginBtn = new FontAwesome.Sharp.IconButton();
            iconEmail = new FontAwesome.Sharp.IconButton();
            iconPassword = new FontAwesome.Sharp.IconButton();
            panel2 = new System.Windows.Forms.Panel();
            btnClose = new FontAwesome.Sharp.IconButton();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            registerBtn = new System.Windows.Forms.LinkLabel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            label1.Location = new System.Drawing.Point(162, 83);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(164, 59);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtEmail.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            txtEmail.Location = new System.Drawing.Point(83, 244);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter email";
            txtEmail.Size = new System.Drawing.Size(343, 24);
            txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtPassword.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            txtPassword.Location = new System.Drawing.Point(83, 328);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter password";
            txtPassword.Size = new System.Drawing.Size(343, 24);
            txtPassword.TabIndex = 7;
            // 
            // rememberCb
            // 
            rememberCb.AutoSize = true;
            rememberCb.ForeColor = System.Drawing.Color.WhiteSmoke;
            rememberCb.Location = new System.Drawing.Point(287, 373);
            rememberCb.Name = "rememberCb";
            rememberCb.Size = new System.Drawing.Size(129, 24);
            rememberCb.TabIndex = 8;
            rememberCb.Text = "Remember me";
            rememberCb.UseVisualStyleBackColor = true;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = System.Drawing.Color.Teal;
            loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            loginBtn.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            loginBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            loginBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            loginBtn.IconColor = System.Drawing.Color.Black;
            loginBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            loginBtn.Location = new System.Drawing.Point(58, 412);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new System.Drawing.Size(358, 49);
            loginBtn.TabIndex = 9;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
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
            iconEmail.Location = new System.Drawing.Point(53, 239);
            iconEmail.Name = "iconEmail";
            iconEmail.Size = new System.Drawing.Size(27, 33);
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
            iconPassword.Location = new System.Drawing.Point(53, 323);
            iconPassword.Name = "iconPassword";
            iconPassword.Size = new System.Drawing.Size(27, 33);
            iconPassword.TabIndex = 13;
            iconPassword.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            panel2.Controls.Add(btnClose);
            panel2.Location = new System.Drawing.Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(830, 23);
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
            btnClose.Location = new System.Drawing.Point(793, -13);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(37, 53);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.White;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(57, 269);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(371, 3);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.White;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(59, 353);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(371, 3);
            label3.TabIndex = 15;
            label3.Text = "label3";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(480, 23);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(349, 599);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label4.Location = new System.Drawing.Point(142, 555);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(113, 20);
            label4.TabIndex = 17;
            label4.Text = "Not a member?";
            // 
            // registerBtn
            // 
            registerBtn.AutoSize = true;
            registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            registerBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            registerBtn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            registerBtn.LinkColor = System.Drawing.Color.FromArgb(192, 192, 255);
            registerBtn.Location = new System.Drawing.Point(239, 555);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new System.Drawing.Size(100, 20);
            registerBtn.TabIndex = 18;
            registerBtn.TabStop = true;
            registerBtn.Text = "Register here!";
            registerBtn.VisitedLinkColor = System.Drawing.Color.FromArgb(128, 128, 255);
            registerBtn.LinkClicked += registerBtn_LinkClicked;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ClientSize = new System.Drawing.Size(829, 620);
            ControlBox = false;
            Controls.Add(registerBtn);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(iconPassword);
            Controls.Add(iconEmail);
            Controls.Add(loginBtn);
            Controls.Add(rememberCb);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximumSize = new System.Drawing.Size(829, 620);
            MinimumSize = new System.Drawing.Size(829, 609);
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox rememberCb;
        private FontAwesome.Sharp.IconButton loginBtn;
        private FontAwesome.Sharp.IconButton iconEmail;
        private FontAwesome.Sharp.IconButton iconPassword;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel registerBtn;
    }
}