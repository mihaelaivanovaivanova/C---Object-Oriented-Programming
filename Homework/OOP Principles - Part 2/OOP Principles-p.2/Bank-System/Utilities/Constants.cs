using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Utilities
{
    public class Constants
    {
        public static string nameLengthValidationExc = $"Name length must be between {minNameLength} and {maxNameLength} symbols long!";
        public const string nameNullValidationExc = "Name can not have a null value!";
        public static string addressLengthValidationExc = $"Address must be between {minAddressLength} and {maxAddressLength} symbols long!";
        public const string addressNullValidationExc = "Address can not have a null value!";
        public static string telephoneNumberLengthValidationExc = $"Phone number length must be between {minTelephoneLength} and {maxTelephoneLength} symbols long!";
        public const string telephoneNumberNullValidationExc = "Phone number can not have a null value!";
        public static string emailLengthValidationExc = $"Email length must be between {minEmailLength} and {maxEmailLength} symbols long!";
        public const string negativeBalanceValidationExc = "The start balance can not be a negative value!";
        public const string negativeInterestValidationExc = "Interest can not be a negative value!";
        public static string negativeMonthsValidationExc = "Number of months can not be a negatove number!";
    
        public const int minNameLength = 2;
        public const int maxNameLength = 30;
        public const int minAddressLength = 10;
        public const int maxAddressLength = 70;
        public const int minTelephoneLength = 3;
        public const int maxTelephoneLength = 20;
        public const int minEmailLength = 5;
        public const int maxEmailLength = 20;

    }
}
