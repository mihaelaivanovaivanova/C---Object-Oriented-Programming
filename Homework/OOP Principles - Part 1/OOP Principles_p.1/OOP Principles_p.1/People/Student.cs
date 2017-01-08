
using System;
using School.Contracts;
using School.Utilities;
using System.Collections.Generic;

namespace School.People
{
   public class Student:Person, IComment
    {
        private static int numberCount = 0;
        private int classNumber;
        private IList<string> comments;

        public Student(string firstName, string lastName):base(firstName,lastName)
        {
            this.ClassNumber = classNumber;
            this.comments = new List<string>();
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
          private set
            {
                numberCount++;
                this.classNumber = numberCount;
            }
        }

        public void AddComment(string comment)
        {
            Validations.ValidateComment(comment);
            this.comments.Add(comment);
            Console.WriteLine("Comment successfully added!");

        }

        public void RemoveComment(string comment)
        {
            Validations.ValidateElementExisting(comments, comment);
            this.comments.Remove(comment);
            Console.WriteLine("Comment successfully removed!");
        }
    }
}
