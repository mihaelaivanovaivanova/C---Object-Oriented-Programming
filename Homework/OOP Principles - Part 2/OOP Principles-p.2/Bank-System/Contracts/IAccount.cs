using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Contracts
{
    public interface IAccount
    {
        decimal Balance
        {
            get;
        }

        decimal Interest
        {
            get;
        }

        decimal CalculateInterest(int periodOfMonths);
    }
}
