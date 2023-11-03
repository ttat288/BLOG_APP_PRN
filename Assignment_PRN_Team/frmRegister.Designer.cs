namespace BlogWinApp
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            panel2 = new System.Windows.Forms.Panel();
            lblExit = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            btnRegister = new System.Windows.Forms.Button();
            registerBtn = new System.Windows.Forms.LinkLabel();
            label4 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            avatar = new System.Windows.Forms.PictureBox();
            lblChangeAvatar = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            txtFullname = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            selectMajor = new System.Windows.Forms.ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            panel2.Controls.Add(lblExit);
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(726, 17);
            panel2.TabIndex = 27;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblExit.Location = new System.Drawing.Point(705, -5);
            lblExit.Name = "lblExit";
            lblExit.Size = new System.Drawing.Size(24, 25);
            lblExit.TabIndex = 0;
            lblExit.Text = "X";
            lblExit.Click += lblExit_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtEmail.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            txtEmail.Location = new System.Drawing.Point(66, 289);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter email";
            txtEmail.Size = new System.Drawing.Size(296, 19);
            txtEmail.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            label1.Location = new System.Drawing.Point(112, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(197, 47);
            label1.TabIndex = 23;
            label1.Text = "Register";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label5.Location = new System.Drawing.Point(29, 283);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(33, 25);
            label5.TabIndex = 33;
            label5.Text = "✉";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = System.Drawing.Color.Teal;
            btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnRegister.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnRegister.Location = new System.Drawing.Point(34, 472);
            btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(326, 46);
            btnRegister.TabIndex = 32;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // registerBtn
            // 
            registerBtn.AutoSize = true;
            registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            registerBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            registerBtn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            registerBtn.LinkColor = System.Drawing.Color.FromArgb(192, 192, 255);
            registerBtn.Location = new System.Drawing.Point(200, 552);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new System.Drawing.Size(69, 15);
            registerBtn.TabIndex = 31;
            registerBtn.TabStop = true;
            registerBtn.Text = "Log in here!";
            registerBtn.VisitedLinkColor = System.Drawing.Color.FromArgb(128, 128, 255);
            registerBtn.LinkClicked += registerBtn_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label4.Location = new System.Drawing.Point(115, 552);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 15);
            label4.TabIndex = 30;
            label4.Text = "Have account?";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(393, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(333, 558);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.White;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(34, 308);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(325, 2);
            label2.TabIndex = 22;
            label2.Text = "label2";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtPassword.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            txtPassword.Location = new System.Drawing.Point(66, 324);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter password";
            txtPassword.Size = new System.Drawing.Size(294, 19);
            txtPassword.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label8.Location = new System.Drawing.Point(28, 318);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(33, 25);
            label8.TabIndex = 37;
            label8.Text = "🔒";
            // 
            // label9
            // 
            label9.BackColor = System.Drawing.Color.White;
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(36, 343);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(325, 2);
            label9.TabIndex = 36;
            label9.Text = "label9";
            // 
            // avatar
            // 
            avatar.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            avatar.Location = new System.Drawing.Point(170, 69);
            avatar.Name = "avatar";
            avatar.Size = new System.Drawing.Size(72, 72);
            avatar.TabIndex = 38;
            avatar.TabStop = false;
            // 
            // lblChangeAvatar
            // 
            lblChangeAvatar.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            lblChangeAvatar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblChangeAvatar.Location = new System.Drawing.Point(170, 69);
            lblChangeAvatar.Name = "lblChangeAvatar";
            lblChangeAvatar.Size = new System.Drawing.Size(72, 72);
            lblChangeAvatar.TabIndex = 39;
            lblChangeAvatar.Text = "Click here to change avatar";
            lblChangeAvatar.Click += lblChangeAvatar_Click;
            // 
            // txtID
            // 
            txtID.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtID.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtID.ForeColor = System.Drawing.Color.WhiteSmoke;
            txtID.Location = new System.Drawing.Point(66, 252);
            txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "Enter id \"SE123456\"";
            txtID.Size = new System.Drawing.Size(296, 19);
            txtID.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label10.Location = new System.Drawing.Point(29, 246);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(33, 25);
            label10.TabIndex = 42;
            label10.Text = "✉";
            // 
            // label11
            // 
            label11.BackColor = System.Drawing.Color.White;
            label11.ForeColor = System.Drawing.Color.White;
            label11.Location = new System.Drawing.Point(34, 271);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(325, 2);
            label11.TabIndex = 40;
            label11.Text = "label11";
            // 
            // txtFullname
            // 
            txtFullname.BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFullname.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFullname.ForeColor = System.Drawing.Color.WhiteSmoke;
            txtFullname.Location = new System.Drawing.Point(67, 214);
            txtFullname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtFullname.Name = "txtFullname";
            txtFullname.PlaceholderText = "Enter full name";
            txtFullname.Size = new System.Drawing.Size(296, 19);
            txtFullname.TabIndex = 44;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label12.Location = new System.Drawing.Point(30, 208);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(33, 25);
            label12.TabIndex = 45;
            label12.Text = "✉";
            // 
            // label13
            // 
            label13.BackColor = System.Drawing.Color.White;
            label13.ForeColor = System.Drawing.Color.White;
            label13.Location = new System.Drawing.Point(35, 233);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(325, 2);
            label13.TabIndex = 43;
            label13.Text = "label13";
            // 
            // selectMajor
            // 
            selectMajor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            selectMajor.FormattingEnabled = true;
            selectMajor.Items.AddRange(new object[] { "Software Engineering", "Artificial Intelligence", "Information Security", "Digital Design", "Digital Marketing", "International Bussiness", "Hotel Management", "English Studies", "Chinese Studies", "Korean Studies", "Japanese Studies" });
            selectMajor.Location = new System.Drawing.Point(36, 374);
            selectMajor.Name = "selectMajor";
            selectMajor.Size = new System.Drawing.Size(326, 29);
            selectMajor.TabIndex = 46;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 64, 64);
            ClientSize = new System.Drawing.Size(726, 576);
            Controls.Add(selectMajor);
            Controls.Add(txtFullname);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(txtID);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(lblChangeAvatar);
            Controls.Add(avatar);
            Controls.Add(txtPassword);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(btnRegister);
            Controls.Add(registerBtn);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmRegister";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmRegister";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel registerBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label lblChangeAvatar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox selectMajor;
    }
}