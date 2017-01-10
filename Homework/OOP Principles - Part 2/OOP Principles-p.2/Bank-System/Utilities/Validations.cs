using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Utilities
{
    public class Validations
    {
        public static void NameValidation(string name)
        {
            if (name.Length < Constants.minNameLength || name.Length > Constants.maxNameLength)
            {
                throw new ArgumentOutOfRangeException(Constants.nameLengthValidationExc);
            }
            if (name == null)
            {
                throw new ArgumentNullException(Constants.nameNullValidationExc);
            }
        }

        public static void AddressValidation(string address)
        {
            if (address.Length < Constants.minAddressLength || address.Length > Constants.maxAddressLength)
            {
                throw new ArgumentOutOfRangeException(Constants.addressLengthValidationExc);
            }
            if (address == null)
            {
                throw new ArgumentNullException(Constants.addressNullValidationExc);
            }
        }

        public static void TelephoneNumberValidation(string number)
        {
            if (number.Length < Constants.minTelephoneLength || number.Length > Constants.maxTelephoneLength)
            {
                throw new ArgumentOutOfRangeException(Constants.telephoneNumberLengthValidationExc);
            }
            if (number == null)
            {
                throw new ArgumentNullException(Constants.telephoneNumberNullValidationExc);
            }
        }

        public static void EmailValidation(string email)
        {
            if (email.Length < Constants.minEmailLength || email.Length > Constants.maxEmailLength)
            {
                throw new ArgumentOutOfRangeException(Constants.emailLengthValidationExc);
            }
        }
    }
}
