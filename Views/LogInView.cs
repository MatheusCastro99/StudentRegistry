using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using StudentRegistry.Components;
using StudentRegistry.Models;

namespace StudentRegistry.Views
{
    public partial class LogInView : Form
    {
        string AttemptedName { get; set; } = "";
        string AttemptedPass { get; set; } = "";
        int AttemptsLeft { get; set; } = 5;
        private string[] validCredentials = new string[2];

        public SessionContext currentSession = new();
        internal LogInView(Teacher validCredentials) //Initializes LogInView window and stores valid credentials
        {
            InitializeComponent();
            this.validCredentials[0] = validCredentials.Username;
            this.validCredentials[1] = validCredentials.Password;
        }

        private void attemptLogInButton_Click(object sender, EventArgs e) //Button event handler that calls on method to Validate fields
        {
            AttemptedName = usernameTextBox.Text;
            AttemptedPass = passwordTextBox.Text;

            ValidateUser(AttemptedName, AttemptedPass);
        }

        private void ValidateUser(string username, string password)  //User validation and logic
        {
            if (username == validCredentials[0] && password == validCredentials[1]) 
            {
                currentSession = new(validCredentials[0]);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                AttemptedPass = "";
                AttemptedName = "";
                AttemptsLeft--;

                if (AttemptsLeft == 0)
                {
                    MessageBox.Show("Unable to Log In\nProgram Terminating");

                    DialogResult = DialogResult.Abort;
                    Close();
                }
                attemptsLeftLabel.Text = $"Invalid Credentials, {AttemptsLeft} attempts left";
            }
        }

    }
}
