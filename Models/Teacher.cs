using StudentRegistry.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistry.Models
{
    internal class Teacher : User
    {
        public string Username { get; } = "";
        public string Password { get; } = "";
        public string ClassNum { get; set; } = "";

        public Teacher(string username, string password, string classNum, string firstName, string lastName, Address address) 
        {
            Username = username;
            Password = password;
            ClassNum = classNum;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }
    }
}
