using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBook
    {
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact()
        {
            Console.WriteLine("\nAdd a new contact");
            Contact contact = GetContactDetails();
            contacts.Add(contact);
            Console.WriteLine("Contact added successfully!");
            Console.WriteLine();
        }

        public void UpdateContact()
        {
            Console.WriteLine("\nUpdate a contact");
            Console.Write("Enter the first name of the contact to update: ");
            string firstName = Console.ReadLine();

            // Find the contact in the list by first name
            Contact contactToUpdate = contacts.FirstOrDefault(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

            if (contactToUpdate != null)
            {
                Console.WriteLine("\nExisting contact details:");
                DisplayContact(contactToUpdate);

                Console.WriteLine("\nEnter the updated details:");

                // Prompt the user for updated contact details
                Contact updatedContact = GetContactDetails();

                // Update the contact properties
                contactToUpdate.FirstName = updatedContact.FirstName;
                contactToUpdate.LastName = updatedContact.LastName;
                contactToUpdate.Address = updatedContact.Address;
                contactToUpdate.City = updatedContact.City;
                contactToUpdate.State = updatedContact.State;
                contactToUpdate.Zip = updatedContact.Zip;
                contactToUpdate.PhoneNumber = updatedContact.PhoneNumber;
                contactToUpdate.Email = updatedContact.Email;

                Console.WriteLine("Contact updated successfully!");
            }
            else
            {
                Console.WriteLine("Contact not found!");
            }
            Console.WriteLine();
        }

        public void DeleteContact()
        {
            Console.WriteLine("\nDelete a contact");
            Console.Write("Enter the first name of the contact to delete: ");
            string firstName = Console.ReadLine();

            // Find the contact in the list by first name
            Contact contactToDelete = contacts.FirstOrDefault(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

            if (contactToDelete != null)
            {
                contacts.Remove(contactToDelete);
                Console.WriteLine("Contact deleted successfully!");
            }
            else
            {
                Console.WriteLine("Contact not found!");
            }
            Console.WriteLine();
        }

        public void DisplayContactList()
        {
            if (contacts.Count > 0)
            {
                Console.WriteLine("\nCONTACT LIST:");
                foreach (Contact contact in contacts)
                {
                    DisplayContact(contact);
                }
            }
            else
            {
                Console.WriteLine("No contacts found!");
            }
            Console.WriteLine();
        }

        private Contact GetContactDetails()
        {
            Contact contact = new Contact();

            Console.Write("Enter First Name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter State: ");
            contact.State = Console.ReadLine();

            Console.Write("Enter Zip: ");
            contact.Zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            contact.Email = Console.ReadLine();

            return contact;
        }

        private void DisplayContact(Contact contact)
        {
            Console.WriteLine($"\nName: {contact.FirstName} {contact.LastName}");
            Console.WriteLine($"Address: {contact.Address}, {contact.City}, {contact.State} {contact.Zip}");
            Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
            Console.WriteLine($"Email: {contact.Email}");
        }
    }
}
