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
            lblTitle = new System.Windows.Forms.Label();
            txtTitle = new Krypton.Toolkit.KryptonRichTextBox();
            txtContent = new Krypton.Toolkit.KryptonRichTextBox();
            lblContent = new System.Windows.Forms.Label();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            pictureBox = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(txtContent);
            panel1.Controls.Add(lblContent);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(944, 163);
            panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblTitle.Location = new System.Drawing.Point(54, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(54, 24);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTitle.Location = new System.Drawing.Point(147, 15);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(662, 47);
            txtTitle.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            txtTitle.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTitle.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtTitle.StateCommon.Border.Rounding = 20F;
            txtTitle.StateCommon.Border.Width = 3;
            txtTitle.TabIndex = 1;
            txtTitle.Text = "Enter Title Here";
            txtTitle.Enter += txtTitle_Enter;
            // 
            // txtContent
            // 
            txtContent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtContent.Location = new System.Drawing.Point(147, 83);
            txtContent.Name = "txtContent";
            txtContent.Size = new System.Drawing.Size(662, 77);
            txtContent.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            txtContent.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtContent.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtContent.StateCommon.Border.Rounding = 20F;
            txtContent.StateCommon.Border.Width = 3;
            txtContent.TabIndex = 2;
            txtContent.Text = "Enter Content Here";
            txtContent.Enter += txtContent_Enter;
            // 
            // lblContent
            // 
            lblContent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblContent.AutoSize = true;
            lblContent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblContent.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblContent.Location = new System.Drawing.Point(54, 83);
            lblContent.Name = "lblContent";
            lblContent.Size = new System.Drawing.Size(89, 24);
            lblContent.TabIndex = 3;
            lblContent.Text = "Content";
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = 20F;
            kryptonButton1.Location = new System.Drawing.Point(369, 461);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new System.Drawing.Size(224, 56);
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
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBox.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox.BackgroundImage");
            pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox.Location = new System.Drawing.Point(147, 41);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(662, 367);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox);
            panel2.Controls.Add(kryptonButton1);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 163);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(944, 532);
            panel2.TabIndex = 2;
            // 
            // frmNewBlog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Teal;
            ClientSize = new System.Drawing.Size(944, 695);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmNewBlog";
            Text = "frmNewBlog";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.PictureBox pictureBox;
        private Krypton.Toolkit.KryptonRichTextBox txtContent;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonRichTextBox txtTitle;
    }
}