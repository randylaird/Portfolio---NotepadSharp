namespace Notepad_Sharp
{
    partial class Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSpeechToText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuBold = new System.Windows.Forms.ToolStripLabel();
            this.menuItalic = new System.Windows.Forms.ToolStripLabel();
            this.menuUnderline = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuLowerCase = new System.Windows.Forms.ToolStripLabel();
            this.menuUpperCase = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFontSize = new System.Windows.Forms.ToolStripLabel();
            this.txtFontSize = new System.Windows.Forms.ToolStripTextBox();
            this.menuIncreaseFontSize = new System.Windows.Forms.ToolStripButton();
            this.menuDecreaseFontSize = new System.Windows.Forms.ToolStripButton();
            this.menuComboBoxFonts = new System.Windows.Forms.ToolStripComboBox();
            this.menuPreviewText = new System.Windows.Forms.ToolStripLabel();
            this.menuFontSampleText = new System.Windows.Forms.ToolStripLabel();
            this.rtbMainText = new System.Windows.Forms.RichTextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuAbout,
            this.menuSpeechToText});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1337, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.toolStripSeparator,
            this.menuSave,
            this.menuSaveAs,
            this.toolStripSeparator2,
            this.menuPrint,
            this.menuPrintPreview,
            this.toolStripSeparator3,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 25);
            this.menuFile.Text = "&File";
            // 
            // menuNew
            // 
            this.menuNew.Image = ((System.Drawing.Image)(resources.GetObject("menuNew.Image")));
            this.menuNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuNew.Name = "menuNew";
            this.menuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNew.Size = new System.Drawing.Size(176, 26);
            this.menuNew.Text = "&New";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuOpen.Image")));
            this.menuOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpen.Size = new System.Drawing.Size(176, 26);
            this.menuOpen.Text = "&Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(173, 6);
            // 
            // menuSave
            // 
            this.menuSave.Image = ((System.Drawing.Image)(resources.GetObject("menuSave.Image")));
            this.menuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSave.Name = "menuSave";
            this.menuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSave.Size = new System.Drawing.Size(176, 26);
            this.menuSave.Text = "&Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(176, 26);
            this.menuSaveAs.Text = "Save &As";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // menuPrint
            // 
            this.menuPrint.Image = ((System.Drawing.Image)(resources.GetObject("menuPrint.Image")));
            this.menuPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuPrint.Name = "menuPrint";
            this.menuPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuPrint.Size = new System.Drawing.Size(176, 26);
            this.menuPrint.Text = "&Print";
            this.menuPrint.Click += new System.EventHandler(this.menuPrint_Click);
            // 
            // menuPrintPreview
            // 
            this.menuPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("menuPrintPreview.Image")));
            this.menuPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuPrintPreview.Name = "menuPrintPreview";
            this.menuPrintPreview.Size = new System.Drawing.Size(176, 26);
            this.menuPrintPreview.Text = "Print Pre&view";
            this.menuPrintPreview.Click += new System.EventHandler(this.menuPrintPreview_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(173, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(176, 26);
            this.menuExit.Text = "E&xit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUndo,
            this.menuRedo,
            this.toolStripSeparator4,
            this.menuCut,
            this.menuCopy,
            this.menuPaste,
            this.toolStripSeparator5,
            this.menuSelectAll});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(48, 25);
            this.menuEdit.Text = "&Edit";
            // 
            // menuUndo
            // 
            this.menuUndo.Name = "menuUndo";
            this.menuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuUndo.Size = new System.Drawing.Size(173, 26);
            this.menuUndo.Text = "&Undo";
            this.menuUndo.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // menuRedo
            // 
            this.menuRedo.Name = "menuRedo";
            this.menuRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.menuRedo.Size = new System.Drawing.Size(173, 26);
            this.menuRedo.Text = "&Redo";
            this.menuRedo.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(170, 6);
            // 
            // menuCut
            // 
            this.menuCut.Image = ((System.Drawing.Image)(resources.GetObject("menuCut.Image")));
            this.menuCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuCut.Name = "menuCut";
            this.menuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuCut.Size = new System.Drawing.Size(173, 26);
            this.menuCut.Text = "Cu&t";
            this.menuCut.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // menuCopy
            // 
            this.menuCopy.Image = ((System.Drawing.Image)(resources.GetObject("menuCopy.Image")));
            this.menuCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuCopy.Name = "menuCopy";
            this.menuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuCopy.Size = new System.Drawing.Size(173, 26);
            this.menuCopy.Text = "&Copy";
            this.menuCopy.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // menuPaste
            // 
            this.menuPaste.Image = ((System.Drawing.Image)(resources.GetObject("menuPaste.Image")));
            this.menuPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuPaste.Name = "menuPaste";
            this.menuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuPaste.Size = new System.Drawing.Size(173, 26);
            this.menuPaste.Text = "&Paste";
            this.menuPaste.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(170, 6);
            // 
            // menuSelectAll
            // 
            this.menuSelectAll.Name = "menuSelectAll";
            this.menuSelectAll.Size = new System.Drawing.Size(173, 26);
            this.menuSelectAll.Text = "Select &All";
            this.menuSelectAll.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(64, 25);
            this.menuAbout.Text = "&About";
            this.menuAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuSpeechToText
            // 
            this.menuSpeechToText.Name = "menuSpeechToText";
            this.menuSpeechToText.Size = new System.Drawing.Size(122, 25);
            this.menuSpeechToText.Text = "Speech to Text";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Lavender;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBold,
            this.menuItalic,
            this.menuUnderline,
            this.toolStripSeparator1,
            this.menuLowerCase,
            this.menuUpperCase,
            this.toolStripSeparator6,
            this.menuFontSize,
            this.txtFontSize,
            this.menuIncreaseFontSize,
            this.menuDecreaseFontSize,
            this.menuComboBoxFonts,
            this.menuPreviewText,
            this.menuFontSampleText});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1337, 26);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuBold
            // 
            this.menuBold.Name = "menuBold";
            this.menuBold.Size = new System.Drawing.Size(36, 19);
            this.menuBold.Text = "&Bold";
            this.menuBold.Click += new System.EventHandler(this.menuBold_Click);
            // 
            // menuItalic
            // 
            this.menuItalic.Name = "menuItalic";
            this.menuItalic.Size = new System.Drawing.Size(43, 19);
            this.menuItalic.Text = "&Italics";
            this.menuItalic.Click += new System.EventHandler(this.menuItalic_Click);
            // 
            // menuUnderline
            // 
            this.menuUnderline.Name = "menuUnderline";
            this.menuUnderline.Size = new System.Drawing.Size(68, 19);
            this.menuUnderline.Text = "&Underline";
            this.menuUnderline.Click += new System.EventHandler(this.menuUnderline_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // menuLowerCase
            // 
            this.menuLowerCase.Name = "menuLowerCase";
            this.menuLowerCase.Size = new System.Drawing.Size(79, 19);
            this.menuLowerCase.Text = "&Lower Case";
            this.menuLowerCase.Click += new System.EventHandler(this.menuLowerCase_Click);
            // 
            // menuUpperCase
            // 
            this.menuUpperCase.Name = "menuUpperCase";
            this.menuUpperCase.Size = new System.Drawing.Size(80, 19);
            this.menuUpperCase.Text = "Upp&er Case";
            this.menuUpperCase.Click += new System.EventHandler(this.menuUpperCase_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
            // 
            // menuFontSize
            // 
            this.menuFontSize.Name = "menuFontSize";
            this.menuFontSize.Size = new System.Drawing.Size(64, 19);
            this.menuFontSize.Text = "Font Size";
            this.menuFontSize.Click += new System.EventHandler(this.menuFontSize_Click);
            // 
            // txtFontSize
            // 
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(25, 23);
            this.txtFontSize.Text = "12";
            // 
            // menuIncreaseFontSize
            // 
            this.menuIncreaseFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuIncreaseFontSize.Image = ((System.Drawing.Image)(resources.GetObject("menuIncreaseFontSize.Image")));
            this.menuIncreaseFontSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuIncreaseFontSize.Name = "menuIncreaseFontSize";
            this.menuIncreaseFontSize.Size = new System.Drawing.Size(23, 23);
            this.menuIncreaseFontSize.Text = "+";
            this.menuIncreaseFontSize.ToolTipText = "&+";
            this.menuIncreaseFontSize.Click += new System.EventHandler(this.menuIncreaseFontSize_Click);
            // 
            // menuDecreaseFontSize
            // 
            this.menuDecreaseFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuDecreaseFontSize.Image = ((System.Drawing.Image)(resources.GetObject("menuDecreaseFontSize.Image")));
            this.menuDecreaseFontSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuDecreaseFontSize.Name = "menuDecreaseFontSize";
            this.menuDecreaseFontSize.Size = new System.Drawing.Size(23, 23);
            this.menuDecreaseFontSize.Text = "-";
            this.menuDecreaseFontSize.ToolTipText = "&-";
            this.menuDecreaseFontSize.Click += new System.EventHandler(this.menuDecreaseFontSize_Click);
            // 
            // menuComboBoxFonts
            // 
            this.menuComboBoxFonts.Name = "menuComboBoxFonts";
            this.menuComboBoxFonts.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.menuComboBoxFonts.Size = new System.Drawing.Size(121, 23);
            this.menuComboBoxFonts.SelectedIndexChanged += new System.EventHandler(this.menuFonts_ItemSelected);
            // 
            // menuPreviewText
            // 
            this.menuPreviewText.Name = "menuPreviewText";
            this.menuPreviewText.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.menuPreviewText.Size = new System.Drawing.Size(0, 0);
            // 
            // menuFontSampleText
            // 
            this.menuFontSampleText.Name = "menuFontSampleText";
            this.menuFontSampleText.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.menuFontSampleText.Size = new System.Drawing.Size(114, 19);
            this.menuFontSampleText.Text = "Font Sample Text";
            // 
            // rtbMainText
            // 
            this.rtbMainText.AcceptsTab = true;
            this.rtbMainText.AutoWordSelection = true;
            this.rtbMainText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMainText.EnableAutoDragDrop = true;
            this.rtbMainText.Location = new System.Drawing.Point(0, 55);
            this.rtbMainText.Name = "rtbMainText";
            this.rtbMainText.Size = new System.Drawing.Size(1337, 559);
            this.rtbMainText.TabIndex = 2;
            this.rtbMainText.Text = "";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 614);
            this.Controls.Add(this.rtbMainText);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Notepad";
            this.Text = "N#tepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuPrint;
        private System.Windows.Forms.ToolStripMenuItem menuPrintPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuUndo;
        private System.Windows.Forms.ToolStripMenuItem menuRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuCut;
        private System.Windows.Forms.ToolStripMenuItem menuCopy;
        private System.Windows.Forms.ToolStripMenuItem menuPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuSelectAll;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel menuBold;
        private System.Windows.Forms.ToolStripLabel menuItalic;
        private System.Windows.Forms.ToolStripLabel menuUnderline;
        private System.Windows.Forms.ToolStripLabel menuLowerCase;
        private System.Windows.Forms.ToolStripLabel menuUpperCase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RichTextBox rtbMainText;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel menuFontSize;
        private System.Windows.Forms.ToolStripTextBox txtFontSize;
        private System.Windows.Forms.ToolStripButton menuIncreaseFontSize;
        private System.Windows.Forms.ToolStripButton menuDecreaseFontSize;
        private System.Windows.Forms.ToolStripComboBox menuComboBoxFonts;
        private System.Windows.Forms.ToolStripLabel menuPreviewText;
        private System.Windows.Forms.ToolStripLabel menuFontSampleText;
        private System.Windows.Forms.ToolStripMenuItem menuSpeechToText;
    }
}

