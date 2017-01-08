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

            List<Worker> workers = new List<Worker>
            {
                new Worker("Stoyan", "Asenov",840,6),
                new Worker("Venci", "Argirov",220,5),
                new Worker("Asya", "Lilova",610,7),
                new Worker("Tanya", "Ivanova",470,8),
                new Worker("Kristina", "Kamenova",280,8),
                new Worker("Veselin", "Ivanov",190,6),
                new Worker("Krasimir", "Stoyanov",140,7),
                new Worker("Lili", "Zaharieva",1000,7),
                new Worker("Tihomir", "Asenov",1100,8),
                new Worker("Alexandra", "Biyazova",130,8)
            };

            var orderedWorkers = workers.OrderBy(worker => worker.MoneyPerHour());
            foreach (var worker in orderedWorkers)
            {
                Console.WriteLine($"{worker.FullName} - Salary per hour:{worker.MoneyPerHour():F2}");
            }

            List<Human> mergedList =new List<Human>();
            mergedList.AddRange(students);
            mergedList.AddRange(workers);

            var sortedPeople = mergedList.OrderBy(person => person.FirstName)
                .ThenBy(person => person.LastName);
            foreach(var person in sortedPeople)
            {
                Console.WriteLine(person.FullName);
            }
        }
    }
}
