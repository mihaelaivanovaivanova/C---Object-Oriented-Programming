using School.Contracts;
using School.People;
using School.Utilities;
using System.Collections.Generic;

namespace School
{
    public class Disciplines:IComment
    {
        private string name;
        private IList<string> comments;

        public Disciplines(string name, int numberrOfLectures, int numberOfExcersises)
        {
            this.Name = name;
            this.NumberOfLectures = numberrOfLectures;
            this.NumberOfExcersises = numberOfExcersises;
            this.comments = new List<string>();
        }

        protected int NumberOfLectures { get; set; }
        protected int NumberOfExcersises { get; set; }

        protected string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validations.NameValidation(value);
                this.name = value;
            }
        }

        public void AddComment(string comment)
        {
            Validations.ValidateComment(comment);
            this.comments.Add(comment);
            System.Console.WriteLine("Comment was successfully added!");
        }

        public void RemoveComment(string comment)
        {
            Validations.ValidateElementExisting(comments,comment);
            this.comments.Remove(comment);
            System.Console.WriteLine("Comment was successfully removed!");
        }

    }
}
