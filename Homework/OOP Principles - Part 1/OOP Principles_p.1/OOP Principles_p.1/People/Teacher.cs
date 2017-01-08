using School.Contracts;
using School.Utilities;
using System;
using System.Collections.Generic;

namespace School.People
{
    public class Teacher:Person, IComment, ITeacher
    {
        private ICollection<Disciplines> setOfDisciplines;
        private ICollection<string> comments;

        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
            this.setOfDisciplines = new List<Disciplines>();
            this.comments = new List<string>();
        }

        public void AddDiscipline(Disciplines discipline)
        {
            this.setOfDisciplines.Add(discipline);
            Console.WriteLine($"{discipline} was added successfully!");
        }

        public void RemoveDiscipline(Disciplines discipline)
        {
            if (setOfDisciplines.Contains(discipline))
            {
                throw new ArgumentOutOfRangeException("The discipline does not exist in the list!");
            }
            this.setOfDisciplines.Remove(discipline);
            Console.WriteLine($"{discipline} was removed successfully!");

        }

        public void AddComment(string comment)
        {
            Validations.ValidateComment(comment);
            this.comments.Add(comment);
        }
        public void RemoveComment(string comment)
        {
            if (!comments.Contains(comment))
            {
                throw new ArgumentOutOfRangeException("This comment does not exist!");
            }
            this.comments.Remove(comment);
            Console.WriteLine("Comment successfully removed!");
        }
    }
}
