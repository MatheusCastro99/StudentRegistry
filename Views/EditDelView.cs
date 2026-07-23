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
        public bool isDeleted;
        public bool isEdited;
        internal EditDelView(Student selectedStudent, BindingList<Student> studentsList, BindingList<Months> months)
        {
            InitializeComponent();

            currentStudent = selectedStudent;
            newList = studentsList;

            //Populate Edit Views
            studentIDEditTextBox.Text = currentStudent.StudentID.ToString();
            firstNameEditTextBox.Text = currentStudent.FirstName;
            lastNameEditTextBox.Text = currentStudent.LastName;
            houseNumberEditTextBox.Text = currentStudent.Address.HouseNumber;
            streetEditTextBox.Text = currentStudent.Address.Street;
            cityEditTextBox.Text = currentStudent.Address.City;
            stateEditTextBox.Text = currentStudent.Address.StateOrProvince;
            postalCodeEditTextBox.Text = currentStudent.Address.PostalCode;
            CountryEditTextBox.Text = currentStudent.Address.Country;
            gradeEditTextBox.Text = currentStudent.Grade.ToString();

            monthEditListBox.DataSource = months;
            monthEditListBox.SelectedIndex = Convert.ToInt32(currentStudent.MonthOfAdmission) - 1;
        }

        private void confirmDelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Wish to delete student?\n(Irreversible)",         // Message body
                "Confirm Deletion",               // Title bar
                MessageBoxButtons.YesNo,          // Yes = Proceed, No = Back
                MessageBoxIcon.Warning            // Visual icon
             );

            if (result == DialogResult.Yes) 
            {
                newList.Remove(currentStudent);
                isDeleted = true;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmEditButton_Click(object sender, EventArgs e)
        {
            currentStudent.FirstName = firstNameEditTextBox.Text;
            currentStudent.LastName = lastNameEditTextBox.Text;

            currentStudent.Address.HouseNumber = houseNumberEditTextBox.Text;
            currentStudent.Address.Street = streetEditTextBox.Text;
            currentStudent.Address.City = cityEditTextBox.Text;
            currentStudent.Address.StateOrProvince = stateEditTextBox.Text;
            currentStudent.Address.PostalCode = postalCodeEditTextBox.Text;
            currentStudent.Address.Country = CountryEditTextBox.Text;

            currentStudent.Grade = gradeEditTextBox.Text[0];
            currentStudent.MonthOfAdmission = (Months)monthEditListBox.SelectedItem;

            isEdited = true;
            newList.ResetItem(currentStudent.StudentID);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
