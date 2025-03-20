using System;
using System.Windows.Forms;

namespace Medical_Appointment_Scheduler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create MenuStrip
            MenuStrip menuStrip = new MenuStrip();

            // Patients Menu
            ToolStripMenuItem patientsMenu = new ToolStripMenuItem("Patients");
            patientsMenu.DropDownItems.Add("Register New Patient", null, RegisterPatient);
            patientsMenu.DropDownItems.Add("View Patient Records", null, ViewPatientRecords);

            // Doctors Menu
            ToolStripMenuItem doctorsMenu = new ToolStripMenuItem("Doctors");
            doctorsMenu.DropDownItems.Add("Doctor Dashboard", null, DoctorDashboard);
            doctorsMenu.DropDownItems.Add("View Schedule", null, ViewSchedule);

            // Appointments Menu
            ToolStripMenuItem appointmentsMenu = new ToolStripMenuItem("Appointments");
            appointmentsMenu.DropDownItems.Add("Schedule Appointment", null, ScheduleAppointment);
            appointmentsMenu.DropDownItems.Add("View Appointments", null, ViewAppointments);

            // Settings Menu
            ToolStripMenuItem settingsMenu = new ToolStripMenuItem("Settings");
            settingsMenu.DropDownItems.Add("Change Password", null, ChangePassword);
            settingsMenu.DropDownItems.Add("Logout", null, Logout);

            // Help Menu
            ToolStripMenuItem helpMenu = new ToolStripMenuItem("Help");
            helpMenu.DropDownItems.Add("User Guide", null, ShowUserGuide);
            helpMenu.DropDownItems.Add("About", null, ShowAbout);

            // Add Menus to MenuStrip
            menuStrip.Items.Add(patientsMenu);
            menuStrip.Items.Add(doctorsMenu);
            menuStrip.Items.Add(appointmentsMenu);
            menuStrip.Items.Add(settingsMenu);
            menuStrip.Items.Add(helpMenu);

            // Add MenuStrip to the Form
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }

        // Event Handlers for Menu Items
        private void RegisterPatient(object sender, EventArgs e)
        {
            MessageBox.Show("Register Patient Form Opens Here");
        }

        private void ViewPatientRecords(object sender, EventArgs e)
        {
            MessageBox.Show("View Patient Records");
        }

        private void DoctorDashboard(object sender, EventArgs e)
        {
            MessageBox.Show("Doctor Dashboard");
        }

        private void ViewSchedule(object sender, EventArgs e)
        {
            MessageBox.Show("View Doctor's Schedule");
        }

        private void ScheduleAppointment(object sender, EventArgs e)
        {
            MessageBox.Show("Schedule a New Appointment");
        }

        private void ViewAppointments(object sender, EventArgs e)
        {
            MessageBox.Show("View All Appointments");
        }

        private void ChangePassword(object sender, EventArgs e)
        {
            MessageBox.Show("Change Password");
        }

        private void Logout(object sender, EventArgs e)
        {
            MessageBox.Show("Logging Out");
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
