using Bank_System.Contracts;
using Bank_System.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Models.Accounts
{
    class Mortgage: Account, IAccount
    {
        public Mortgage(ICustomer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int periodOfMonths)
        {
            Validations.MonthsValidation(periodOfMonths);
            decimal interest = 0;
            if (this.Customer.CustomerType == CustomerType.Individual)
            {
                interest = this.Interest * (periodOfMonths - 6);
                if (interest < 0)
                {
                    interest = 0;
                }
            }
            else if (this.Customer.CustomerType == CustomerType.Company)
            {
                if (periodOfMonths <= 12)
                {
                    interest= this.Interest * periodOfMonths * (decimal)0.5;
                }
                else
                {
                    interest = this.Interest * (periodOfMonths - 12) + this.Interest * 12 * (decimal)0.5;
                }
            }
            return interest;
        }
    }
}

