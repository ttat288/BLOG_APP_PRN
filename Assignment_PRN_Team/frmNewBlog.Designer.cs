namespace Assignment_PRN_Team
{
    partial class frmNewBlog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewBlog));
            panel1 = new System.Windows.Forms.Panel();
            majorSelector = new System.Windows.Forms.ComboBox();
            txtTitle = new System.Windows.Forms.TextBox();
            txtSubject = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtContent = new Krypton.Toolkit.KryptonRichTextBox();
            panel2 = new System.Windows.Forms.Panel();
            pictureBox = new System.Windows.Forms.PictureBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(majorSelector);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(txtSubject);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtContent);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(988, 159);
            panel1.TabIndex = 1;
            // 
            // majorSelector
            // 
            majorSelector.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            majorSelector.FormattingEnabled = true;
            majorSelector.Items.AddRange(new object[] { "#Software Engineering", "#Artificial Intelligence", "#Information Security", "#Digital Design", "#Digital Marketing", "#International Bussiness", "#Hotel Management", "#English Studies", "#Chinese Studies", "#Korean Studies", "#Japanese Studies" });
            majorSelector.Location = new System.Drawing.Point(760, 19);
            majorSelector.Name = "majorSelector";
            majorSelector.Size = new System.Drawing.Size(208, 33);
            majorSelector.TabIndex = 8;
            // 
            // txtTitle
            // 
            txtTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTitle.Location = new System.Drawing.Point(150, 19);
            txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtTitle.MaxLength = 3000;
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new System.Drawing.Size(604, 32);
            txtTitle.TabIndex = 7;
            // 
            // txtSubject
            // 
            txtSubject.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSubject.Location = new System.Drawing.Point(32, 19);
            txtSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtSubject.MaxLength = 8;
            txtSubject.Name = "txtSubject";
            txtSubject.PlaceholderText = "Subject";
            txtSubject.Size = new System.Drawing.Size(72, 32);
            txtSubject.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(109, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 45);
            label1.TabIndex = 4;
            label1.Text = "/";
            // 
            // txtContent
            // 
            txtContent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtContent.Location = new System.Drawing.Point(21, 64);
            txtContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtContent.Name = "txtContent";
            txtContent.Size = new System.Drawing.Size(947, 95);
            txtContent.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            txtContent.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtContent.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtContent.StateCommon.Border.Rounding = 20F;
            txtContent.StateCommon.Border.Width = 3;
            txtContent.TabIndex = 2;
            txtContent.Text = "";
            txtContent.TextChanged += txtContent_TextChanged_1;
            txtContent.Enter += txtContent_Enter;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox);
            panel2.Controls.Add(kryptonButton1);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 159);
            panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(988, 470);
            panel2.TabIndex = 4;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBox.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox.BackgroundImage");
            pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox.Location = new System.Drawing.Point(21, 25);
            pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(947, 390);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click_1;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            kryptonButton1.CornerRoundingRadius = 20F;
            kryptonButton1.Location = new System.Drawing.Point(391, 419);
            kryptonButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new System.Drawing.Size(218, 49);
            kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(192, 255, 255);
            kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.Cyan;
            kryptonButton1.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(224, 224, 224);
            kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateCommon.Border.Rounding = 20F;
            kryptonButton1.StateCommon.Border.Width = 3;
            kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            kryptonButton1.TabIndex = 0;
            kryptonButton1.Values.Text = "Submit";
            kryptonButton1.Click += kryptonButton1_Click_1;
            // 
            // frmNewBlog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Teal;
            ClientSize = new System.Drawing.Size(988, 629);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmNewBlog";
            Text = "frmNewBlog";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonRichTextBox txtContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox majorSelector;
    }
}