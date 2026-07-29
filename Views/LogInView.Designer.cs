namespace StudentRegistry.Views
{
    partial class LogInView
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
            label1 = new Label();
            label2 = new Label();
            usernameTextBox = new RichTextBox();
            passwordTextBox = new RichTextBox();
            attemptLogInButton = new Button();
            attemptsLeftLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 188);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Username: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 228);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Password: ";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(313, 188);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(195, 26);
            usernameTextBox.TabIndex = 2;
            usernameTextBox.Text = "";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(313, 228);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(195, 26);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.Text = "";
            // 
            // attemptLogInButton
            // 
            attemptLogInButton.Location = new Point(353, 284);
            attemptLogInButton.Name = "attemptLogInButton";
            attemptLogInButton.Size = new Size(94, 29);
            attemptLogInButton.TabIndex = 4;
            attemptLogInButton.Text = "Log In";
            attemptLogInButton.UseVisualStyleBackColor = true;
            attemptLogInButton.Click += attemptLogInButton_Click;
            // 
            // attemptsLeftLabel
            // 
            attemptsLeftLabel.AutoSize = true;
            attemptsLeftLabel.ForeColor = Color.Red;
            attemptsLeftLabel.Location = new Point(313, 344);
            attemptsLeftLabel.Name = "attemptsLeftLabel";
            attemptsLeftLabel.Size = new Size(0, 20);
            attemptsLeftLabel.TabIndex = 5;
            // 
            // LogInView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(attemptsLeftLabel);
            Controls.Add(attemptLogInButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LogInView";
            Text = "LogInView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox usernameTextBox;
        private RichTextBox passwordTextBox;
        private Button attemptLogInButton;
        private Label attemptsLeftLabel;
    }
}