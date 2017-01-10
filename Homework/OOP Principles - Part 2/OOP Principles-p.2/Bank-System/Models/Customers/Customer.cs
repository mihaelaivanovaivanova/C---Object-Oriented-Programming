using Bank_System.Contracts;
using Bank_System.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Models.Customers
{
    class Customer:ICustomer
    {
        private string firstName;
        private string lastName;
        private string address;
        private string telephoneNumber;
        private string email;
        private IEnumerable<IAccount> customerAccounts;

        public Customer(CustomerType customerType, string firstName, string lastName, string address, string telephoneNumber)
        {
            this.CustomerType = customerType;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.TelephoneNumber = telephoneNumber;
        }

        public Customer(CustomerType customerType, string firstName, string lastName, string address, string telephoneNumber, string email):this(customerType,firstName,lastName,address,telephoneNumber)
        {
            this.Email = email;
        }

        public CustomerType CustomerType { get; set; }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {

            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {

            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {

            }
        }

        public string TelephoneNumber
        {
            get
            {
                return this.telephoneNumber;
            }
            set
            {

            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {

            }
        }

    }
}
