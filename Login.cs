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
            //MessageBox.Show("Username:" + username.Text + "\n Password: " + password.Text, "Login");
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
                    string loggedUser = username.Text;
                    string loggedType = details[3];
                    TextEditor textEditor = new TextEditor(loggedUser, loggedType);
                    this.Hide();
                    textEditor.ShowDialog();
                    break;
                    }
                else
                    {
                    MessageBox.Show("Login failed", "Login failed!");
                    break;
                    }
                }
            }
        }
    }