using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevisibleByTwoNums
{
    public static class Extensions
    {
        public static IEnumerable<T> DevisibleByTwoNymbersLambda<T>(this IEnumerable<T> numbers, T num1, T num2)where T : struct
        {
            var result = from number in numbers
                         where ((dynamic)number % num1 == 0) && ((dynamic)number % num2 == 0)
                         select number;
            return result;
        }

        public static IEnumerable<T> DevisibleByTwoNymbersLinq<T>(this IEnumerable<T> numbers, T num1, T num2) where T : struct
        {
            var result = numbers.Where(number => (dynamic)number % num1 == 0 && (dynamic)number % num2 == 0);
            return result;
        }
    }
}
