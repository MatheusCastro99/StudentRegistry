using StudentRegistry.Components;
using StudentRegistry.Models;
using StudentRegistry.Views;
using System.ComponentModel;

namespace StudentRegistry
{
    public partial class MainView : Form
    {
        internal BindingList<Student> students = new();
        internal Teacher currentTeacher;

        BindingList<Months> monthsList = new();
        public int nextID; // Will handle automatic ID generation

        public bool isLoggedIn = false;
        internal SessionContext currentSession = new();
        public MainView()
        {
            InitializeComponent();

            foreach (Months month in Enum.GetValues(typeof(Months))) //Generate Month List that can be used in the Views
            {
                monthsList.Add(month);
            }

            MockData initialMockData = new(students, out currentTeacher); //Initializes some mock data

            LogInHandler(isLoggedIn);
        }

        private void LogInHandler(bool isLogged) // Handles consequences of being logged in or not
        {
            if (isLogged)
            {
                addStudentButton.Enabled = true;
                delStudentButton.Enabled = true;
                studentAwardButton.Enabled = true;

                bindingSource1.DataSource = students;
                dataGridView1.DataSource = bindingSource1;

                logOutButton.Enabled = true;
                logOutButton.Visible = true;

                logInButton.Enabled = false;
                logInButton.Visible = false;
            }
            else
            {
                addStudentButton.Enabled = false;
                delStudentButton.Enabled = false;
                studentAwardButton.Enabled = false;

                dataGridView1.DataSource = "";

                logOutButton.Enabled = false;
                logOutButton.Visible = false;

                logInButton.Enabled = true;
                logInButton.Visible = true;
            }
        }

        private void addStudentButton_Click(object sender, EventArgs e) //pop-up window to add a student
        {
            AddView addViewForm = new AddView(nextID, monthsList);
            if (addViewForm.ShowDialog() == DialogResult.OK && addViewForm.CreatedStudent != null)
            {
                students.Add(addViewForm.CreatedStudent);
                nextID = addViewForm.nextStudentID;
            }
        }

        private void delStudentButton_Click(object sender, EventArgs e) //pop-up window to edit or delete a student
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student's row to edit");
                return;
            }

            Student selectedStudent = (Student)dataGridView1.SelectedRows[0].DataBoundItem;
            EditDelView delViewForm = new(selectedStudent, students, monthsList);

            if (delViewForm.ShowDialog() == DialogResult.OK && (delViewForm.isDeleted || delViewForm.isEdited))
            {
                students = delViewForm.newList;
            }

        }

        private void bindingSource1_DataSourceChanged(object sender, EventArgs e) //Event handler that refreshes bindingSource for dataGridView
        {
            bindingSource1.DataSource = students;
        }

        private void logInButton_Click(object sender, EventArgs e) //pop-up window to allow user to log in
        {
            LogInView logInView = new(currentTeacher);
            if (logInView.ShowDialog() == DialogResult.OK)
            {
                currentSession = logInView.currentSession;
                isLoggedIn = true;
                LogInHandler(isLoggedIn);
            }
            else
            {
                isLoggedIn = false;
                LogInHandler(isLoggedIn);

                Application.Exit();
            }

        }

        private void logOutButton_Click(object sender, EventArgs e) //Logs user out
        {
            currentSession = new(); //Flushes CurrentSession Data
            isLoggedIn = false;
            LogInHandler(isLoggedIn);
        }

        private void studentAwardButton_Click(object sender, EventArgs e) //Generates a txt file with the information of the highest GPA student
        {
            Student bestStudent = students.OrderByDescending(s => s.GPA).ToList()[0];
            using (StreamWriter writer = new StreamWriter("award.txt"))
            {
                writer.WriteLine("Best Student Award\n");
                writer.WriteLine($"Student Name: {bestStudent.FirstName} {bestStudent.LastName}");
                writer.WriteLine($"GPA: {bestStudent.GPA}");
            }

        }
    }
}
