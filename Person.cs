using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Examples
{
    public class Person
    {
        string _firstName;
        string _lastName;
        List<BankAccount> _accounts = new List<BankAccount>();

        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }


        // Property
        public List<BankAccount> Accounts
        {
            get
            {
                return _accounts;
            }
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }

        // Method




    }
}
