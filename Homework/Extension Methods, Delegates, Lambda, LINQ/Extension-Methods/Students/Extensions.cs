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

        public static IEnumerable<T> OrderByNameDecidingLambda<T>(this IEnumerable<T> students) where T :Students
        {
            var result = students.OrderByDescending(student => student.FirstName)
                    .ThenByDescending(student => student.LastName);
            return result;
        }

        public static IEnumerable<T> OrderByNameDecidingLinq<T>(this IEnumerable<T> students) where T : Students
        {
            var result = from student in students
                         orderby student.FirstName descending,
                         student.LastName descending
                         select student;
            return result;
        }

        public static IEnumerable<T> OrderByNameLinq<T>(this IEnumerable<T> students) where T : Students
        {
            var result = from student in students
                         orderby student.FirstName,
                         student.LastName
                         select student;
            return result;
        }

        public static IEnumerable<string> FilterByAgeRange<T>(this IEnumerable<T> students, int startAge, int endAge) where T :Students
        {
            var result = from student in students
                          where student.Age >= startAge && student.Age <= endAge
                          select student.FullName();

            return result;
        }
    }
}
