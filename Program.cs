using System;


namespace AddressBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to your Address Book App!");
                Console.WriteLine("Enter '1' to add a contact.");
                Console.WriteLine("Enter '2' to delete a contact.");
                Console.WriteLine("Enter '3' to display all contacts.");
                Console.WriteLine("Enter '4' to quit");
                int response = Convert.ToInt32(Operations.GetUserInput("What would you like to do?"));

                if (response == 1)
                {
                    Operations.AddContact();
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
            }
        }

    }
}
