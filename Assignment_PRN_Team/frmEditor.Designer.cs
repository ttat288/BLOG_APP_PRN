using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Color = System.Drawing.Color;

namespace BlogWinApp
{
    partial class frmEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmEditor));
            richTextBox1 = new RichTextBox();
            richContextStrip = new ContextMenuStrip(components);
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            deleteStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            saveStripButton = new ToolStripButton();
            openFileStripButton = new ToolStripButton();
            toolStripSeparator10 = new ToolStripSeparator();
            printStripButton = new ToolStripButton();
            printPreviewStripButton = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            undoStripButton = new ToolStripButton();
            redoStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            fontStripComboBox = new ToolStripComboBox();
            fontSizeComboBox = new ToolStripComboBox();
            increaseStripButton = new ToolStripButton();
            decreaseStripButton = new ToolStripButton();
            colorStripDropDownButton = new ToolStripDropDownButton();
            changeCaseDropDownButton = new ToolStripDropDownButton();
            lowercaseToolStripMenuItem = new ToolStripMenuItem();
            uppercaseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator9 = new ToolStripSeparator();
            clearFormattingStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            boldStripButton3 = new ToolStripButton();
            italicStripButton = new ToolStripButton();
            underlineStripButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            leftAlignStripButton = new ToolStripButton();
            centerAlignStripButton = new ToolStripButton();
            rightAlignStripButton = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            bulletListStripButton = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            zoomDropDownButton = new ToolStripDropDownButton();
            toolStripSeparator12 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newMenuItem = new ToolStripMenuItem();
            OpenMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator11 = new ToolStripSeparator();
            printStripMenuItem = new ToolStripMenuItem();
            printPreviewStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            cutToolStripMenuItem1 = new ToolStripMenuItem();
            copyToolStripMenuItem1 = new ToolStripMenuItem();
            pasteToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem1 = new ToolStripMenuItem();
            clearAllToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            wordWrapToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorOptionsToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            printDialog = new PrintDialog();
            fontDialog1 = new FontDialog();
            printPreviewDialog = new PrintPreviewDialog();
            printDocument = new System.Drawing.Printing.PrintDocument();
            colorDialog1 = new ColorDialog();
            statusStrip1 = new StatusStrip();
            lineColumnStatusLabel = new ToolStripStatusLabel();
            cancel = new ToolStripButton();
            richContextStrip.SuspendLayout();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.ContextMenuStrip = richContextStrip;
            richTextBox1.Location = new Point(14, 75);
            richTextBox1.Margin = new Padding(4, 3, 4, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(985, 609);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.DragDrop += richTextBox1_DragDrop;
            richTextBox1.DragEnter += richTextBox1_DragEnter;
            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;
            richTextBox1.KeyUp += richTextBox1_KeyUp;
            richTextBox1.MouseDown += richTextBox1_MouseDown;
            // 
            // richContextStrip
            // 
            richContextStrip.ImageScalingSize = new Size(24, 24);
            richContextStrip.Items.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, deleteStripMenuItem, selectAllToolStripMenuItem, clearToolStripMenuItem });
            richContextStrip.Name = "richContextStrip";
            richContextStrip.Size = new Size(165, 136);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(164, 22);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(164, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(164, 22);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // deleteStripMenuItem
            // 
            deleteStripMenuItem.Name = "deleteStripMenuItem";
            deleteStripMenuItem.ShortcutKeys = Keys.Delete;
            deleteStripMenuItem.Size = new Size(164, 22);
            deleteStripMenuItem.Text = "Delete";
            deleteStripMenuItem.Click += deleteStripMenuItem_Click;
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(164, 22);
            selectAllToolStripMenuItem.Text = "Select All";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(164, 22);
            clearToolStripMenuItem.Text = "Clear All";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 709);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1012, 6);
            panel2.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 8);
            panel1.TabIndex = 14;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { saveStripButton, openFileStripButton, toolStripSeparator10, printStripButton, printPreviewStripButton, toolStripSeparator5, undoStripButton, redoStripButton, toolStripSeparator1, fontStripComboBox, fontSizeComboBox, increaseStripButton, decreaseStripButton, colorStripDropDownButton, changeCaseDropDownButton, toolStripSeparator9, clearFormattingStripButton, toolStripSeparator2, boldStripButton3, italicStripButton, underlineStripButton, toolStripSeparator3, leftAlignStripButton, centerAlignStripButton, rightAlignStripButton, toolStripSeparator4, bulletListStripButton, toolStripSeparator8, zoomDropDownButton, toolStripSeparator12, toolStripButton1, cancel });
            toolStrip1.Location = new Point(0, 32);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1012, 31);
            toolStrip1.TabIndex = 16;
            toolStrip1.Text = "toolStrip1";
            // 
            // saveStripButton
            // 
            saveStripButton.BackgroundImageLayout = ImageLayout.Zoom;
            saveStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveStripButton.Image = Properties.Resources.floppy_disk__1_;
            saveStripButton.ImageTransparentColor = Color.Magenta;
            saveStripButton.Name = "saveStripButton";
            saveStripButton.Size = new Size(28, 28);
            saveStripButton.Text = "Save File";
            saveStripButton.Click += saveStripButton_Click;
            // 
            // openFileStripButton
            // 
            openFileStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openFileStripButton.Image = Properties.Resources.open;
            openFileStripButton.ImageTransparentColor = Color.Magenta;
            openFileStripButton.Name = "openFileStripButton";
            openFileStripButton.Size = new Size(28, 28);
            openFileStripButton.Text = "Open File";
            openFileStripButton.Click += openFileStripButton_Click;
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(6, 31);
            // 
            // printStripButton
            // 
            printStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printStripButton.Image = Properties.Resources.printer;
            printStripButton.ImageTransparentColor = Color.Magenta;
            printStripButton.Name = "printStripButton";
            printStripButton.Size = new Size(28, 28);
            printStripButton.Text = "Print Page";
            printStripButton.Click += printStripButton_Click;
            // 
            // printPreviewStripButton
            // 
            printPreviewStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printPreviewStripButton.Image = Properties.Resources.preview;
            printPreviewStripButton.ImageTransparentColor = Color.Magenta;
            printPreviewStripButton.Name = "printPreviewStripButton";
            printPreviewStripButton.Size = new Size(28, 28);
            printPreviewStripButton.Text = "Print Preview";
            printPreviewStripButton.Click += printPreviewStripButton_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 31);
            // 
            // undoStripButton
            // 
            undoStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            undoStripButton.Image = Properties.Resources.back_arrow;
            undoStripButton.ImageTransparentColor = Color.Magenta;
            undoStripButton.Name = "undoStripButton";
            undoStripButton.Size = new Size(28, 28);
            undoStripButton.Text = "Undo Move";
            undoStripButton.Click += undoStripButton_Click;
            // 
            // redoStripButton
            // 
            redoStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            redoStripButton.Image = Properties.Resources.share;
            redoStripButton.ImageTransparentColor = Color.Magenta;
            redoStripButton.Name = "redoStripButton";
            redoStripButton.Size = new Size(28, 28);
            redoStripButton.Text = "Redo Move";
            redoStripButton.Click += redoStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // fontStripComboBox
            // 
            fontStripComboBox.Name = "fontStripComboBox";
            fontStripComboBox.Size = new Size(180, 31);
            fontStripComboBox.Sorted = true;
            fontStripComboBox.Text = "Font Family";
            fontStripComboBox.ToolTipText = "Font Family";
            fontStripComboBox.SelectedIndexChanged += fontStripComboBox_SelectedIndexChanged;
            // 
            // fontSizeComboBox
            // 
            fontSizeComboBox.AutoSize = false;
            fontSizeComboBox.Name = "fontSizeComboBox";
            fontSizeComboBox.Size = new Size(84, 23);
            fontSizeComboBox.Text = "Font Size";
            fontSizeComboBox.ToolTipText = "Font Size";
            fontSizeComboBox.SelectedIndexChanged += fontSizeComboBox_SelectedIndexChanged;
            // 
            // increaseStripButton
            // 
            increaseStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            increaseStripButton.Image = Properties.Resources.resize_font__1_;
            increaseStripButton.ImageTransparentColor = Color.Magenta;
            increaseStripButton.Name = "increaseStripButton";
            increaseStripButton.Size = new Size(28, 28);
            increaseStripButton.Text = "Increase Font Size";
            increaseStripButton.Click += increaseStripButton_Click;
            // 
            // decreaseStripButton
            // 
            decreaseStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            decreaseStripButton.Image = Properties.Resources.resize_font;
            decreaseStripButton.ImageTransparentColor = Color.Magenta;
            decreaseStripButton.Name = "decreaseStripButton";
            decreaseStripButton.Size = new Size(28, 28);
            decreaseStripButton.Text = "Decrease Font Size";
            decreaseStripButton.Click += decreaseStripButton_Click;
            // 
            // colorStripDropDownButton
            // 
            colorStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            colorStripDropDownButton.Image = Properties.Resources.font__1_;
            colorStripDropDownButton.ImageTransparentColor = Color.Magenta;
            colorStripDropDownButton.Name = "colorStripDropDownButton";
            colorStripDropDownButton.Size = new Size(37, 28);
            colorStripDropDownButton.Text = "Font Color";
            colorStripDropDownButton.DropDownItemClicked += colorStripDropDownButton_DropDownItemClicked;
            // 
            // changeCaseDropDownButton
            // 
            changeCaseDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            changeCaseDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { lowercaseToolStripMenuItem, uppercaseToolStripMenuItem });
            changeCaseDropDownButton.Image = Properties.Resources.change;
            changeCaseDropDownButton.ImageTransparentColor = Color.Magenta;
            changeCaseDropDownButton.Name = "changeCaseDropDownButton";
            changeCaseDropDownButton.Size = new Size(37, 28);
            changeCaseDropDownButton.Text = "Change Case";
            // 
            // lowercaseToolStripMenuItem
            // 
            lowercaseToolStripMenuItem.Name = "lowercaseToolStripMenuItem";
            lowercaseToolStripMenuItem.Size = new Size(137, 22);
            lowercaseToolStripMenuItem.Text = "&lowercase";
            lowercaseToolStripMenuItem.Click += lowercaseToolStripMenuItem_Click;
            // 
            // uppercaseToolStripMenuItem
            // 
            uppercaseToolStripMenuItem.Name = "uppercaseToolStripMenuItem";
            uppercaseToolStripMenuItem.Size = new Size(137, 22);
            uppercaseToolStripMenuItem.Text = "&UPPERCASE";
            uppercaseToolStripMenuItem.Click += uppercaseToolStripMenuItem_Click;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(6, 31);
            // 
            // clearFormattingStripButton
            // 
            clearFormattingStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            clearFormattingStripButton.Image = Properties.Resources.eraser;
            clearFormattingStripButton.ImageTransparentColor = Color.Magenta;
            clearFormattingStripButton.Name = "clearFormattingStripButton";
            clearFormattingStripButton.Size = new Size(28, 28);
            clearFormattingStripButton.Text = "Clear All Formatting";
            clearFormattingStripButton.Click += clearFormattingStripButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 31);
            // 
            // boldStripButton3
            // 
            boldStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            boldStripButton3.Image = Properties.Resources.font_style_bold;
            boldStripButton3.ImageTransparentColor = Color.Magenta;
            boldStripButton3.Name = "boldStripButton3";
            boldStripButton3.Size = new Size(28, 28);
            boldStripButton3.Text = "Bold";
            boldStripButton3.Click += boldStripButton3_Click;
            // 
            // italicStripButton
            // 
            italicStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            italicStripButton.Image = Properties.Resources.italic;
            italicStripButton.ImageTransparentColor = Color.Magenta;
            italicStripButton.Name = "italicStripButton";
            italicStripButton.Size = new Size(28, 28);
            italicStripButton.Text = "Italics";
            italicStripButton.Click += italicStripButton_Click;
            // 
            // underlineStripButton
            // 
            underlineStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            underlineStripButton.Image = Properties.Resources.document;
            underlineStripButton.ImageTransparentColor = Color.Magenta;
            underlineStripButton.Name = "underlineStripButton";
            underlineStripButton.Size = new Size(28, 28);
            underlineStripButton.Text = "Underline";
            underlineStripButton.Click += underlineStripButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 31);
            // 
            // leftAlignStripButton
            // 
            leftAlignStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            leftAlignStripButton.Image = Properties.Resources.align_left;
            leftAlignStripButton.ImageTransparentColor = Color.Magenta;
            leftAlignStripButton.Name = "leftAlignStripButton";
            leftAlignStripButton.Size = new Size(28, 28);
            leftAlignStripButton.Text = "Left Align";
            leftAlignStripButton.Click += leftAlignStripButton_Click;
            // 
            // centerAlignStripButton
            // 
            centerAlignStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            centerAlignStripButton.Image = Properties.Resources.format;
            centerAlignStripButton.ImageTransparentColor = Color.Magenta;
            centerAlignStripButton.Name = "centerAlignStripButton";
            centerAlignStripButton.Size = new Size(28, 28);
            centerAlignStripButton.Text = "Center Align";
            centerAlignStripButton.Click += centerAlignStripButton_Click;
            // 
            // rightAlignStripButton
            // 
            rightAlignStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            rightAlignStripButton.Image = Properties.Resources.align_right;
            rightAlignStripButton.ImageTransparentColor = Color.Magenta;
            rightAlignStripButton.Name = "rightAlignStripButton";
            rightAlignStripButton.Size = new Size(28, 28);
            rightAlignStripButton.Text = "Right Align";
            rightAlignStripButton.Click += rightAlignStripButton_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 31);
            // 
            // bulletListStripButton
            // 
            bulletListStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bulletListStripButton.Image = Properties.Resources.list;
            bulletListStripButton.ImageTransparentColor = Color.Magenta;
            bulletListStripButton.Name = "bulletListStripButton";
            bulletListStripButton.Size = new Size(28, 28);
            bulletListStripButton.Text = "Bullet List";
            bulletListStripButton.Click += bulletListStripButton_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 31);
            // 
            // zoomDropDownButton
            // 
            zoomDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            zoomDropDownButton.Image = Properties.Resources.zoom_in;
            zoomDropDownButton.ImageTransparentColor = Color.Magenta;
            zoomDropDownButton.Name = "zoomDropDownButton";
            zoomDropDownButton.Size = new Size(37, 28);
            zoomDropDownButton.Text = "Zoom Factor";
            zoomDropDownButton.DropDownItemClicked += zoomDropDownButton_DropDownItemClicked;
            // 
            // toolStripSeparator12
            // 
            toolStripSeparator12.Name = "toolStripSeparator12";
            toolStripSeparator12.Size = new Size(6, 31);
            // 
            // toolStripButton1
            // 
            toolStripButton1.AutoSize = false;
            toolStripButton1.BackColor = SystemColors.ButtonFace;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.paper_plane;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Overflow = ToolStripItemOverflow.Never;
            toolStripButton1.Size = new Size(60, 28);
            toolStripButton1.Text = "publish";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 8);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 1, 0, 1);
            menuStrip1.Size = new Size(1012, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newMenuItem, OpenMenuItem, saveToolStripMenuItem, toolStripSeparator11, printStripMenuItem, printPreviewStripMenuItem, toolStripSeparator7, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 22);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newMenuItem
            // 
            newMenuItem.Name = "newMenuItem";
            newMenuItem.Size = new Size(143, 22);
            newMenuItem.Text = "&New";
            newMenuItem.Click += newMenuItem_Click;
            // 
            // OpenMenuItem
            // 
            OpenMenuItem.Name = "OpenMenuItem";
            OpenMenuItem.Size = new Size(143, 22);
            OpenMenuItem.Text = "&Open";
            OpenMenuItem.Click += OpenMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(143, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new Size(140, 6);
            // 
            // printStripMenuItem
            // 
            printStripMenuItem.Name = "printStripMenuItem";
            printStripMenuItem.Size = new Size(143, 22);
            printStripMenuItem.Text = "&Print";
            printStripMenuItem.Click += printStripMenuItem_Click;
            // 
            // printPreviewStripMenuItem
            // 
            printPreviewStripMenuItem.Name = "printPreviewStripMenuItem";
            printPreviewStripMenuItem.Size = new Size(143, 22);
            printPreviewStripMenuItem.Text = "P&rint Preview";
            printPreviewStripMenuItem.Click += printPreviewStripMenuItem_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(140, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(143, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator6, cutToolStripMenuItem1, copyToolStripMenuItem1, pasteToolStripMenuItem1, deleteToolStripMenuItem, selectAllToolStripMenuItem1, clearAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 22);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(164, 22);
            undoToolStripMenuItem.Text = "&Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(164, 22);
            redoToolStripMenuItem.Text = "&Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(161, 6);
            // 
            // cutToolStripMenuItem1
            // 
            cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            cutToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem1.Size = new Size(164, 22);
            cutToolStripMenuItem1.Text = "&Cut";
            cutToolStripMenuItem1.Click += cutToolStripMenuItem1_Click;
            // 
            // copyToolStripMenuItem1
            // 
            copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            copyToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem1.Size = new Size(164, 22);
            copyToolStripMenuItem1.Text = "C&opy";
            copyToolStripMenuItem1.Click += copyToolStripMenuItem1_Click;
            // 
            // pasteToolStripMenuItem1
            // 
            pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            pasteToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem1.Size = new Size(164, 22);
            pasteToolStripMenuItem1.Text = "&Paste";
            pasteToolStripMenuItem1.Click += pasteToolStripMenuItem1_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            deleteToolStripMenuItem.Size = new Size(164, 22);
            deleteToolStripMenuItem.Text = "&Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // selectAllToolStripMenuItem1
            // 
            selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            selectAllToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem1.Size = new Size(164, 22);
            selectAllToolStripMenuItem1.Text = "&Select All";
            selectAllToolStripMenuItem1.Click += selectAllToolStripMenuItem1_Click;
            // 
            // clearAllToolStripMenuItem
            // 
            clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            clearAllToolStripMenuItem.Size = new Size(164, 22);
            clearAllToolStripMenuItem.Text = "C&lear All";
            clearAllToolStripMenuItem.Click += clearAllToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wordWrapToolStripMenuItem, fontToolStripMenuItem, colorOptionsToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 22);
            formatToolStripMenuItem.Text = "Fo&rmat";
            // 
            // wordWrapToolStripMenuItem
            // 
            wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            wordWrapToolStripMenuItem.Size = new Size(148, 22);
            wordWrapToolStripMenuItem.Text = "&WordWrap";
            wordWrapToolStripMenuItem.Click += wordWrapToolStripMenuItem_Click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(148, 22);
            fontToolStripMenuItem.Text = "&Font...";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // colorOptionsToolStripMenuItem
            // 
            colorOptionsToolStripMenuItem.Name = "colorOptionsToolStripMenuItem";
            colorOptionsToolStripMenuItem.Size = new Size(148, 22);
            colorOptionsToolStripMenuItem.Text = "&Color Options";
            colorOptionsToolStripMenuItem.Click += colorOptionsToolStripMenuItem_Click;
            // 
            // printDialog
            // 
            printDialog.UseEXDialog = true;
            // 
            // fontDialog1
            // 
            fontDialog1.Apply += fontDialog1_Apply;
            fontDialog1.HelpRequest += fontDialog1_HelpRequest;
            // 
            // printPreviewDialog
            // 
            printPreviewDialog.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Enabled = true;
            printPreviewDialog.Icon = (Icon)resources.GetObject("printPreviewDialog.Icon");
            printPreviewDialog.Name = "printPreviewDialog";
            printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // colorDialog1
            // 
            colorDialog1.HelpRequest += colorDialog1_HelpRequest;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lineColumnStatusLabel });
            statusStrip1.Location = new Point(0, 687);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1012, 22);
            statusStrip1.TabIndex = 19;
            statusStrip1.Text = "statusStrip1";
            // 
            // lineColumnStatusLabel
            // 
            lineColumnStatusLabel.Name = "lineColumnStatusLabel";
            lineColumnStatusLabel.Size = new Size(995, 17);
            lineColumnStatusLabel.Spring = true;
            lineColumnStatusLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cancel
            // 
            cancel.AutoSize = false;
            cancel.BackColor = SystemColors.ButtonFace;
            cancel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cancel.Image = Properties.Resources.man;
            cancel.ImageTransparentColor = Color.Magenta;
            cancel.Name = "cancel";
            cancel.Overflow = ToolStripItemOverflow.Never;
            cancel.Size = new Size(60, 28);
            cancel.Text = "cancel";
            cancel.Click += cancel_Click;
            // 
            // frmEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 715);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmEditor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Rich Text Editor";
            Load += frmEditor_Load;
            richContextStrip.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Panel panel2;
        private Panel panel1;
        private ContextMenuStrip richContextStrip;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton saveStripButton;
        private ToolStripButton openFileStripButton;
        private ToolStripComboBox fontStripComboBox;
        private ToolStripComboBox fontSizeComboBox;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton boldStripButton3;
        private ToolStripButton italicStripButton;
        private ToolStripButton underlineStripButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripDropDownButton colorStripDropDownButton;
        private ToolStripButton leftAlignStripButton;
        private ToolStripButton centerAlignStripButton;
        private ToolStripButton rightAlignStripButton;
        private OpenFileDialog openFileDialog1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton increaseStripButton;
        private ToolStripButton decreaseStripButton;
        private ToolStripButton bulletListStripButton;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton undoStripButton;
        private ToolStripButton redoStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem cutToolStripMenuItem1;
        private ToolStripMenuItem copyToolStripMenuItem1;
        private ToolStripMenuItem pasteToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem1;
        private ToolStripMenuItem clearAllToolStripMenuItem;
        private ToolStripMenuItem OpenMenuItem;
        private ToolStripMenuItem deleteStripMenuItem;
        private ToolStripMenuItem newMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripDropDownButton changeCaseDropDownButton;
        private ToolStripMenuItem lowercaseToolStripMenuItem;
        private ToolStripMenuItem uppercaseToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem wordWrapToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private FontDialog fontDialog1;
        private ToolStripDropDownButton zoomDropDownButton;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripButton clearFormattingStripButton;
        private PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripButton printStripButton;
        private ToolStripButton printPreviewStripButton;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripMenuItem printStripMenuItem;
        private ToolStripMenuItem printPreviewStripMenuItem;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem colorOptionsToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lineColumnStatusLabel;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripButton toolStripButton1;
        private ToolStripButton cancel;
    }
}


