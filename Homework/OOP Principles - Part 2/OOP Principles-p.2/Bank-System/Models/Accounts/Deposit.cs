using Bank_System.Contracts;
using Bank_System.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Models.Accounts
{
    class Deposit:Account,IAccount
    {
        public Deposit(ICustomer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public void DrowAmount(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentOutOfRangeException("You cant withdraw more than you have in your balance!");
            }
            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int periodOfMonths)
        {
            Validations.MonthsValidation(periodOfMonths);
            decimal interest = 0;
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return interest;
            }
            else
            {
                return base.CalculateInterest(periodOfMonths);
            }  
        }
    }
}
