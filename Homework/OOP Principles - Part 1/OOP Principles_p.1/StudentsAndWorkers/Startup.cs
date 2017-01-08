using StudentsAndWorkers.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Startup
    {
        static void Main(string[] args)
        {
            List <Student> students= new List<Student>
            {
                new Student("Ivan", "Yotov", 6),
                new Student("Petkan", "Mushkov", 3),
                new Student("Dragan", "Kirov", 7),
                new Student("Gosho", "Ovcharov", 11),
                new Student("Pesho", "Tanev", 2),
                new Student("Tosho", "Angelov", 8),
                new Student("Sasho", "Panov", 4),
                new Student("Iva", "Lukanova", 1),
                new Student("Desi", "Mihova", 10),
                new Student("Vera", "Dragoeva", 12)
            };

            var orderedStudents = students.OrderBy(student => student.Grade);
            foreach(var student in orderedStudents)
            {
                Console.WriteLine($"{student.FullName} - Grade:{student.Grade}");
            }

        }
    }
}
