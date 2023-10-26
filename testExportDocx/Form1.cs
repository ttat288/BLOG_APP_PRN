using System;
using System.IO;
using System.Windows.Forms;
using Spire.Doc;
using Patagames.Pdf.Net.Controls.WinForms;
using Patagames.Pdf.Net;
using GrapeCity.Documents.Word;

namespace testExportDocx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var doc = new GcWordDocument();
            doc.Load("../../../../SECRET/Posts/SE171871.docx");
            doc.SaveAsPdf("test.pdf");

            string pdfFilePath = "test.pdf";

            if (File.Exists(pdfFilePath))
            {
                // Kiểm tra nếu PdfViewer đã được tạo
                if (pdfViewer != null)
                {
                    // Nếu đã có PdfViewer, dispose và tạo lại
                    pdfViewer.Dispose();
                }

                // Tạo mới PdfViewer
                pdfViewer = new PdfViewer();
                pdfViewer.Dock = DockStyle.Fill;

                // Thêm PdfViewer vào form
                Controls.Add(pdfViewer);

                // Hiển thị nội dung PDF
                pdfViewer.LoadDocument(pdfFilePath);
            }

        }
    }
}
