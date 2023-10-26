namespace testExportDocx
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pdfViewer = new Patagames.Pdf.Net.Controls.WinForms.PdfViewer();
            SuspendLayout();
            // 
            // pdfViewer
            // 
            pdfViewer.BackColor = System.Drawing.SystemColors.ControlDark;
            pdfViewer.CurrentIndex = -1;
            pdfViewer.CurrentPageHighlightColor = System.Drawing.Color.FromArgb(170, 70, 130, 180);
            pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            pdfViewer.Document = null;
            pdfViewer.FormHighlightColor = System.Drawing.Color.Transparent;
            pdfViewer.FormsBlendMode = Patagames.Pdf.Enums.BlendTypes.FXDIB_BLEND_MULTIPLY;
            pdfViewer.LoadingIconText = "Loading...";
            pdfViewer.Location = new System.Drawing.Point(0, 0);
            pdfViewer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            pdfViewer.MouseMode = Patagames.Pdf.Net.Controls.WinForms.MouseModes.Default;
            pdfViewer.Name = "pdfViewer";
            pdfViewer.OptimizedLoadThreshold = 1000;
            pdfViewer.Padding = new System.Windows.Forms.Padding(14, 16, 14, 16);
            pdfViewer.PageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            pdfViewer.PageAutoDispose = true;
            pdfViewer.PageBackColor = System.Drawing.Color.White;
            pdfViewer.PageBorderColor = System.Drawing.Color.Black;
            pdfViewer.PageMargin = new System.Windows.Forms.Padding(10);
            pdfViewer.PageSeparatorColor = System.Drawing.Color.Gray;
            pdfViewer.RenderFlags = Patagames.Pdf.Enums.RenderFlags.FPDF_LCD_TEXT | Patagames.Pdf.Enums.RenderFlags.FPDF_NO_CATCH;
            pdfViewer.ShowCurrentPageHighlight = true;
            pdfViewer.ShowLoadingIcon = true;
            pdfViewer.ShowPageSeparator = true;
            pdfViewer.Size = new System.Drawing.Size(1179, 939);
            pdfViewer.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.FitToWidth;
            pdfViewer.TabIndex = 3;
            pdfViewer.TextSelectColor = System.Drawing.Color.FromArgb(70, 70, 130, 180);
            pdfViewer.TilesCount = 2;
            pdfViewer.UseProgressiveRender = true;
            pdfViewer.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical;
            pdfViewer.Zoom = 1F;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1179, 939);
            Controls.Add(pdfViewer);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Patagames.Pdf.Net.Controls.WinForms.PdfViewer pdfViewer;
    }
}
