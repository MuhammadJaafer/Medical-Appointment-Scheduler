using System;
using System.Windows.Forms;

namespace Medical_Appointment_Scheduler
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeForm()); // Start with WelcomeForm
        }
    }
}