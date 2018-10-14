using System;
using CsharpAddressBook.Peeps;
using System.Collections.Generic;
using System.Linq;

namespace CsharpAddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var addressBook = new AddressBook("Nathan's Contacts", new DateTime());
            var person = new Person("Nathan", "Pabst", "123456777", "42 Main St", "bob@lawblogs");

            string command = "";
            while (command != "exit")
            {
                //Console.Clear();
                Console.Write("Please select one from the following commands (add, list, remove, exit): ");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "add":
                        addressBook.AddPerson(person);
                        break;
                    case "list":
                        addressBook.ListPeeps();
                        break;
                }
            }
            Console.Read();
        }

        public class AddressBook
        {
            public string Name { get; }
            public DateTime CreatedOn { get; }


            public AddressBook(string name, DateTime createdOn)
            {
                Name = name;
                CreatedOn = createdOn;
            }

            //Create a property for holding a list of current peeps
            List<Person> CurrentPeeps { get; } = new List<Person>();

            //Create a method that allows external user to add a contact
            public void AddPerson(Person newPerson)
            {
                Console.Write("Enter first name: ");
                newPerson.FirstName = Console.ReadLine();
                Console.Write("Enter last name: ");
                newPerson.LastName = Console.ReadLine();
                Console.Write("Enter phone number: ");
                newPerson.Phone = Console.ReadLine();
                Console.Write("Enter address: ");
                newPerson.Address = Console.ReadLine();
                Console.Write("Enter email address: ");
                newPerson.Email = Console.ReadLine();

                CurrentPeeps.Add(newPerson);
            }

            public void ListPeeps()
            {
                foreach (var peep in CurrentPeeps)
                {
                    Console.WriteLine($"{peep.FirstName} {peep.LastName}");
                }
            }
        }
    }
}
            
            
  

        //public static void PrintContact(Contact contact)
        //{
        //    Console.WriteLine($"First Name: {contact.FirstName}");
        //    Console.WriteLine($"Last Name: {contact.LastName}");
        //    Console.WriteLine($"Phone Number: {contact.Phone}");
        //    Console.WriteLine($"Address: {contact.Address}");
        //    Console.WriteLine($"Email: {contact.Email}");
        //    //throw new NotImplementedException();
        //}

        //private static void ListContacts(List<Contact> contact)
        //{
        //    Console.WriteLine("Here is a list of your current contacts: ");
        //    Console.WriteLine("");
        //    foreach (var peep in contact)
        //    {
        //        //ListContacts(contact);
        //        PrintContact(peep);
        //        Console.WriteLine("");
        //    }
        //}

        //public string RemoveContact(Contact contact)
        //{
        //    Console.WriteLine("Enter the first name of the contact you would like to remove.");
        //    string firstName = Console.ReadLine();
        //    Contact contact = Contact.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
        //    if (contact == null)
        //    {
        //        Console.WriteLine("That contact could not be found. Press any key to continue.");
        //        Console.ReadKey();
        //        return;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Are you sure?. (Y/N)");
        //        PrintContact(peep);
        //        if (Console.ReadKey().Key == ConsoleKey.Y)
        //        {
        //            Contact.Remove(contact);
        //            Console.WriteLine("Contact removed. Press any key to continue.");
        //            Console.ReadKey();

        //        }
        //    }
        //}

