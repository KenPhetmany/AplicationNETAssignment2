using System;
using System.Windows.Forms;

namespace assignment2
    {
    public partial class Login : Form
        {
        public Login()
            {
            InitializeComponent();
            }

        private void loginBtn_click(object sender, EventArgs e)
            {
            if (username.Text == "" || password.Text == "")
                {
                MessageBox.Show("Login failed", "You have empty fields! Please enter valid inputs ");
                }
            else
            login();
            }

        private void createBtn_click(object sender, EventArgs e)
            {
            this.Hide();
            create();
            }

        private void exitBtn_click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        private void create()
            {
            Create create = new Create();
            create.ShowDialog();
            }

        private void login()
            {
            string[] lines = System.IO.File.ReadAllLines("login.txt");
            for (int i = 0; i < lines.Length; i++)
                {
                string[] details = lines[i].Split(',');
                if (username.Text == details[0] && password.Text == details[1])
                    {
                    MessageBox.Show("Login worked!", "Logging in now...!");
                    TextEditor textEditor = new TextEditor(username.Text, details[3]);
                    this.Hide();
                    textEditor.ShowDialog();
                    break;
                    }
                else
                    {
                    MessageBox.Show("Login failed", "Inputs are invalid! Please try again.");
                    break;
                    }
                }
            }
        }
    }