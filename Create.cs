using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Net.Mail;

namespace assignment2
    {
    public partial class Create : Form
        {
        public Create()
            {
            InitializeComponent();
            userType.Items.Add("View");
            userType.Items.Add("Edit");
            }

        private void createBtn_Click(object sender, EventArgs e)
            {
            //validateFilled();
            //validatePassword();
            //validateUsername();
           
            //CreateAccount();
            //DialogResult complete = MessageBox.Show("An account has been created for: " + username1.Text, "Creation Successful!");
            //if (complete == DialogResult.OK)
            //    {
            //    this.Hide();
            //    Login login = new Login();
            //    login.ShowDialog();
            //    }
            }

        private void cancelBtn_Click(object sender, EventArgs e)
            {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            }

        private void validateFilled()
            {
            if (username1.Text == "" || password.Text == "" || confirmPassword.Text == "" || firstName.Text == "" || lastName.Text == "" || userType.Text == "")
                {
                MessageBox.Show("You are missing some details! Please fill in missing details!", "Creation Failed!");
                }
            }

        private void validatePassword()
            {
            if (password.Text != confirmPassword.Text)
                {
                MessageBox.Show("Passwords dont match! Please try again.", "Creation Failed!");
                }
            else
                {
                MessageBox.Show("Passwords match!", "Creation Created!");
                }
            }

        private void validateUsername()
            {
            string[] lines = System.IO.File.ReadAllLines("login.txt");
            for (int i = 0; i < lines.Length; i++)
                {
                string[] details = lines[i].Split(',');
                if (username1.Text == details[0])
                    {
                    MessageBox.Show("Username already exists!", "Creation Failed!");
                    break;
                    }
                else
                    {
                    MessageBox.Show("Username available!", "Creation Created!");
                    break;
                    }
                }
            }
        private void CreateAccount()
            {
            //MessageBox.Show(username1.Text + "," + password.Text + "," + userType.Text + "," + firstName.Text + "," + lastName.Text + "," + birthDate.Text, "Login");

            using (StreamWriter writer = new StreamWriter("login.txt", true))
                {
                // Appends to the text file, adding a new line of text.
                writer.Write(username1.Text + "," + password.Text + "," + userType.Text + "," + firstName.Text + "," + lastName.Text + "," + birthDate.Text);
                writer.Close();
                }
            }

        }


    }
