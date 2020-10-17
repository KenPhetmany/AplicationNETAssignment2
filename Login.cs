using System;
using System.Windows.Forms;

namespace assignment2
    {
    public partial class Login : Form
        {
        //Initializing the Login Form
        public Login()
            {
            InitializeComponent();
            }

        //Searches through the login.txt for a username that was created and then a valid password
        private void login()
            {
            string[] lines = System.IO.File.ReadAllLines("login.txt");
            for (int i = 0; i < lines.Length; i++)
                {
                //Locates the line with a matching username
                string[] details = lines[i].Split(',');
                //Validates if password matches the password located in the same line
                if (username.Text == details[0] && password.Text == details[1])
                    {
                    //If username and password match, login form is closed and they have access to the text editor
                    MessageBox.Show("Login worked!", "Logging in now...!");
                    //Username and usertype is passed down to the next form
                    TextEditor textEditor = new TextEditor(username.Text, details[3]);
                    this.Hide();
                    textEditor.ShowDialog();
                    break;
                    }
                else
                //If username is not located or if password is incorrect, an error message box will show
                    {
                    MessageBox.Show("Login failed", "Inputs are invalid! Please try again.");
                    break;
                    }
                }
            }

        //Button to intiate the login() function
        private void loginBtn_click(object sender, EventArgs e)
            {
            //Checks if username or password textfields is empty first before login()
            if (username.Text == "" || password.Text == "")
                {
                //If either textfields are empty, an error message box will show
                MessageBox.Show("Login failed", "You have empty fields! Please enter valid inputs ");
                }
            else
                login();
            }

        //Button to go to initiate create()
        private void createBtn_click(object sender, EventArgs e)
            {
            this.Hide();
            create();
            }

        //Button to close the program
        private void exitBtn_click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        //Initiates a new create() form (responsible for creating a new user)
        private void create()
            {
            Create create = new Create();
            create.ShowDialog();
            }
        }
    }