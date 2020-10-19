using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace assignment2
    {
    public partial class TextEditor : Form
        {
        public string fileName = "";

        //Gets the name of the current file to keep track
        //Some parameters that are passed down to be used
        public TextEditor(string username, string userType)
            {
            InitializeComponent();
            InitializeFontSize();
            //Displays the user's username and their user type
            userNameTitle.Text = "Username: " + username;
            userTypeTitle.Text = "User type: " + userType;
            toolStripFileName.Text = "File Name: " + fileName;
            //Sets the view or edit options depending on user
            if (userType == "View")
                {
                richTextBox.ReadOnly = true;
                }
            }

        //Initializes the fontComboBox by flooding in integers.
        private void InitializeFontSize()
            {
            for (int i = 8; i <= 20; i++)
                {
                fontComboBox.Items.Add(i);
                }
            }

        //Creates a new file
        private void newBtn_Click(object sender, EventArgs e)
            {
            //Resets the rich text box and filename
            richTextBox.Clear();
            fileName = "";
            toolStripFileName.Text = "File Name: " + fileName;
            }

        //Opens a txt.file from the document folder
        private void openBtn_Click(object sender, EventArgs e)
            {
            if (openFile.ShowDialog() == DialogResult.OK)
                {
                //Opens the selected textfile as a rich text
                richTextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.RichText);
                //Gets the file name to keep track of
                fileName = Path.GetFileName(openFile.FileName);
                toolStripFileName.Text = "File Name: " + fileName;
                }
            }

        //Saves the current file, whether it is new or not
        private void saveBtn_Click(object sender, EventArgs e)
            {
            //Checks if the current file already exists.
            if (fileExists(fileName))
                {
                string path = "documents\\" + fileName;
                //If the file exists, then it overrwrites the current file and floods it with new changes
                richTextBox.SaveFile(path, RichTextBoxStreamType.RichText);
                toolStripFileName.Text = "File Name: " + fileName;
                }
            else
                {
                //If the current file does not exists, then it will be saved as a new file
                if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                    try
                        {
                        //File is saved with the user input on the file name
                        richTextBox.SaveFile(saveFile.FileName,
                       RichTextBoxStreamType.RichText);
                        fileName = Path.GetFileName(saveFile.FileName);
                        toolStripFileName.Text = "File Name:" + fileName;
                        }
                    catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message);
                        }
                    }
                }
            }

        //Saves the file as a brand new file regardless whether it is new or not.
        private void saveAsBtn_Click(object sender, EventArgs e)
            {
            if (saveFile.ShowDialog() == DialogResult.OK)
                {
                try
                    {
                    //File is saved with the user input on the file name
                    richTextBox.SaveFile(saveFile.FileName,
                    RichTextBoxStreamType.RichText);
                    fileName = Path.GetFileName(saveFile.FileName);
                    toolStripFileName.Text = "File Name: " + fileName;
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                    }
                }
            }

        //Makes the selected or future text bold
        private void boldBtn_Click(object sender, System.EventArgs e)
            {
            //The XOR function adds/removes the setting so every other font style is maintained
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold ^ richTextBox.SelectionFont.Style);
            }

        //Makes the selected or future text italics
        private void italicsBtn_Click(object sender, EventArgs e)
            {
            //The XOR function adds/removes the setting so every other font style is maintained
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Italic ^ richTextBox.SelectionFont.Style);
            }

        //Makes the selected or future text underlined
        private void underlineBtn_Click(object sender, EventArgs e)
            {
            //The XOR function adds/removes the setting so every other font style is maintained
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Underline ^ richTextBox.SelectionFont.Style);
            }

        //Updates the font size of the current or future text
        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
            {
            //Gets the current value from the combobox
            var test = int.Parse(fontComboBox.Text);
            //Gets the current selection of the text
            string fontName = richTextBox.SelectionFont.Name;
            Font font = richTextBox.SelectionFont;
            //Sets the text with the new font size
            richTextBox.SelectionFont = new Font(fontName, test, font.Style);
            }

        //Cuts a selection of the text
        private void cutBtn_Click(object sender, EventArgs e)
            {
            richTextBox.Cut();
            }

        //Copies a selection of the text
        private void copyBtn_Click(object sender, EventArgs e)
            {
            richTextBox.Copy();
            }

        //Pastes a selection of the text
        private void pasteBtn_Click(object sender, EventArgs e)
            {
            richTextBox.Paste();
            }

        //Opens a txt.file from the document folder
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
            {
            if (openFile.ShowDialog() == DialogResult.OK)
                {
                //Opens the selected textfile as a rich text
                richTextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.RichText);
                //Gets the file name to keep track of
                fileName = openFile.FileName;
                toolStripFileName.Text = "File Name: " + fileName;
                }
            }

        //Saves the current file, whether it is new or not
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
            {
            if (fileExists(fileName))
                {
                //If the file exists, then it overrwrites the current file and floods it with new changes
                string path = "documents\\" + fileName;
                richTextBox.SaveFile(path, RichTextBoxStreamType.RichText);
                toolStripFileName.Text = "File Name: " + fileName;
                }
            else
                {
                //If the current file does not exists, then it will be saved as a new file
                if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                    try
                        {
                        //File is saved with the user input on the file name
                        richTextBox.SaveFile(saveFile.FileName,
                       RichTextBoxStreamType.RichText);
                        fileName = Path.GetFileName(saveFile.FileName);
                        toolStripFileName.Text = "File Name: " + fileName;
                        }
                    catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message);
                        }
                    }
                }
            }

        //Saves the file as a brand new file regardless whether it is new or not.
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
            {
            if (saveFile.ShowDialog() == DialogResult.OK)
                {
                try
                    {
                    //File is saved with the user input on the file name
                    richTextBox.SaveFile(saveFile.FileName,
                   RichTextBoxStreamType.RichText);
                    fileName = Path.GetFileName(saveFile.FileName);
                    toolStripFileName.Text = "File Name: " + fileName;
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                    }
                }
            }

        //Logs out the user and closes the application
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
            {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            }

        //Copies a selection of the text
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
            {
            richTextBox.Cut();
            }

        //Copies a selection of the text
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
            {
            richTextBox.Copy();
            }

        //Pastes a selection of the text
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
            {
            richTextBox.Paste();
            }

        //Opens a txt.file from the document folder
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
            {
            //Resets the rich text box and filename
            richTextBox.Clear();
            fileName = "";
            }

        //Shows the student details
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
            {
            //Setting the message to be shown
            string message = ".NET Assignment 2" +
                "\nProgram: Simple Text Editor" +
                "\nStudent: Ken Phetmany" +
                "\nStudent ID: 98042183"
                ;
            MessageBox.Show(message, "About");
            }

        //Function responsible to check if the file currently exists
        private bool fileExists(string title)
            {
            //Accesses all txt and rtf files in the documents folder
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