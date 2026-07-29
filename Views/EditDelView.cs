using StudentRegistry.Components;
using StudentRegistry.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentRegistry.Views
{
    public partial class EditDelView : Form
    {
        internal BindingList<Student> newList;
        Student currentStudent;
        public bool isDeleted; //These bools are how MainView keeps track of what happened in this window
        public bool isEdited;
        internal EditDelView(Student selectedStudent, BindingList<Student> studentsList, BindingList<Months> months)
        {
            InitializeComponent();

            currentStudent = selectedStudent;
            newList = studentsList;

            //Populate Textboxes with selected student
            studentIDEditTextBox.Text = currentStudent.StudentID.ToString();
            firstNameEditTextBox.Text = currentStudent.FirstName;
            lastNameEditTextBox.Text = currentStudent.LastName;
            houseNumberEditTextBox.Text = currentStudent.Address.HouseNumber;
            streetEditTextBox.Text = currentStudent.Address.Street;
            cityEditTextBox.Text = currentStudent.Address.City;
            stateEditTextBox.Text = currentStudent.Address.StateOrProvince;
            postalCodeEditTextBox.Text = currentStudent.Address.PostalCode;
            CountryEditTextBox.Text = currentStudent.Address.Country;
            gradeEditTextBox.Text = currentStudent.GPA.ToString();

            monthEditListBox.DataSource = months;
            monthEditListBox.SelectedIndex = Convert.ToInt32(currentStudent.MonthOfAdmission) - 1; //Months Enum go from 1 - 12
        }

        private void confirmDelButton_Click(object sender, EventArgs e) //Displays warning message before deleting student
        {
            DialogResult result = MessageBox.Show(
                "Wish to delete student?\n(Irreversible)",   
                "Confirm Deletion",               
                MessageBoxButtons.YesNo,          
                MessageBoxIcon.Warning            
             );

            if (result == DialogResult.Yes) 
            {
                newList.Remove(currentStudent);
                isDeleted = true;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e) //Closes pop-up window without changing any info
        {
            Close();
        }

        private void confirmEditButton_Click(object sender, EventArgs e) //overrides selected student info with new info inputted 
        {
            double newGPA;
            currentStudent.FirstName = firstNameEditTextBox.Text;
            currentStudent.LastName = lastNameEditTextBox.Text;

            currentStudent.Address.HouseNumber = houseNumberEditTextBox.Text;
            currentStudent.Address.Street = streetEditTextBox.Text;
            currentStudent.Address.City = cityEditTextBox.Text;
            currentStudent.Address.StateOrProvince = stateEditTextBox.Text;
            currentStudent.Address.PostalCode = postalCodeEditTextBox.Text;
            currentStudent.Address.Country = CountryEditTextBox.Text;

            double.TryParse(gradeEditTextBox.Text, out newGPA);
            currentStudent.GPA = newGPA;
            currentStudent.MonthOfAdmission = (Months)monthEditListBox.SelectedItem;

            isEdited = true;
            newList.ResetItem(currentStudent.StudentID); //hot reloads BindingList newList using StudentID as index (not optimal)

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
