using School;
using School.Contracts;
using School.People;
using School.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
   public class Class:IComment
    {
        private IList<Person> studentsInClass;
        private IList<Person> teachersInClass;
        private IList<string> comments;
        
        public Class()
        {
            this.studentsInClass = new List<Person>();
            this.teachersInClass = new List<Person>();
            this.UniqueTextIdentifier = Utilities.UniqueTextIdentifier.GenerateUniqueIdentifier();
            this.comments = new List<string>();
        }

        internal string UniqueTextIdentifier { get; }

        public void AddComment(string comment)
        {
            Validations.ValidateComment(comment);
            this.comments.Add(comment);
            Console.WriteLine("Comment was successfully added!");
        }

        public void RemoveComment(string comment)
        {
            Validations.ValidateElementExisting(comments, comment);
            this.comments.Remove(comment);
            Console.WriteLine("Comment was successfully removed!");
        }

        public void AddStudent(Student student)
        {
            this.studentsInClass.Add(student);
            Console.WriteLine($"Student was successfully added!");
        }

        public void RemoveStudent(Student student)
        {
            if (this.studentsInClass.IndexOf(student) < 0)
            {
                throw new ArgumentOutOfRangeException("This student does not exist in the class");
            }
            this.studentsInClass.Remove(student);
            Console.WriteLine($"Student was removed successfully!");
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachersInClass.Add(teacher);
            Console.WriteLine($"Teacher was successfully added!");
        }

        public void RemoveReacher(Teacher teacher)
        {
            if (this.teachersInClass.IndexOf(teacher) < 0)
            {
                throw new ArgumentOutOfRangeException("This student does not exist in the class");
            }
            this.teachersInClass.Remove(teacher);
            Console.WriteLine($"Teacher was removed successfully!");
        }

    }
}
