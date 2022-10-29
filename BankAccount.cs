using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Examples
{
    public class BankAccount
    {
        string _firstName;
        string _lastName;
        string _type;
        string _customerNumber;
        decimal _balance;

        // Default Constructor - Note: All fields will start empty
        public BankAccount(string type, decimal balance)
        {
            _type = type;
            _balance = balance;
        }

        public BankAccount(string firstName, string lastName, string type, decimal balance)
        {
            _firstName = firstName;
            _lastName = lastName;
            _type = type;
            _balance = balance;

            Random rand = new Random();
            _customerNumber = rand.Next(10000, 99999).ToString();
        }


        // Property
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set // Set with a validation
            {
                // Check if the new value is an empty string.
                // If not, then assign the new value to the field
                if(value != "")  
                {
                    _firstName = value;
                }
                // Else show a message that the message is invalid.
                else
                {
                    MessageBox.Show("Invalid Name");
                }
                
            }
        }





        // Property
        public decimal Balance
        {
            get { return _balance; }
        }

        public string Type { get => _type; set => _type = value; }

        // Method
        public void Deposit(decimal depositAmount)
        {
            // Checks if the argument is a positive value
            if(depositAmount > 0)
            {
                _balance += depositAmount;
            }
        } // Deposit

        public void Withdraw(decimal withdrawAmount)
        {
            // Checks if there is enough money to withdraw, or that the amount pass is greater than 0
            // Two validations that both have to pass
            // The withdrawAmount is not a negative number AND
            // There is enough money to withdraw from the balance
            if(withdrawAmount >= 0 && withdrawAmount < _balance)
            {
                _balance -= withdrawAmount;
            }
        } // Withdraw


    } // class

} // namespace
