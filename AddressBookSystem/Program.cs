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

            Console.WriteLine("Contact Created:");
            Console.WriteLine($"Name: {newContact.FirstName} {newContact.LastName}");
            Console.WriteLine($"Address: {newContact.Address}, {newContact.City}, {newContact.State} {newContact.Zip}");
            Console.WriteLine($"Phone Number: {newContact.PhoneNumber}");
            Console.WriteLine($"Email: {newContact.Email}");
        }
    }
}
