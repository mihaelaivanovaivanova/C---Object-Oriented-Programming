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

        public Customer(CustomerType customerType, string firstName, string lastName, string address, string telephoneNumber, string email=null)
        {
            this.CustomerType = customerType;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.TelephoneNumber = telephoneNumber;
            this.Email = email;
            this.customerAccounts = new List<IAccount>();
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
                Validations.NameValidation(value);
                this.firstName = value;
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
                Validations.NameValidation(value);
                this.lastName = value;
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
                Validations.AddressValidation(value);
                this.address = value;
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
                Validations.TelephoneNumberValidation(value);
                this.telephoneNumber = value;
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
                Validations.EmailValidation(value);
                this.email = value;
            }
        }

    }
}
