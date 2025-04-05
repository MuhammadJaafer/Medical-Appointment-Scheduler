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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLoginDoctor_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.UserType = "Doctor";
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                MainForm mainForm = new MainForm();
                mainForm.UserType = "Doctor";
                this.Hide();  
                mainForm.ShowDialog();
                this.Close(); 
            }
        }

        private void btnLoginPatient_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.UserType = "Patient";
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                MainForm mainForm = new MainForm();
                mainForm.UserType = "Patient";
                this.Hide();
                mainForm.ShowDialog();  
                this.Close();  
            }
        }

    }
}
