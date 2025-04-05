using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Appointment_Scheduler
{
    public partial class LoginForm : Form
    {
        public string UserType { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Simple hardcoded credential check for demonstration
            if (UserType == "Doctor" && username == "doc1" && password == "pass1")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (UserType == "Patient" && username == "pat1" && password == "pass1")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
