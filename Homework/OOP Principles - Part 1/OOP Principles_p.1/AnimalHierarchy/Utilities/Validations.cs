using System;

namespace AnimalHierarchy.Utilities
{
    class Validations
    {
        public static void NameValidation(string name)
        {
            if (name.Length <= 1)
            {
                throw new ArgumentOutOfRangeException(Constants.NameValidationLengthException);
            }

            if (name == null)
            {
                throw new ArgumentNullException(Constants.NameValidationNullException);
            }
        }
        public static void AgeValidation(int age)
        {
            if (age < Constants.minAge || age > Constants.maxAge)
            {
                throw new ArgumentOutOfRangeException(Constants.AgeValidationException);
            }
        }
    }
}
