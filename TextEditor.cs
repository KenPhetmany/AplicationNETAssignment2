using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace assignment2
    {
    public partial class TextEditor : Form
        {
        private string fileName = "";

        public TextEditor(string username, string userType)

            {
            InitializeComponent();
            InitializeFontSize();
            userNameTitle.Text = "Username: " + username;
            userTypeTitle.Text = "User type: " + userType;
            if (userType == "View")
                {
                richTextBox.ReadOnly = false;
                }
            }

        private void InitializeFontSize()
            {
            for (int i = 8; i <= 20; i++)
                {
                fontComboBox.Items.Add(i);
                }
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
                fileName = Path.GetFileName(openFile.FileName);
                }
            }

        private void saveBtn_Click(object sender, EventArgs e)
            {
            if (fileExists(fileName))
                {
                string path = "documents\\" + fileName;
                richTextBox.SaveFile(path, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Saving at: " + fileName);
                }
            else
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

        private void cutBtn_Click(object sender, EventArgs e)
            {
            richTextBox.Cut();
            }

        private void copyBtn_Click(object sender, EventArgs e)
            {
            richTextBox.Copy();
            }

        private void pasteBtn_Click(object sender, EventArgs e)
            {
            richTextBox.Paste();
            }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
            {
            if (openFile.ShowDialog() == DialogResult.OK)
                {
                richTextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
                fileName = openFile.FileName;
                }
            }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
            {
            if (fileExists(fileName))
                {
                string path = "documents\\" + fileName;
                richTextBox.SaveFile(path, RichTextBoxStreamType.RichText);
                MessageBox.Show("Saving at: " + fileName);
                }
            else
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
            {
            Application.Exit();
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
            {
            richTextBox.Clear();
            }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
            {
            string message = "98042183";
            MessageBox.Show(message, "About");
            }

        private bool fileExists(string title)
            {
            string[] documents = Directory.GetFiles("documents");
            foreach (string i in documents)
            // Processes each value to check whether the input exists in the array string
                {
                if (i == "documents\\" + title || i == "documents\\" + title)
                    {
                    return true;
                    }
                }
            return false;
            }
        }
    }