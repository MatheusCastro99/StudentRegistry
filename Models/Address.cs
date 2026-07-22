using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistry.Models
{
    internal class Address
    {
        private string HouseNumber { get; set; } = "";
        private string Street { get; set; } = "";
        private string City { get; set; } = "";
        private string StateOrProvince { get; set; } = "";
        private string PostalCode { get; set; } = "";
        private string Country { get; set; } = "";

        public Address(string houseNum, string street, string city, string state, string zipCode, string country)
        {
            HouseNumber = houseNum;
            Street = street;
            City = city;
            StateOrProvince = state;
            PostalCode = zipCode;
            Country = country;
        }

        public Address()
        {
            
        }

        public override string ToString()
        {
            if (HouseNumber == "")
            {
                return "Not found";
            }

            return $"{City}, {StateOrProvince}";
        }
    }
}
