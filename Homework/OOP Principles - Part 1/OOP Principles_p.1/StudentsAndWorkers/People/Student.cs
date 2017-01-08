using StudentsAndWorkers.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers.People
{
    class Student:Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade):base(firstName,lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                Validators.GradeValidation(value);
                this.grade = value;
            }
        }
    }
}
