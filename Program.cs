using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace AddressBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("Contacts.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Contact>();
            }
            // Master Loop
            while (true)
            {
                Console.WriteLine("Welcome to your Address Book App!");
                Console.WriteLine("Enter '1' to add a contact.");
                Console.WriteLine("Enter '2' to delete a contact.");
                Console.WriteLine("Enter '3' to display all contacts.");
                Console.WriteLine("Enter '4' to quit");
                Console.WriteLine("What would you like to do?");
                int response = Convert.ToInt32(Console.ReadLine());
                if (response == 1)
                {
                    Contact contact = Operations.AddContact();
                    using var writer = new StreamWriter("Contacts.csv", true);
                    using var csvWriter = new CsvWriter(writer, CultureInfo.CurrentCulture);
                    csvWriter.WriteRecord(contact);
                    csvWriter.NextRecord();
                    writer.Flush();
                }
                else if (response == 2) 
                {
                    Operations.DeleteContact();
                }
                else if (response == 3)
                {
                    Operations.ListContacts();
                }
                else if (response == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid response.  Try again.");
                }
            }
        }

    }
}
