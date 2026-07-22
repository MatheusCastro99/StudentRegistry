using StudentRegistry.Models;
using StudentRegistry.Views;
using System.ComponentModel;

namespace StudentRegistry
{
    public partial class Form1 : Form
    {
        internal BindingList<Student> students = new();
        public int nextID = 0;
        public Form1()
        {
            InitializeComponent();

            students.Add(new Student(nextID, "John", "Doe", new Address("123", "Street Ave", "John's City", "NJ", "02345", "US"), 'A', Months.April, out nextID));
            students.Add(new Student(nextID, "Jane", "Smith", new Address("345", "Avenue St", "Jane's City", "MA", "29345", "US"), 'B', Months.July, out nextID));
            students.Add(new Student(nextID, "Jackie", "Chan", new Address(), 'A', Months.January, out nextID));

            bindingSource1.DataSource = students;
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            AddView addViewForm = new AddView(nextID);
            if (addViewForm.ShowDialog() == DialogResult.OK && addViewForm.CreatedStudent != null)
            {
                students.Add(addViewForm.CreatedStudent);
                nextID = addViewForm.nextStudentID;
            }
        }

        private void delStudentButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete");
                return;
            }

            Student selectedStudent = (Student)dataGridView1.SelectedRows[0].DataBoundItem;
            DelView delViewForm = new(selectedStudent, students);

            if (delViewForm.ShowDialog() == DialogResult.OK && delViewForm.isDeleted)
            {
                students = delViewForm.newList;
            }

        }

        private void bindingSource1_DataSourceChanged(object sender, EventArgs e)
        {
            bindingSource1.DataSource = students;
        }
    }
}
