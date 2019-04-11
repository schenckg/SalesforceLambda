using System;
using System.Collections.Generic;
using System.Text;

namespace SalesforceLibrary
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Contact(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(FirstName))
                return LastName;
            else if (string.IsNullOrEmpty(LastName))
                return FirstName;
            else
                return $"{FirstName} {LastName}";
        }
    }
}
