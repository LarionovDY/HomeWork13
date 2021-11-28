using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13
{
    public class Address        //класс описывающий адрес объекта
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public Address(string region, string city, string street, string houseNumber)
        {
            Country = "Российская Федерация";
            Region = region;
            City = city;
            Street = street;
            HouseNumber = houseNumber;
        }
        public Address(string country, string region, string city, string street, string houseNumber)
        {
            Country = country;
            Region = region;
            City = city;
            Street = street;
            HouseNumber = houseNumber;
        }
        public string SetAddress()
        {
            string address = Country + ',' + Region + ',' + City + ',' + "д." + HouseNumber;
            return address;
        }
    }
}
