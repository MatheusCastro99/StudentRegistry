using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using StudentRegistry;
using StudentRegistry.Components;

namespace StudentRegistry.Models
{
    internal class Student : User
    {
        public int StudentID {  get; set; }
        public double GPA { get; set; }
        public Months MonthOfAdmission { get; set; } = Months.January;

        public Student(int ID, string firstName, string lastName, Address address, double grade, Months month, out int nextID)
        {
            StudentID = ID;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            GPA = grade;
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
                            $"Grade: {GPA}\n" +
                            $"Admission: {MonthOfAdmission}\n" +
                            $"=====================================";

            return result;
        }
    }
}
