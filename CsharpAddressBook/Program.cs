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

            //Print();

            Console.Read();
        }
    }

}
