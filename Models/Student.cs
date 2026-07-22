using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using StudentRegistry;

namespace StudentRegistry.Models
{
    internal class Student
    {
        public int StudentID {  get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public Address? Address { get; set; }
        public char Grade { get; set; }
        public Months MonthOfAdmission { get; set; } = Months.January;

        public Student(int ID, string firstName, string lastName, Address address, char grade, Months month, out int nextID)
        {
            StudentID = ID;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Grade = grade;
            MonthOfAdmission = month;

            nextID = StudentID+1;
        }

        //public Student()
        //{

        //}

        public override string ToString()
        {
            var pontentialAddress = Address.ToString() ?? "No Address on File";
            string result = $"=====================================\n" +
                            $"ID: {StudentID}\n" +
                            $"Name: {FirstName} {LastName}\n" +
                            $"Address: {pontentialAddress}\n" +
                            $"Grade: {Grade}\n" +
                            $"Admission: {MonthOfAdmission}\n" +
                            $"=====================================";

            return result;
        }
    }
}
