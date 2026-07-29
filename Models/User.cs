using StudentRegistry.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistry.Models
{
    internal abstract class User
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public Address? Address { get; set; }
    }
}
