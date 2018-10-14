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
                Console.Clear();
                Console.Write("Please select one from the following commands (add, remove, exit): ");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "add":
                    addressBook.AddPerson(person);
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

            public static List<Person> People = new List<Person>();

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

                People.Add(newPerson);
            }
        }
    }
}
            //List<Contact> contact = new List<Contact>();
            //contact.Add(new Contact()
            //{
            //    FirstName = "Nathan",
            //    LastName = "Pabst",
            //    Phone = "816-229-0960",
            //    Address = "304 Stonewood Court Blue Springs, MO 64015",
            //    Email = "bob@lawblogs.com"
            //});
            //Contact peep = new Contact();
            //Console.Write("Enter first name: ");
            //peep.FirstName = Console.ReadLine();
            //Console.Write("Enter last name: ");
            //peep.LastName = Console.ReadLine();
            //Console.Write("Enter phone number: ");
            //peep.Phone = Console.ReadLine();
            //Console.Write("Enter address: ");
            //peep.Address = Console.ReadLine();
            //Console.Write("Enter email address: ");
            //peep.Email = Console.ReadLine();

            //contact.Add(peep);


            //PrintContact(peep);

            //ListContacts(contact);

            //RemoveContact(contact);

  

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

