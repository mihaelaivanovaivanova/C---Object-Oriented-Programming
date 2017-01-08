using System;
using System.Collections.Generic;


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

        public static void ValidateComment(string comment)
        {
            if (comment.Length <= 1 || comment.Length > 100)
            {
                throw new ArgumentOutOfRangeException(Constants.CommentLengthValidationException);
            }
            if (string.IsNullOrEmpty(comment.Trim()))
            {
                throw new ArgumentNullException(Constants.CommentNullValidationException);
            }
        }

        public static void ValidateElementExisting(ICollection<string> someList,string element)
        {
            if (!someList.Contains(element))
            {
                throw new ArgumentOutOfRangeException(Constants.ElementDoesNotExistException);
            }
        }
    }
}
