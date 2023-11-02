using Microsoft.Win32;
using Syncfusion.Windows.Controls.RichTextBoxAdv;
using Syncfusion.Windows.Tools.Controls;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace RichTextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string id;
        public MainWindow(string postID)
        {
            InitializeComponent();
            id = postID;

            ToolBarAdv dhhd = new ToolBarAdv();
            SfRichTextBoxAdv richTextBoxAdv = new SfRichTextBoxAdv();
            richTextBoxAdv.LayoutType = LayoutType.Continuous;

            WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }

        private void ButtonAdv_Click(object sender, RoutedEventArgs e)
        {
            richTextBoxAdv.Save($"../../../../SECRET/Posts/{id}.docx");
            MessageBox.Show("DONE!");
            this.Close();
        }
    }
}