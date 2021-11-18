using System;
using CsvHelper.Configuration.Attributes;

namespace AddressBookApp
{
    public class Contact
    {
        public Contact(string name, string phonenumber)
        {
            Name = name;
            PhoneNumber = phonenumber;
        }

        [Index(0)]
        public string Name { get; set; }
        [Index(1)]
        public string PhoneNumber { get; set; }
    }
}
