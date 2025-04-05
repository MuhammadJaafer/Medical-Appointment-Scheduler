using System;
using System.Windows.Forms;

namespace Medical_Appointment_Scheduler
{
    public partial class MainForm : Form
    {
        public string UserType { get; set; } 

        private ToolStripMenuItem patientsMenu;
        private ToolStripMenuItem doctorsMenu;
        private ToolStripMenuItem appointmentsMenu;
        private ToolStripMenuItem settingsMenu;
        private ToolStripMenuItem helpMenu;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuStrip menuStrip = new MenuStrip();

            patientsMenu = new ToolStripMenuItem("Patients");
            patientsMenu.DropDownItems.Add("Register New Patient", null, RegisterPatient);
            patientsMenu.DropDownItems.Add("View Patient Records", null, ViewPatientRecords);


            doctorsMenu = new ToolStripMenuItem("Doctors");
            doctorsMenu.DropDownItems.Add("Doctor Dashboard", null, DoctorDashboard);
            doctorsMenu.DropDownItems.Add("View Schedule", null, ViewSchedule);


            appointmentsMenu = new ToolStripMenuItem("Appointments");
            appointmentsMenu.DropDownItems.Add("Schedule Appointment", null, ScheduleAppointment);
            appointmentsMenu.DropDownItems.Add("View Appointments", null, ViewAppointments);


            settingsMenu = new ToolStripMenuItem("Settings");
            settingsMenu.DropDownItems.Add("Change Password", null, ChangePassword);
            settingsMenu.DropDownItems.Add("Logout", null, Logout);


            helpMenu = new ToolStripMenuItem("Help");
            helpMenu.DropDownItems.Add("User Guide", null, ShowUserGuide);
            helpMenu.DropDownItems.Add("About", null, ShowAbout);


            menuStrip.Items.Add(patientsMenu);
            menuStrip.Items.Add(doctorsMenu);
            menuStrip.Items.Add(appointmentsMenu);
            menuStrip.Items.Add(settingsMenu);
            menuStrip.Items.Add(helpMenu);

            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);


            ConfigureMenuStrip();
        }

        private void ConfigureMenuStrip()
        {
            if (UserType == "Doctor")
            {
                patientsMenu.Enabled = true;   
                doctorsMenu.Enabled = true;    
                appointmentsMenu.Enabled = true;
                settingsMenu.Enabled = true;
                helpMenu.Enabled = true;
            }
            else if (UserType == "Patient")
            {
                patientsMenu.Enabled = false;   
                doctorsMenu.Enabled = false;   
                appointmentsMenu.Enabled = true;
                settingsMenu.Enabled = true;
                helpMenu.Enabled = true;
            }
            else 
            {
                patientsMenu.Enabled = false;
                doctorsMenu.Enabled = false;
                appointmentsMenu.Enabled = false;
                settingsMenu.Enabled = false;
                helpMenu.Enabled = true;
            }
        }

        private void DoctorDashboard(object sender, EventArgs e)
        {
            MessageBox.Show("Doctor Dashboard");
        }

        private void ScheduleAppointment(object sender, EventArgs e)
        {
            MessageBox.Show("Schedule a New Appointment");
        }

        private void Logout(object sender, EventArgs e)
        {
            this.Close();
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
        }

        private void RegisterPatient(object sender, EventArgs e)
        {
            MessageBox.Show("Register Patient Form Opens Here");
        }

        private void ViewPatientRecords(object sender, EventArgs e)
        {
            MessageBox.Show("View Patient Records");
        }

        private void ViewSchedule(object sender, EventArgs e)
        {
            MessageBox.Show("View Doctor's Schedule");
        }

        private void ViewAppointments(object sender, EventArgs e)
        {
            MessageBox.Show("View All Appointments");
        }

        private void ChangePassword(object sender, EventArgs e)
        {
            MessageBox.Show("Change Password");
        }

        private void ShowUserGuide(object sender, EventArgs e)
        {
            MessageBox.Show("User Guide will open here");
        }

        private void ShowAbout(object sender, EventArgs e)
        {
            MessageBox.Show("Medical Appointment Scheduler v1.0 by Muhammad Al Dawahreh & Zeinah Al Adaileh");
        }
    }
}