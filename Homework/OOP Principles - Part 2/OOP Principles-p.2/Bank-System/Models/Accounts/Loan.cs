using Bank_System.Contracts;
using Bank_System.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Models.Accounts
{
    class Loan:Account, IAccount
    {
        public Loan(ICustomer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int periodOfMonths)
        {
            Validations.MonthsValidation(periodOfMonths);
            decimal interest = 0;
            if (this.Customer.CustomerType == CustomerType.Individual)
            {
                interest= this.Interest * (periodOfMonths - 3);
                if (interest < 0)
                {
                    interest =0;
                }
            }
           else if (this.Customer.CustomerType == CustomerType.Company)
            {
                interest= this.Interest * (periodOfMonths - 2);
                if (interest < 0)
                {
                    interest = 0;
                }
            }
            return interest;
        }
    }
}
