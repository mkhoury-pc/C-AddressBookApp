using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace AddressBookApp
{
    public class Operations
    {
        // Methods for various operations
        public static Contact AddContact()
        {
            Console.WriteLine("Enter the contact's name:  ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the contact's phone number:  ");
            string phonenumber = Console.ReadLine();
            Console.WriteLine($"Added {name} with the phone number {phonenumber}");
            var contact = new Contact(name, phonenumber);
            return contact;
        }

        public static void DeleteContact()
        {
            Console.WriteLine("Enter the name of the contact you want to delete");
            

        }

        public static void ListContacts()
        {

        }
    }
}
