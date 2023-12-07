using Aspose.Words;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace BlogWinApp
{
    public partial class frmReadDoc : Form
    {
        string postID;

        public frmReadDoc(string id)
        {
            InitializeComponent();
            postID = id;
        }

        private void frmReadDoc_Load(object sender, EventArgs e)
        {

            string filenamee = $"../../../../SECRET/Posts/{postID}.doc";
            // load the file into the richTextBox
            //richTextBox1.LoadFile(filenamee, RichTextBoxStreamType.PlainText);    // loads it in regular text format
            richTextBox1.LoadFile(filenamee, RichTextBoxStreamType.RichText);    // loads it in RTB format

            //string docFilePath = $"../../../../SECRET/Posts/{postID}.doc";
            //string pdfFilePath = "../../../../SECRET/Posts/DontRemove.pdf";
            //ConvertDocToPdf(docFilePath, pdfFilePath);
            //pdfViewer1.LoadDocument(docFilePath);
        }

        //static void ConvertDocToPdf(string docFilePath, string pdfFilePath)
        //{
        //    try
        //    {
        //        Document doc = new Document(docFilePath);

        //        // Kiểm tra xem tệp PDF đã tồn tại hay không
        //        if (File.Exists(pdfFilePath))
        //        {
        //            // Nếu tồn tại, xóa tệp PDF cũ
        //            File.Delete(pdfFilePath);
        //        }

        //        doc.Save(pdfFilePath, SaveFormat.Pdf);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Xử lý ngoại lệ nếu cần
        //        Console.WriteLine($"Lỗi khi chuyển đổi: {ex.Message}");
        //    }
        //}
    }
}
