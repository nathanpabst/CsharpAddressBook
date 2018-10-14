using System;
using System.Collections.Generic;

namespace CsharpAddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contact = new List<Contact>();
            contact.Add(new Contact()
            {
                FirstName = "Nathan",
                LastName = "Pabst",
                Phone = "816-229-0960",
                Address = "304 Stonewood Court Blue Springs, MO 64015",
                Email = "bob@lawblogs.com"
            });
            Contact peep = new Contact();
            Console.Write("Enter first name: ");
            peep.FirstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            peep.LastName = Console.ReadLine();
            Console.Write("Enter phone number: ");
            peep.Phone = Console.ReadLine();
            Console.Write("Enter address: ");
            peep.Address = Console.ReadLine();
            Console.Write("Enter email address: ");
            peep.Email = Console.ReadLine();

            contact.Add(peep);


            PrintContact(peep);

            ListContacts(contact);

            Console.Read();
        }

        public static void PrintContact(Contact contact)
        {
            Console.WriteLine($"First Name: {contact.FirstName}");
            Console.WriteLine($"Last Name: {contact.LastName}");
            Console.WriteLine($"Phone Number: {contact.Phone}");
            Console.WriteLine($"Address: {contact.Address}");
            Console.WriteLine($"Email: {contact.Email}");
            //throw new NotImplementedException();
        }

        private static void ListContacts(List<Contact> contact)
        {
            Console.WriteLine("Here is a list of your current contacts: ");
            Console.WriteLine("");
            foreach (var peep in contact)
            {
                //ListContacts(contact);
                PrintContact(peep);
                Console.WriteLine("");
            }
        }
    }

}
