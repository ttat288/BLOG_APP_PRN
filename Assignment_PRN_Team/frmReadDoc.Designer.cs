namespace BlogWinApp
{
    partial class frmReadDoc
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
            pdfViewer1 = new Patagames.Pdf.Net.Controls.WinForms.PdfViewer();
            SuspendLayout();
            // 
            // pdfViewer1
            // 
            pdfViewer1.BackColor = System.Drawing.SystemColors.ControlDark;
            pdfViewer1.CurrentIndex = -1;
            pdfViewer1.CurrentPageHighlightColor = System.Drawing.Color.FromArgb(170, 70, 130, 180);
            pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            pdfViewer1.Document = null;
            pdfViewer1.FormHighlightColor = System.Drawing.Color.Transparent;
            pdfViewer1.FormsBlendMode = Patagames.Pdf.Enums.BlendTypes.FXDIB_BLEND_MULTIPLY;
            pdfViewer1.LoadingIconText = "Loading...";
            pdfViewer1.Location = new System.Drawing.Point(0, 0);
            pdfViewer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pdfViewer1.MouseMode = Patagames.Pdf.Net.Controls.WinForms.MouseModes.Default;
            pdfViewer1.Name = "pdfViewer1";
            pdfViewer1.OptimizedLoadThreshold = 1000;
            pdfViewer1.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            pdfViewer1.PageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            pdfViewer1.PageAutoDispose = true;
            pdfViewer1.PageBackColor = System.Drawing.Color.White;
            pdfViewer1.PageBorderColor = System.Drawing.Color.Black;
            pdfViewer1.PageMargin = new System.Windows.Forms.Padding(10);
            pdfViewer1.PageSeparatorColor = System.Drawing.Color.Gray;
            pdfViewer1.RenderFlags = Patagames.Pdf.Enums.RenderFlags.FPDF_LCD_TEXT | Patagames.Pdf.Enums.RenderFlags.FPDF_NO_CATCH;
            pdfViewer1.ShowCurrentPageHighlight = true;
            pdfViewer1.ShowLoadingIcon = true;
            pdfViewer1.ShowPageSeparator = true;
            pdfViewer1.Size = new System.Drawing.Size(911, 803);
            pdfViewer1.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.FitToWidth;
            pdfViewer1.TabIndex = 0;
            pdfViewer1.TextSelectColor = System.Drawing.Color.FromArgb(70, 70, 130, 180);
            pdfViewer1.TilesCount = 2;
            pdfViewer1.UseProgressiveRender = true;
            pdfViewer1.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical;
            pdfViewer1.Zoom = 1F;
            // 
            // frmReadDoc
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(911, 803);
            Controls.Add(pdfViewer1);
            Name = "frmReadDoc";
            Text = "frmReadDoc";
            Load += frmReadDoc_Load;
            ResumeLayout(false);
        }

        #endregion

        private Patagames.Pdf.Net.Controls.WinForms.PdfViewer pdfViewer1;
    }
}