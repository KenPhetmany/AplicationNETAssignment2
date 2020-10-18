using System;
using System.IO;
using System.Windows.Forms;

namespace assignment2
    {
    public partial class Create : Form
        {
        //Initializing the Login Form
        public Create()
            {
            InitializeComponent();
            //Adding items to the userType combobox to initialize it
            userType.Items.Add("View");
            userType.Items.Add("Edit");
            birthDate.Format = DateTimePickerFormat.Custom;
            birthDate.CustomFormat = "dd-MM-yyyy";
            }

        //Button to start the process of creating an account
        private void createBtn_Click(object sender, EventArgs e)
            {
            //Validates all items have been at least filled
            if (validateFilled())
                {
                //Error message box if return true
                MessageBox.Show("You are missing some details! Please fill in missing details!", "Creation Failed!");
                }
            //Next step is to validate if the password and password confirmation match
            else if (validatePassword())
                {
                //Error message box if return true
                MessageBox.Show("Passwords dont match! Please try again.", "Creation Failed!");
                }
            //Last step is to validate if the username is unique
            else if (validateUsername())
                {
                //Error message box if return true
                MessageBox.Show("Username already exists!", "Creation Failed!");
                }
            //After all three validation steps have been cleared, the CreateAccount() is called.
            else createAccount();
            //After createAccount() is successful, a message box will show to confirm creation.
            }

        //Cancel the account creation process and instead return to the login form
        private void cancelBtn_Click(object sender, EventArgs e)
            {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            }

        //Validates all fields are filled
        private bool validateFilled()
            {
            if (username1.Text == "" || password.Text == "" || confirmPassword.Text == "" || firstName.Text == "" || lastName.Text == "" || userType.Text == "")
                {
                //If any field is empty return true
                return true;
                }
            else return false;
            }

        //Validates if password matches
        private bool validatePassword()
            {
            if (password.Text != confirmPassword.Text)
                {
                //If passwords do not match, return true
                return true;
                }
            else
                return false;
            }

        //Validates if the username is unique
        private bool validateUsername()
            {
            //Accesses the login.txt file to search for any mataching username
            string[] lines = System.IO.File.ReadAllLines("login.txt");
            for (int i = 0; i < lines.Length; i++)
                {
                //Processes each line of string in the file
                string[] details = lines[i].Split(',');
                if (username1.Text == details[0])
                    {
                    //If there exists a username already, return true
                    return true;
                    }
                else
                    return false;
                }
            return true;
            }

        //Function to create an account using the validated fields.
        private void createAccount()
            {
            try
                {
                using (StreamWriter writer = new StreamWriter("login.txt", true))
                    {
                    // Appends to the text file, adding a new line of text and adding all fields to the file.
                    writer.WriteLine(username1.Text + "," + password.Text + "," + userType.Text + "," + firstName.Text + "," + lastName.Text + "," + birthDate.Text);
                    writer.Close();
                    }
                //After successful creation a message box will show, confirming account creation
                DialogResult complete = MessageBox.Show("An account has been created for: " + username1.Text, "Creation Successful!");
                if (complete == DialogResult.OK)
                    {
                    //When "OK" is pressed, Create() closes and a new login form is created.
                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                    }
                }
            //Catches exception if account creation fails.
            catch (Exception e)
                {
                //Error message box is shown inform what exception has been caught
                MessageBox.Show(e.Message, "Error");
                }
            }
        }
    }