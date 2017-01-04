using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public static class Extensions
    {
        public static IEnumerable<T> StudentFirstNameBeforeLastName<T>(this IEnumerable<T> students) where T:Students
        {
            var result = from student in students
                         where student.FirstName.CompareTo(student.LastName) < 0
                         select student;

            return result;
        }

        public static void OrderByName<T>(this IEnumerable<T> students) where T :Students
        {
            students.OrderBy(student => student.FirstName)
                    .ThenBy(student => student.LastName);
        }

        public static IEnumerable<T> FiltelByAgeRange<T>(IEnumerable<T> students, int startAge, int endAge) where T :Students
        {
            var result = from student in students
                         where student.Age>=startAge&&student.Age<=endAge
                         select { student.FirstName, student.LastName }.;

            return result;
        }
    }
}
