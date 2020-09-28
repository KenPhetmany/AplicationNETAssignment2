using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
    {
    public partial class Create : Form
        {
        public Create()
            {
            InitializeComponent();
            }

        private void createBtn_Click(object sender, EventArgs e)
            {

            }

        private void cancelBtn_Click(object sender, EventArgs e)
            {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
            {

            }
        }
    }
