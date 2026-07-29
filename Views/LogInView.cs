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
        private BindingList<Teacher> validCredentialsList;

        public SessionContext currentSession = new();
        internal LogInView(BindingList<Teacher> validCredentials) //Initializes LogInView window and stores valid credentials
        {
            InitializeComponent();
            validCredentialsList = validCredentials;
        }

        private void attemptLogInButton_Click(object sender, EventArgs e) //Button event handler that calls on method to Validate fields
        {
            AttemptedName = usernameTextBox.Text;
            AttemptedPass = passwordTextBox.Text;

            ValidateUser(AttemptedName, AttemptedPass);
        }

        private void ValidateUser(string username, string password)  //User validation and logic
        {
            if (validCredentialsList.Any(t => t.Username == username && t.Password == password)) 
            {
                Teacher currentTeacher = validCredentialsList.FirstOrDefault(t => t.Username == username && t.Password == password); //After validating that credentials exits, fetches Teacher instance
                currentSession = new(currentTeacher.Username, currentTeacher.FirstName);                                             //And passes it to ContextSession
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
