using School;
using School.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Class
    {
        private IEnumerable<Person> studentsInClass;
        private IEnumerable<Teacher> teachersInClass;
        
        public Class()
        {
            this.studentsInClass = new List<Student>();
            this.teachersInClass = new List<Teacher>();
            this.UniqueTextIdentifier = Utilities.UniqueTextIdentifier.GenerateUniqueIdentifier();
        }

        public string UniqueTextIdentifier { get; }

    }
}
