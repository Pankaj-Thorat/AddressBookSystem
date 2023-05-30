using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            List<Contact> contacts = new List<Contact>();

            while (true)
            {
                //user menu for adding new contact
                Console.WriteLine("1. Add a new contact");
                Console.WriteLine("2. Update a contact");
                Console.WriteLine("3. Display contacts");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                //contact details Input 
                switch (choice)
                {
                    case 1:
                        Contact.AddContact(contacts);
                        break;
                    case 2:
                        Contact.UpdateContact(contacts);
                        break;
                    case 3:
                        Contact.DisplayContactList(contacts);
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
            //Display output
            Console.WriteLine("\nCONTACT LIST:");
            foreach (Contact contact in contacts) 
            {
                Console.WriteLine($"\nName: {contact.FirstName} {contact.LastName}");
                Console.WriteLine($"Address: {contact.Address}, {contact.City}, {contact.State} {contact.Zip}");
                Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
                Console.WriteLine($"Email: {contact.Email}");
            }
            
        }
    }
}
