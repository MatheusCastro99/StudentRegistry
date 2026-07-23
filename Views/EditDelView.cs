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
            newList.Remove(currentStudent);
            isDeleted = true;
            Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
