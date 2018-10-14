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

            //contact.Add(peep);


            //Print();

            Console.Read();
        }
    }

}
