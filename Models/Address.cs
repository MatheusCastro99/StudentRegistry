using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistry.Models
{
    internal class Address
    {
        public string HouseNumber { get; set; } = "";
        public string Street { get; set; } = "";
        public string City { get; set; } = "";
        public string StateOrProvince { get; set; } = "";
        public string PostalCode { get; set; } = "";
        public string Country { get; set; } = "";

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
