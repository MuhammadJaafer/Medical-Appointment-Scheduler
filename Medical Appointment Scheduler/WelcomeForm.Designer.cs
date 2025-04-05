namespace Medical_Appointment_Scheduler
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoginDoctor = new Button();
            btnLoginPatient = new Button();
            welcomeLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLoginDoctor
            // 
            btnLoginDoctor.FlatAppearance.BorderColor = Color.Black;
            btnLoginDoctor.FlatAppearance.BorderSize = 10;
            btnLoginDoctor.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginDoctor.Location = new Point(61, 350);
            btnLoginDoctor.Name = "btnLoginDoctor";
            btnLoginDoctor.Size = new Size(236, 64);
            btnLoginDoctor.TabIndex = 0;
            btnLoginDoctor.Text = "Doctor";
            btnLoginDoctor.UseVisualStyleBackColor = true;
            btnLoginDoctor.Click += btnLoginDoctor_Click;
            // 
            // btnLoginPatient
            // 
            btnLoginPatient.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginPatient.Location = new Point(415, 350);
            btnLoginPatient.Name = "btnLoginPatient";
            btnLoginPatient.Size = new Size(208, 64);
            btnLoginPatient.TabIndex = 1;
            btnLoginPatient.Text = "Patient";
            btnLoginPatient.UseVisualStyleBackColor = true;
            btnLoginPatient.Click += btnLoginPatient_Click;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(264, 72);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(208, 54);
            welcomeLabel.TabIndex = 2;
            welcomeLabel.Text = "Welocme ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 228);
            label1.Name = "label1";
            label1.Size = new Size(374, 46);
            label1.TabIndex = 3;
            label1.Text = "Please chose your role";
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(label1);
            Controls.Add(welcomeLabel);
            Controls.Add(btnLoginPatient);
            Controls.Add(btnLoginDoctor);
            Name = "WelcomeForm";
            Text = "WelcomForm";
            Load += WelcomForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoginDoctor;
        private Button btnLoginPatient;
        private Label welcomeLabel;
        private Label label1;
    }
}