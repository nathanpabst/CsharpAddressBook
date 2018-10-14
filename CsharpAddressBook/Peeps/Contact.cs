using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAddressBook.Peeps
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public Person(string firstName, string lastName, string phone, string address, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Address = address;
            Email = email;
        }

    }
}
