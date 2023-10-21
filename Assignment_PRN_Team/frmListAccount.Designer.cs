namespace Assignment_PRN_Team
{
    partial class frmListAccount
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
            panelButton = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            panelButton.SuspendLayout();
            SuspendLayout();
            // 
            // panelButton
            // 
            panelButton.Controls.Add(kryptonButton1);
            panelButton.Dock = System.Windows.Forms.DockStyle.Right;
            panelButton.Location = new System.Drawing.Point(897, 0);
            panelButton.Name = "panelButton";
            panelButton.Size = new System.Drawing.Size(173, 624);
            panelButton.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(897, 114);
            panel1.TabIndex = 1;
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = 20F;
            kryptonButton1.Location = new System.Drawing.Point(29, 121);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new System.Drawing.Size(141, 44);
            kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.Teal;
            kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(0, 192, 192);
            kryptonButton1.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.Rounding = 20F;
            kryptonButton1.TabIndex = 2;
            kryptonButton1.Values.Text = "Submit";
            // 
            // frmListAccount
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Teal;
            ClientSize = new System.Drawing.Size(1070, 624);
            Controls.Add(panel1);
            Controls.Add(panelButton);
            Name = "frmListAccount";
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "frmListAccount";
            panelButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}