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

            
            monthListBox.DataSource = months;
            nextStudentID = nextID;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string firstname = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;

            string houseNum = houseNumTextBox.Text;
            string street = streetTextBox.Text;
            string city = cityTextBox.Text;
            string state = stateTextBox.Text;
            string country = countryTextBox.Text;
            string postal = postalTextBox.Text;

            char grade = gradeTextBox.Text[0];
            Months admissionMonth = (Months)monthListBox.SelectedItem;

            CreatedStudent = new(nextStudentID, firstname, lastName, new Address(houseNum, street, city, state, postal, country), grade, admissionMonth, out nextStudentID);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
