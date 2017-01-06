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
                new Students("Kalin", "Atanasov", 21, 4568206 , "02-413-4130", "atanasovv@abv.bg", new List<byte> {
                    5,2,6,6 }, 2),
                new Students("Ivan", "Kostov", 18, 4597205, "07-409-3313", "i.kostov@abv.bg",new List<byte> {
                    }, 3),
                new Students("Maya", "Georgieva", 26, 4790204, "07-436-5022", "m.georgieva@gmail.com", new List<byte> {
                    },2),
                new Students("Stoyko", "Stoqnov", 17, 4387205, "02-285-8624", "ssm_98@gmail.com", new List<byte> {
                  2,4  }, 1),
                new Students("Pesho", "Goshov", 38, 4000206, "05-352-6526", "pe66@abv.bg",new List<byte> {
                   6 }, 2)
            };

            /* Problem 3. First before last
Write a method that from a given array of students finds all students whose 
first name is before its last name alphabetically.*/

            var filteredStudents = studentsArr.StudentFirstNameBeforeLastName();
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

            var orderedStudentsByNameLambda = studentsArr.OrderByNameDecidingLambda();
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

            /*Problem 15. Extract marks
Extract all Marks of the students that enrolled in 2006. 
(The students from 2006 have 06 as their 5-th and 6-th digit in the FN).*/

            var extractStudentsByEnterYear = studentsArr
                .Where(student => ((student.Fn / 10) % 10 == 0) && (student.Fn % 10 == 6))
                .Select(s => new
                {
                    FullName = s.FullName(),
                    Marks = string.Join(" ", s.Marks)
                }).ToArray();

            foreach (var student in extractStudentsByEnterYear)
            {
                Console.WriteLine($"{student.FullName} {student.Marks}");
            }
            Console.WriteLine("---------------------");

            /*Problem 16.* Groups
Create a class Group with properties GroupNumber and DepartmentName.
Introduce a property GroupNumber in the Student class.
Extract all students from "Mathematics" department.
Use the Join operator.*/
            var groups = new List<Group>() {
             new Group(1, "History"),
             new Group(2, "Mathematics"),
             new  Group(3, "Literature")
             };
            var studentsWithMathematics = from student in studentsArr
                                          join gr in groups
                                          on student.GroupNumber equals gr.GroupNumber
                                          where student.GroupNumber == 2
                                          select new { student.FirstName, student.LastName,                                 gr.DepartmentName };

            foreach (var student in studentsWithMathematics)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.DepartmentName}");
            }
            Console.WriteLine("---------------------");

            /*Problem 17. Longest string
Write a program to return the string with maximum length from an array of strings.
Use LINQ.*/

            List<string> stringContainer = new List<string>
            {
                "some",
                "some string",
                "long long sring",
                "just a string",
                "some very mery hyper long string here",
                "a"
            };

            string longestString = stringContainer.OrderByDescending(x => x.Length)
                .First();

            Console.WriteLine($"Longest string: { longestString}");
            Console.WriteLine("---------------------");

            /* Problem 18.Grouped by GroupNumber
Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
Use LINQ.*/

            var groupedByGroupNumber = studentsArr.OrderBy(s=>s.GroupNumber)
                .GroupBy(s => s.GroupNumber);

            foreach (var group in groupedByGroupNumber)
            {
                foreach (var student in group)
                {
                    Console.WriteLine($"Student {student.FirstName} {student.LastName} is in group {group.Key}" );
                }
            }

            Console.WriteLine("---------------------");

            /* Problem 19. Grouped by GroupName extensions
Rewrite the previous using extension methods.*/

            var groupedByGroupNumberExt = studentsArr.GroupByGroupNum();
            foreach (var group in groupedByGroupNumberExt)
            {
                foreach (var student in group)
                {
                    Console.WriteLine($"Student {student.FirstName} {student.LastName} is in group {group.Key}");
                }
            }
            Console.WriteLine("---------------------");

        }
    }
}
