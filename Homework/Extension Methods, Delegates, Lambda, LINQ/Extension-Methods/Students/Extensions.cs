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

        public static IEnumerable<T> FilterByGroup<T>(this IEnumerable<T> students, int groupNum)where T: Students
        {
            var result = from student in students
                         where student.GroupNumber.CompareTo(groupNum) == 0
                         select student;

            return result;
        }

        public static IEnumerable<T> FilterByEmail<T>(this IEnumerable<T> students, string pattern) where T : Students
        {
            var result = from student in students
                         where student.Email.Contains(pattern)
                         select student;

            return result;
        }

        public static IEnumerable<T> FilterByPhone<T>(this IEnumerable<T> students, string pattern) where T : Students
        {
            var result = from student in students
                         where student.Tel.StartsWith(pattern)
                         select student;

            return result;
        }

        public static object[] FilterByMarks<T>(this IEnumerable<T> students, byte mark) where T :Students
        {
            var result = students.Where(s => s.Marks.Contains(mark))
                .Select(s => new
                {
                    FullName = s.FullName(),
                    Marks = string.Join(" ",s.Marks)
                }).ToArray();

            return result;
        }

        public static IEnumerable<T> FilterByMarksCount<T>(this IEnumerable<T> students, byte count) where T : Students
        {
            var result = students.Where(s => s.Marks.Count == count);

            return result;
        }
    }
}
