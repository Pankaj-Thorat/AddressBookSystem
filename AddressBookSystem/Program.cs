using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            List<Contact> contacts = new List<Contact>();

            while (true)
            {
                //user menu for adding new contact
                Console.WriteLine("1. Add a new contact");
                Console.WriteLine("2. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                //contact details Input 
                if (choice == 1)
                {   
                    //creating new instance of class
                    Contact newContact = new Contact();
                    Console.Write("Enter First Name: ");
                    newContact.FirstName = Console.ReadLine();

                    Console.Write("Enter Last Name: ");
                    newContact.LastName = Console.ReadLine();

                    Console.Write("Enter Address: ");
                    newContact.Address = Console.ReadLine();

                    Console.Write("Enter City: ");
                    newContact.City = Console.ReadLine();

                    Console.Write("Enter State: ");
                    newContact.State = Console.ReadLine();

                    Console.Write("Enter Zip: ");
                    newContact.Zip = Console.ReadLine();

                    Console.Write("Enter Phone Number: ");
                    newContact.PhoneNumber = Console.ReadLine();

                    Console.Write("Enter Email: ");
                    newContact.Email = Console.ReadLine();

                    //adding new contact to the collection
                    contacts.Add(newContact);
                    Console.WriteLine("Contact Added Successfully!!");

                }
                else if (choice == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid choice. Please try again.");
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
