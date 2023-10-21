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
            pictureBox = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            txtTitle = new Krypton.Toolkit.KryptonRichTextBox();
            txtContent = new Krypton.Toolkit.KryptonRichTextBox();
            panel3 = new System.Windows.Forms.Panel();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            lblContent = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1108, 154);
            panel1.TabIndex = 1;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBox.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox.BackgroundImage");
            pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox.Location = new System.Drawing.Point(333, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(368, 154);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTitle);
            panel2.Controls.Add(txtContent);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lblContent);
            panel2.Controls.Add(lblTitle);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 154);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1108, 433);
            panel2.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTitle.Location = new System.Drawing.Point(158, 22);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(725, 46);
            txtTitle.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            txtTitle.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTitle.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtTitle.StateCommon.Border.Rounding = 20F;
            txtTitle.StateCommon.Border.Width = 3;
            txtTitle.TabIndex = 7;
            txtTitle.Text = "Enter Title Here";
            txtTitle.Enter += txtTitle_Enter;
            // 
            // txtContent
            // 
            txtContent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtContent.Location = new System.Drawing.Point(158, 89);
            txtContent.Name = "txtContent";
            txtContent.Size = new System.Drawing.Size(725, 312);
            txtContent.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            txtContent.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtContent.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtContent.StateCommon.Border.Rounding = 20F;
            txtContent.StateCommon.Border.Width = 3;
            txtContent.TabIndex = 6;
            txtContent.Text = "Enter Content Here";
            txtContent.Enter += txtContent_Enter;
            // 
            // panel3
            // 
            panel3.Controls.Add(kryptonButton2);
            panel3.Controls.Add(kryptonButton1);
            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Location = new System.Drawing.Point(963, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(145, 433);
            panel3.TabIndex = 5;
            // 
            // kryptonButton2
            // 
            kryptonButton2.CornerRoundingRadius = 20F;
            kryptonButton2.Location = new System.Drawing.Point(3, 89);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new System.Drawing.Size(142, 46);
            kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(192, 255, 255);
            kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.Cyan;
            kryptonButton2.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(224, 224, 224);
            kryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            kryptonButton2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton2.StateCommon.Border.Rounding = 20F;
            kryptonButton2.StateCommon.Border.Width = 3;
            kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            kryptonButton2.TabIndex = 1;
            kryptonButton2.Values.Text = "Reset";
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = 20F;
            kryptonButton1.Location = new System.Drawing.Point(3, 22);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new System.Drawing.Size(142, 46);
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
            // 
            // lblContent
            // 
            lblContent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblContent.AutoSize = true;
            lblContent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblContent.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblContent.Location = new System.Drawing.Point(57, 89);
            lblContent.Name = "lblContent";
            lblContent.Size = new System.Drawing.Size(89, 24);
            lblContent.TabIndex = 3;
            lblContent.Text = "Content";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblTitle.Location = new System.Drawing.Point(57, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(54, 24);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            // 
            // frmNewBlog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Teal;
            ClientSize = new System.Drawing.Size(1108, 587);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmNewBlog";
            Text = "frmNewBlog";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel3;
        private Krypton.Toolkit.KryptonRichTextBox txtContent;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonRichTextBox txtTitle;
    }
}