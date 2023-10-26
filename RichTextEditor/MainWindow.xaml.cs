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
        public MainWindow()
        {
            InitializeComponent();

            ToolBarAdv dhhd = new ToolBarAdv();
            SfRichTextBoxAdv richTextBoxAdv = new SfRichTextBoxAdv();
            richTextBoxAdv.LayoutType = LayoutType.Continuous;

            WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }

        private void ButtonAdv_Click(object sender, RoutedEventArgs e)
        {
            richTextBoxAdv.Save("../../../SECRET/Posts/SE171871.docx");
            MessageBox.Show("DONE!");
            this.Close();
        }
    }
}