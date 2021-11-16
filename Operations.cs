using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookApp
{
    public static class Operations
    {
        public static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        public static void AddContact()
        {
            Contact contact = new Contact
            {
                Name = GetUserInput("Enter the contact's name:  "),
                PhoneNumber = Convert.ToInt32(GetUserInput("Enter the contact's phone number:  "))
            };
        }

        public static void DeleteContact()
        {

        }

        public static void ListContacts()
        {

        }
    }
}
