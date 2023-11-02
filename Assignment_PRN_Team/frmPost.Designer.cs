namespace BlogWinApp
{
    partial class frmPost
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
            pnlPost = new System.Windows.Forms.FlowLayoutPanel();
            SuspendLayout();
            // 
            // pnlPost
            // 
            pnlPost.AutoScroll = true;
            pnlPost.Location = new System.Drawing.Point(0, 0);
            pnlPost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlPost.Name = "pnlPost";
            pnlPost.Size = new System.Drawing.Size(1126, 737);
            pnlPost.TabIndex = 1;
            pnlPost.SizeChanged += postform_sizechanged;
            // 
            // frmPost
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1126, 737);
            Controls.Add(pnlPost);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmPost";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmPost";
            Load += frmPost_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlPost;
    }
}