using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Utilities
{
   public class Validations
    {
        public static void NameValidation(string name)
        {
            if (name.Length <= 1)
            {
                throw new ArgumentOutOfRangeException(Constants.NameValidationLengthException);
            }

            if (name == null)
            {
                throw new ArgumentNullException (Constants.NameValidationNullException);
            }
        }
    }
}
