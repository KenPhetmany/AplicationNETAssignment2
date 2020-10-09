using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace assignment2
    {
    public partial class TextEditor : Form
        {
        string fileName = "";

        public TextEditor(string username, string userType)

            {
            InitializeComponent();
            InitializeFontSize();
            if (userType == "View")
                {
                richTextBox.ReadOnly = true;
                }
            }

        private void InitializeFontSize()
            {
            fontComboBox.Items.Add(8);
            fontComboBox.Items.Add(10);
            fontComboBox.Items.Add(12);
            fontComboBox.Items.Add(14);
            fontComboBox.Items.Add(16);
            fontComboBox.Items.Add(18);
            }

        private void newBtn_Click(object sender, EventArgs e)
            {
            richTextBox.Clear();
            }

        private void openBtn_Click(object sender, EventArgs e)
            {
            if (openFile.ShowDialog() == DialogResult.OK)
                {
                richTextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
                fileName = openFile.FileName;
                }
            }

        private void saveBtn_Click(object sender, EventArgs e)
            {
            }

        private void saveAsBtn_Click(object sender, EventArgs e)
            {
            if (saveFile.ShowDialog() == DialogResult.OK)
                {
                try
                    {
                    richTextBox.SaveFile(saveFile.FileName,
                   RichTextBoxStreamType.PlainText);
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                    }
                }
            }

        private void boldBtn_Click(object sender, System.EventArgs e)
            {
            richTextBox.SelectionFont = new Font(this.Font, FontStyle.Bold);
            }

        private void italicsBtn_Click(object sender, EventArgs e)
            {
            richTextBox.SelectionFont = new Font(this.Font, FontStyle.Italic);
            }

        private void underlineBtn_Click(object sender, EventArgs e)
            {
            richTextBox.SelectionFont = new Font(this.Font, FontStyle.Underline);
            }

        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
            {
            var test = float.Parse(fontComboBox.Text);
            string fontName = richTextBox.SelectionFont.Name;
            richTextBox.SelectionFont = new Font(fontName, test);
            }

        private void toolStripButton1_Click(object sender, EventArgs e)
            {
            richTextBox.Cut();
            }

        private void toolStripButton2_Click(object sender, EventArgs e)
            {
            richTextBox.Copy();
            }

        private void toolStripButton3_Click(object sender, EventArgs e)
            {
            richTextBox.Paste();
            }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
            {
            richTextBox.Cut();
            }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
            {
            richTextBox.Copy();
            }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
            {
            richTextBox.Paste();
            }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        private bool fileExists(string title)
            {
            string[] documents = Directory.GetFiles("documents");
            foreach (string i in documents)
            // Processes each value to check whether the input exists in the array string
                {
                if (i == "documents\\" + title + ".txt" || i == "documents\\" + title + ".rft")
                    {
                    return true;
                    }
                }
            return false;
            }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
            {
            richTextBox.Clear();
            }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
            {
            if (openFile.ShowDialog() == DialogResult.OK)
                {
                richTextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
                fileName = openFile.FileName;
                }
            }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
            {
            if (saveFile.ShowDialog() == DialogResult.OK)
                {
                try
                    {
                    richTextBox.SaveFile(saveFile.FileName,
                   RichTextBoxStreamType.PlainText);
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }