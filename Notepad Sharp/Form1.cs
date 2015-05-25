/*******************************************************************************************
 *  Author: Randy Laird                                                                    *
 *  Project: Notepad in C#                                                                 *
 *  Date: 5/22/2015                                                                        *                                                                                     *
 *******************************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace Notepad_Sharp
{
    public partial class Notepad : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        System.Drawing.Printing.PrintDocument prntDoc = new System.Drawing.Printing.PrintDocument();
        List<string> WordList = new List<string>();
        SpeechRecognizer sr = new SpeechRecognizer();
        Choices words = new Choices();
            
        public Notepad()
        {
            InitializeComponent();

            // Drag and drop event handlers
            this.AllowDrop = true;
            this.rtbMainText.DragDrop += new DragEventHandler(DragDrop_Form);


            // Load all the fonts under FontFamily.Families
            for (int x = 0; x < FontFamily.Families.Length; x++)
            {
                menuComboBoxFonts.Items.Add(FontFamily.Families[x].Name);
            }
            menuComboBoxFonts.Text = menuComboBoxFonts.Items[0].ToString();

            // StreamReader to open the English Word list containing over 65,000 words
            System.IO.StreamReader read = new System.IO.StreamReader(@"Dictionary.txt");
            bool IsReading = true;
            while (IsReading == true)
            {
                // Iterates through the entire Dictionary.txt word list and stores them in a List<string> WordList.
                // To be loaded into the Choices words for the GrammarBuilder to load into the SpeechRecognizer
                WordList.Add(read.ReadLine());
                if (read.EndOfStream == true)
                {
                    // Close the reading stream
                    read.Close();
                    // Escape the while loop
                    IsReading = false;
                }           
            }
            // If the WordList received words, then proceed
            if (WordList.Count != 0)
            {
                foreach (string word in WordList)
                {
                    // Take the value of each string and add them into the Choices words;
                    words.Add(word.ToString());
                }
            }
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(words);

            DictationGrammar g = new DictationGrammar();
            g.Enabled = true;

            sr.LoadGrammar(g);
            sr.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sr_SpeechRecognized);
        }
        #region Menu Items
        // New File
        private void menuNew_Click(object sender, EventArgs e)
        {
            // Set notepad to clean slate
            rtbMainText.Clear();
        }
        // Open File
        private void menuOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            try
            {
                try
                {
                    rtbMainText.LoadFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    rtbMainText.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        // Save File
        private void menuSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbMainText.SaveFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save the file because the file is a new file.\nPlease use 'Save As' instead.", "Error");
            }
        }
        // Save a file to specific destination
        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            // open the saveFileDialog
            saveFileDialog.ShowDialog();
            rtbMainText.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
        }
        // Print
        private void menuPrint_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument prntDoc = new System.Drawing.Printing.PrintDocument();
        }
        // Print Preview
        private void menuPrintPreview_Click(object sender, EventArgs e)
        {
            // create new PrintPreviewDialog named preview
            PrintPreviewDialog preview = new PrintPreviewDialog();
            // assign the PrintPageEventHandler to prntDoc.PrintPage
            prntDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(prntDoc_PrintPage);
            // assign the prntDoc as the preview.Document
            preview.Document = prntDoc;
            //Show the print preview dialog
            if (preview.ShowDialog(this) == DialogResult.OK)
            {
                prntDoc.Print();
            }
        }
        // PrintPageEventHandler method.
        private void prntDoc_PrintPage(object sender, EventArgs e)
        {
            prntDoc.Print();
        }
        // Exit the program
        private void menuExit_Click(object sender, EventArgs e)
        {
            // Close the program
            Application.Exit();
        }
        // Undo button
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMainText.Undo();
        }
        // Cut tool
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMainText.Cut();
        }
        // Redo tool
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMainText.Redo();
        }
        // Copy tool
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMainText.Copy();
        }
        // Paste tool
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMainText.Paste();
        }
        // SelectAll tool
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMainText.SelectAll();
        }
        #endregion
        #region Text Formatting
        // Bold Button
        private void menuBold_Click(object sender, EventArgs e)
        {
            Font oldFont = rtbMainText.SelectionFont;
            FontStyle newFontStyle = new FontStyle();
            if (rtbMainText.SelectionFont.Bold == true)
            {
                newFontStyle = oldFont.Style ^ FontStyle.Bold;
            }
            else
            {
                newFontStyle = oldFont.Style | FontStyle.Bold;
            }
            rtbMainText.SelectionFont = new Font(
                oldFont.FontFamily,
                oldFont.Size,
                newFontStyle
            );
        }
        // Italic Button
        private void menuItalic_Click(object sender, EventArgs e)
        {
            Font oldFont = rtbMainText.SelectionFont;
            FontStyle newFontStyle = new FontStyle();
            if (rtbMainText.SelectionFont.Italic == true)
            {
                newFontStyle = oldFont.Style ^ FontStyle.Italic;
            }
            else
            {
                newFontStyle = oldFont.Style | FontStyle.Italic;
            }
            rtbMainText.SelectionFont = new Font(
                oldFont.FontFamily,
                oldFont.Size,
                newFontStyle
            );
        }
        // Underline Button
        private void menuUnderline_Click(object sender, EventArgs e)
        {
            Font oldFont = rtbMainText.SelectionFont;
            FontStyle newFontStyle = new FontStyle();
            if (rtbMainText.SelectionFont.Underline == true)
            {
                newFontStyle = oldFont.Style ^ FontStyle.Underline;
            }
            else
            {
                newFontStyle = oldFont.Style | FontStyle.Underline;
            }
            rtbMainText.SelectionFont = new Font(
                oldFont.FontFamily,
                oldFont.Size,
                newFontStyle
            );
        }
        // Lowercase Button
        private void menuLowerCase_Click(object sender, EventArgs e)
        {
            rtbMainText.SelectedText = rtbMainText.SelectedText.ToLower();
        }
        // Uppercase Button
        private void menuUpperCase_Click(object sender, EventArgs e)
        {
            rtbMainText.SelectedText = rtbMainText.SelectedText.ToUpper();
        }
        // Fontsize Button
        private void menuFontSize_Click(object sender, EventArgs e)
        {
            float fontSize = float.Parse(txtFontSize.Text);
            float currentSize = rtbMainText.Font.SizeInPoints;

            rtbMainText.Font = new Font(rtbMainText.Font.Name, fontSize,
                rtbMainText.Font.Style, rtbMainText.Font.Unit);
        }
        // Incrase Fontsize Button
        private void menuIncreaseFontSize_Click(object sender, EventArgs e)
        {
            float currentSize = rtbMainText.Font.SizeInPoints;
            rtbMainText.Font = new Font(rtbMainText.Font.Name, currentSize += 5,
                rtbMainText.Font.Style, rtbMainText.Font.Unit);
        }
        // Decrease Fontsize Button
        private void menuDecreaseFontSize_Click(object sender, EventArgs e)
        {
            float currentSize = rtbMainText.Font.SizeInPoints;
            try
            {
                rtbMainText.Font = new Font(rtbMainText.Font.Name, currentSize -= 5,
                    rtbMainText.Font.Style, rtbMainText.Font.Unit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        // Event Handler for selecting a Font Item from the DropDownList
        private void menuFonts_ItemSelected(Object sender, EventArgs e)
        {
            Font font = new Font(menuComboBoxFonts.SelectedItem.ToString(), menuFontSampleText.Font.SizeInPoints);
            // If text hasn't been selected then the Font will be applied to the preview text.
            if (rtbMainText.SelectedText == null)
            {
                menuFontSampleText.Font = font;
            }
            // If text has been selected the the Font will be applied to the selected text.
            else
            {
                rtbMainText.SelectionFont = font;
            }
        }
        // About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This notepad was created by Randy Laird on 5/22/2015", "About");
        }
        #endregion
        // Event handler for when Speech is recognized
        void sr_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            rtbMainText.AppendText(e.Result.Text + " ");
        }
        #region Drag and Drop
        // Event Handler for when a drag and drop is performed on the rtbMainText control
        void DragDrop_Form(object sender, DragEventArgs e)
        {
            // Store the FileDrop information into an object
            object filename = e.Data.GetData("FileDrop");
            if (filename != null)
            {
                var list = filename as string[];

                if (list != null && !string.IsNullOrWhiteSpace(list[0]))
                {
                    // try for RTF file format first
                    try
                    {
                        rtbMainText.Clear();
                        rtbMainText.LoadFile(list[0], RichTextBoxStreamType.RichText);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Drag and drop only works with .rtf files at this time.", "Error");
                    }
                }
            }
        }
        #endregion
    }
}
