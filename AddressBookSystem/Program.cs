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
            AddressBook addressBook = new AddressBook();

            while (true)
            {
                //user menu for adding new contact
                Console.WriteLine("1. Add a new contact");
                Console.WriteLine("2. Update a contact");
                Console.WriteLine("3. Display contacts");
                Console.WriteLine("4. Delete a contact");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                //contact details Input 
                switch (choice)
                {
                    case 1:
                        addressBook.AddContact();
                        break;
                    case 2:
                        addressBook.UpdateContact();
                        break;
                    case 3:
                        addressBook.DisplayContactList();
                        break;
                    case 4:
                        addressBook.DeleteContact();
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }
    }
}
