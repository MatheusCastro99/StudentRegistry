using StudentRegistry.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace StudentRegistry.Components
{
    internal class MockData
    {
        BindingList<Student> mockStudents;
        public int nextID = 0;
        public MockData(BindingList<Student> studentsReference, out Teacher teacher) 
        {
            mockStudents = studentsReference;

            mockStudents.Add(new Student(nextID, "John", "Doe", new Address("123", "Street Ave", "John's City", "NJ", "02345", "US"), 3.8, Months.April, out nextID));
            mockStudents.Add(new Student(nextID, "Jane", "Smith", new Address("345", "Avenue St", "Jane's City", "MA", "29345", "US"), 3.0, Months.July, out nextID));
            mockStudents.Add(new Student(nextID, "Jackie", "Chan", new Address(), 4.0, Months.January, out nextID));

            teacher = new("username", "password", "A3", "Jon", "Snow", new Address());
        }
    }
}
