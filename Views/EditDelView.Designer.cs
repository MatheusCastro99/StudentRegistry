namespace StudentRegistry.Views
{
    partial class EditDelView
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
            confirmDelButton = new Button();
            backButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            studentIDEditTextBox = new RichTextBox();
            firstNameEditTextBox = new RichTextBox();
            lastNameEditTextBox = new RichTextBox();
            houseNumberEditTextBox = new RichTextBox();
            streetEditTextBox = new RichTextBox();
            cityEditTextBox = new RichTextBox();
            stateEditTextBox = new RichTextBox();
            postalCodeEditTextBox = new RichTextBox();
            CountryEditTextBox = new RichTextBox();
            gradeEditTextBox = new RichTextBox();
            monthEditListBox = new ListBox();
            SuspendLayout();
            // 
            // confirmDelButton
            // 
            confirmDelButton.Location = new Point(502, 384);
            confirmDelButton.Name = "confirmDelButton";
            confirmDelButton.Size = new Size(286, 29);
            confirmDelButton.TabIndex = 0;
            confirmDelButton.Text = "Confirm Delete";
            confirmDelButton.UseVisualStyleBackColor = true;
            confirmDelButton.Click += confirmDelButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 384);
            backButton.Name = "backButton";
            backButton.Size = new Size(286, 29);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 2;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 4;
            label3.Text = "Last Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 102);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 5;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 122);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 6;
            label5.Text = "House Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 152);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 7;
            label6.Text = "Street:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 182);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 8;
            label7.Text = "City:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 212);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 9;
            label8.Text = "State / Province:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 242);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 10;
            label9.Text = "Postal Code:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(44, 272);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 11;
            label10.Text = "Country";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 308);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 12;
            label11.Text = "Grade:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 337);
            label12.Name = "label12";
            label12.Size = new Size(144, 20);
            label12.TabIndex = 13;
            label12.Text = "Month of admission:";
            // 
            // studentIDEditTextBox
            // 
            studentIDEditTextBox.Location = new Point(166, 18);
            studentIDEditTextBox.Name = "studentIDEditTextBox";
            studentIDEditTextBox.ScrollBars = RichTextBoxScrollBars.None;
            studentIDEditTextBox.Size = new Size(221, 24);
            studentIDEditTextBox.TabIndex = 14;
            studentIDEditTextBox.Text = "";
            // 
            // firstNameEditTextBox
            // 
            firstNameEditTextBox.Location = new Point(166, 48);
            firstNameEditTextBox.Name = "firstNameEditTextBox";
            firstNameEditTextBox.ScrollBars = RichTextBoxScrollBars.None;
            firstNameEditTextBox.Size = new Size(221, 24);
            firstNameEditTextBox.TabIndex = 15;
            firstNameEditTextBox.Text = "";
            // 
            // lastNameEditTextBox
            // 
            lastNameEditTextBox.Location = new Point(166, 78);
            lastNameEditTextBox.Name = "lastNameEditTextBox";
            lastNameEditTextBox.ScrollBars = RichTextBoxScrollBars.None;
            lastNameEditTextBox.Size = new Size(221, 24);
            lastNameEditTextBox.TabIndex = 16;
            lastNameEditTextBox.Text = "";
            // 
            // houseNumberEditTextBox
            // 
            houseNumberEditTextBox.Location = new Point(166, 122);
            houseNumberEditTextBox.Name = "houseNumberEditTextBox";
            houseNumberEditTextBox.ScrollBars = RichTextBoxScrollBars.None;
            houseNumberEditTextBox.Size = new Size(221, 24);
            houseNumberEditTextBox.TabIndex = 17;
            houseNumberEditTextBox.Text = "";
            // 
            // streetEditTextBox
            // 
            streetEditTextBox.Location = new Point(166, 152);
            streetEditTextBox.Name = "streetEditTextBox";
            streetEditTextBox.ScrollBars = RichTextBoxScrollBars.None;
            streetEditTextBox.Size = new Size(221, 24);
            streetEditTextBox.TabIndex = 18;
            streetEditTextBox.Text = "";
            // 
            // cityEditTextBox
            // 
            cityEditTextBox.Location = new Point(166, 182);
            cityEditTextBox.Name = "cityEditTextBox";
            cityEditTextBox.ScrollBars = RichTextBoxScrollBars.None;
            cityEditTextBox.Size = new Size(221, 24);
            cityEditTextBox.TabIndex = 19;
            cityEditTextBox.Text = "";
            // 
            // stateEditTextBox
            // 
            stateEditTextBox.Location = new Point(166, 212);
            stateEditTextBox.Name = "stateEditTextBox";
            stateEditTextBox.ScrollBars = RichTextBoxScrollBars.None;
            stateEditTextBox.Size = new Size(221, 24);
            stateEditTextBox.TabIndex = 20;
            stateEditTextBox.Text = "";
            // 
            // postalCodeEditTextBox
            // 
            postalCodeEditTextBox.Location = new Point(166, 242);
            postalCodeEditTextBox.Name = "postalCodeEditTextBox";
            postalCodeEditTextBox.ScrollBars = RichTextBoxScrollBars.None;
            postalCodeEditTextBox.Size = new Size(221, 24);
            postalCodeEditTextBox.TabIndex = 21;
            postalCodeEditTextBox.Text = "";
            // 
            // CountryEditTextBox
            // 
            CountryEditTextBox.Location = new Point(166, 272);
            CountryEditTextBox.Name = "CountryEditTextBox";
            CountryEditTextBox.ScrollBars = RichTextBoxScrollBars.None;
            CountryEditTextBox.Size = new Size(221, 24);
            CountryEditTextBox.TabIndex = 22;
            CountryEditTextBox.Text = "";
            // 
            // gradeEditTextBox
            // 
            gradeEditTextBox.Location = new Point(70, 308);
            gradeEditTextBox.MaxLength = 1;
            gradeEditTextBox.Name = "gradeEditTextBox";
            gradeEditTextBox.ScrollBars = RichTextBoxScrollBars.None;
            gradeEditTextBox.Size = new Size(34, 24);
            gradeEditTextBox.TabIndex = 23;
            gradeEditTextBox.Text = "";
            // 
            // monthEditListBox
            // 
            monthEditListBox.FormattingEnabled = true;
            monthEditListBox.Location = new Point(162, 337);
            monthEditListBox.Name = "monthEditListBox";
            monthEditListBox.Size = new Size(159, 24);
            monthEditListBox.TabIndex = 24;
            // 
            // EditDelView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(monthEditListBox);
            Controls.Add(gradeEditTextBox);
            Controls.Add(CountryEditTextBox);
            Controls.Add(postalCodeEditTextBox);
            Controls.Add(stateEditTextBox);
            Controls.Add(cityEditTextBox);
            Controls.Add(streetEditTextBox);
            Controls.Add(houseNumberEditTextBox);
            Controls.Add(lastNameEditTextBox);
            Controls.Add(firstNameEditTextBox);
            Controls.Add(studentIDEditTextBox);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(backButton);
            Controls.Add(confirmDelButton);
            Name = "EditDelView";
            Text = "DelView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button confirmDelButton;
        private Button backButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private RichTextBox studentIDEditTextBox;
        private RichTextBox firstNameEditTextBox;
        private RichTextBox lastNameEditTextBox;
        private RichTextBox houseNumberEditTextBox;
        private RichTextBox streetEditTextBox;
        private RichTextBox cityEditTextBox;
        private RichTextBox stateEditTextBox;
        private RichTextBox postalCodeEditTextBox;
        private RichTextBox CountryEditTextBox;
        private RichTextBox gradeEditTextBox;
        private ListBox monthEditListBox;
    }
}