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
            Console.WriteLine("Username: " + username);
            Console.WriteLine("Password: " + password);
            }


        }
    }