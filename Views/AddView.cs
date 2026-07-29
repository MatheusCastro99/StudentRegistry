using StudentRegistry.Components;
using StudentRegistry.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentRegistry
{
    public partial class AddView : Form
    {

        public int nextStudentID;
        internal Student? CreatedStudent;
        public AddView(int nextID, BindingList<Months> months)
        {
            InitializeComponent();


            monthListBox.DataSource = months; //populates monthListBox with enum Months List
            nextStudentID = nextID;
        }

        private void submitButton_Click(object sender, EventArgs e) //Attempts to create new student and closes pop-up window
        {
            string firstname = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;

            string houseNum = houseNumTextBox.Text;
            string street = streetTextBox.Text;
            string city = cityTextBox.Text;
            string state = stateTextBox.Text;
            string country = countryTextBox.Text;
            string postal = postalTextBox.Text;

            double grade; 
            double.TryParse(gradeTextBox.Text, out grade);
            Months admissionMonth = (Months)monthListBox.SelectedItem;

            CreatedStudent = new(nextStudentID, firstname, lastName, new Address(houseNum, street, city, state, postal, country), grade, admissionMonth, out nextStudentID);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void backButton_Click(object sender, EventArgs e) //Closes pop-up window without saving any info
        {
            Close();
        }
    }
}
