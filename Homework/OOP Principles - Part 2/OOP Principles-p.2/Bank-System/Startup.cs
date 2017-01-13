using Bank_System.Models.Accounts;
using Bank_System.Models.Customers;
using Bank_System.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    class Startup
    {
        static void Main(string[] args)
        {
            //Deposit Test
            var individualCustomer = new Customer(CustomerType.Individual, "Galin", "Cekov", "Sofia, kv Drujba 2, blok 4", "0885 446677","someMail@abv.bg");
            var individualDepositAcc = new Deposit(individualCustomer, 1600.25m,0.3m);
            Console.WriteLine("Customer: {0} | Balance: ${1:F2} | Interest Amount (12 Months): ${2:F2}",
                individualDepositAcc.Customer.FirstName, individualDepositAcc.Balance, individualDepositAcc.CalculateInterest(12));

            individualDepositAcc.DrowAmount(1500);
            Console.WriteLine("Balance after Withdraw: ${0:F2}", individualDepositAcc.Balance);
            Console.WriteLine();

            //Loan Test
            var companyCustomer = new Customer(CustomerType.Company, "Bulgarkom", "OOD", "Varna, kv Vladislavovo 2, blok 4", "0885 558877", "someMail2@abv.bg");
            var companyLoanAcc = new Loan(companyCustomer, 12745694.02m,0.7m);
            Console.WriteLine("Customer: {0} | Balance: ${1:F2} | Interest Amount (1 Month): ${2:F2}",
                companyLoanAcc.Customer.FirstName, companyLoanAcc.Balance, companyLoanAcc.CalculateInterest(1));

            companyLoanAcc.DepositAmount(1500000);
            Console.WriteLine("Balance after Deposit: ${0:F2}", companyLoanAcc.Balance);
            Console.WriteLine("Interest Amount (13 Months): ${0:F2}", companyLoanAcc.CalculateInterest(13));
            Console.WriteLine();

            //Mortage Test
            var companyMortgageAcc = new Mortgage(companyCustomer, 17000000.98m, 1.5m);
            Console.WriteLine("Customer: {0} | Balance: ${1:F2} | Interest Amount (1 Month): ${2:F2}",
                companyMortgageAcc.Customer.FirstName, companyMortgageAcc.Balance, companyMortgageAcc.CalculateInterest(1));

            Console.WriteLine();

            var individualMortgageAcc = new Mortgage(individualCustomer, 105000.13m, 1.0m);
            Console.WriteLine("Customer: {0} | Balance: ${1:F2} | Interest Amount (1 Month): ${2:F2}",
                individualMortgageAcc.Customer.FirstName, individualMortgageAcc.Balance, individualMortgageAcc.CalculateInterest(1));

        }
    }
}
