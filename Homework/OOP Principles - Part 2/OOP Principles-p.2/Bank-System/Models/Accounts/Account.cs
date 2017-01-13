using Bank_System.Contracts;
using Bank_System.Models.Customers;
using Bank_System.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Models.Accounts
{
    public class Account : IAccount
    {
        private ICustomer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(ICustomer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Interest = interestRate;
        }

        public ICustomer Customer
        {
            get
            {
                return this.customer;
            }
            private set
            {
                this.customer = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                Validations.BalanceValidation(value);
                this.balance = value;

            }
        }

        public decimal Interest
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
                Validations.InterestValidation(value);
                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterest(int periodOfMonths)
        {
            Validations.MonthsValidation(periodOfMonths);
            return this.interestRate * periodOfMonths;
        }

        public void DepositAmount(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
