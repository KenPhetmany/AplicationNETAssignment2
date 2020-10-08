using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment2
    {
    public partial class TextEditor : Form
        {
        public TextEditor(string username, string userType)
            {
            InitializeComponent();
            InitializeFontSize();
            }

        private void InitializeFontSize(){
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
                }
            }

        private void saveBtn_Click(object sender, EventArgs e)
            {

            }

        private void saveAsBtn_Click(object sender, EventArgs e)
            {

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

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
            {

            }
        }
    }