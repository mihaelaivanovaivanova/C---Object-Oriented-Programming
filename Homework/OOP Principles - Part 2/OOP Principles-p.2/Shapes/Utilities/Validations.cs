using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Utilities
{
    public class Validations
    {
        public static void DimentionValidation(double dimention)
        {
            if (dimention <= 0)
            {
                throw new ArgumentOutOfRangeException(Constants.dimestionValidationException);
            }
        }
    }
}
