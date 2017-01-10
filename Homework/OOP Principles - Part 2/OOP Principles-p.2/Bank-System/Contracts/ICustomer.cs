using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Contracts
{
    public interface ICustomer
    {
        string FirstName
        {
            get;
        }
        string LastName
        {
            get;
        }

        string Address
        {
            get;
            set;
        }

        string TelephoneNumber
        {
            get;
            set;
        }

        string Email
        {
            get;
            set;
        }
    }
}
