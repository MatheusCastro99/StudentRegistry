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
    public partial class DelView : Form
    {
        internal BindingList<Student> newList;
        Student delStudent;
        public bool isDeleted;
        internal DelView(Student selectedStudent, BindingList<Student> studentsList)
        {
            InitializeComponent();

            delStudent = selectedStudent;
            newList = studentsList;
        }

        private void confirmDelButton_Click(object sender, EventArgs e)
        {
            newList.Remove(delStudent);
            isDeleted = true;
            Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
