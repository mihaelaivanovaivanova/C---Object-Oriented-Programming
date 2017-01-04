using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Startup
    {
        static void Main(string[] args)
        {
            var studentsArr = new List<Students>()
            {
                new Students("Kalin", "Atanasov", 21, 45689 , "02-413-4130", "atanasovv@abv.bg", new List<byte> {
                    5,2,6,6 }, 2),
                new Students("Ivan", "Kostov", 18, 45972, "07-409-3313", "i.kostov@abv.bg",new List<byte> {
                    }, 1),
                new Students("Maya", "Georgieva", 26, 47900, "07-436-5022", "m.georgieva@gmail.com", new List<byte> {
                    },2),
                new Students("Stoyko", "Stoqnov", 17, 43876, "02-285-8624", "ssm_98@gmail.com", new List<byte> { 
                  2,4  }, 1),
                new Students("Pesho", "Goshov", 38, 40002, "05-352-6526", "pe66@abv.bg",new List<byte> {
                   6 }, 2)
            };

            /* Problem 3. First before last
Write a method that from a given array of students finds all students whose 
first name is before its last name alphabetically.*/

             var filteredStudents= studentsArr.StudentFirstNameBeforeLastName();
            foreach (Students student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.WriteLine("---------------------");

            /* Problem 4. Age range
Write a LINQ query that finds the first name and last name of all students 
with age between 18 and 24.*/

            var studentsBetwwen18And24 = studentsArr.FilterByAgeRange(18, 24);
            foreach (string student in studentsBetwwen18And24)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("---------------------");

            /* Problem 5. Order students
Using the extension methods OrderBy() and ThenBy() with lambda expressions sort 
the students by first name and last name in descending order. */

            var orderedStudentsByNameLambda =studentsArr.OrderByNameDecidingLambda();
            foreach (Students student in orderedStudentsByNameLambda)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.WriteLine("---------------------");

            /* Rewrite with Linq*/

            var orderedStudentsByNameLinq = studentsArr.OrderByNameDecidingLinq();
            foreach (Students student in orderedStudentsByNameLinq)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.WriteLine("---------------------");

            /*Problem 9. Student groups
Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
Create a List<Student> with sample students. Select only the students that are from group number 2.
Use LINQ query. Order the students by FirstName.*/

            var filteredByGroup = studentsArr.Where(x => x.GroupNumber == 2);
            foreach (Students student in filteredByGroup)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.WriteLine("---------------------");

            /*Problem 10. Student groups extensions
Implement the previous using the same query expressed with extension methods.*/

            var filteredByGroupExt = studentsArr.FilterByGroup(2);
            foreach (Students student in filteredByGroupExt)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.WriteLine("---------------------");

            /*Problem 11. Extract students by email
Extract all students that have email in abv.bg.
Use string methods and LINQ.*/

            var filteredByEmail = studentsArr.FilterByEmail("@abv.bg");
            foreach (Students student in filteredByEmail)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.WriteLine("---------------------");

            /*Problem 12. Extract students by phone
           Extract all students with phones in Sofia.
           Use LINQ.*/

            var filteredByPhone = studentsArr.FilterByPhone("02");
            foreach (Students student in filteredByPhone)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.WriteLine("---------------------");

            /*Problem 13. Extract students by marks
Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
Use LINQ.*/

            var filteredByMarks = studentsArr.FilterByMarks(6);
            foreach (var student in filteredByMarks)
            {
                Console.WriteLine($"{student}");
            }
            Console.WriteLine("---------------------");

            /*Problem 14. Extract students with two marks
Write down a similar program that extracts the students with exactly two marks "2".
Use extension methods.*/

            var filteredByMarksCount = studentsArr.FilterByMarksCount(2);
            foreach (var student in filteredByMarksCount)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.WriteLine("---------------------");

        }
    }
}
