using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Utilities
{
  public class Constants
    {
        public const string NameValidationLengthException = "Name must be at least 2 symbols long!";
        public const string NameValidationNullException = "Name can not be null!";
        public const string NumberException = "Student Number must have a positive value!";
        public const string CommentLengthValidationException = "Comment length must be between 1 and 100 symbols!";
        public const string CommentNullValidationException = "Comment can not be null!";
        public const string ElementDoesNotExistException ="This comment does not exist!";
    }
}

