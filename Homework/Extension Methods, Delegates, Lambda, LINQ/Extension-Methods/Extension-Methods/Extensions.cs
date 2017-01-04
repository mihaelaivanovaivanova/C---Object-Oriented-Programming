using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder text, int startIndex, int length)
        {
            StringBuilder result=new StringBuilder();
            for (int i = startIndex; i < startIndex+length; i++)
            {
                result.Append(text[i]);
            }
            return result;
        }

        public static T Sum<T>(this IEnumerable<T> elements) where T : IConvertible
        {
            T sum = default (T);
            foreach( T element in elements)
            {
                sum += (dynamic)element;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> elements) where T :IConvertible
        {
            T product = (dynamic)1;
            foreach (T element in elements)
            {
                product *= (dynamic)element;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> elements) where T :IComparable, IConvertible
        {
            T min = default(T);
            foreach (T element in elements)
            {
                if (min.CompareTo(element)>0)
                {
                    min = element;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> elements) where T : IComparable, IConvertible
        {
            T max = default(T);
            foreach (T element in elements)
            {
                if (max.CompareTo(element) < 0)
                {
                    max = element;
                }
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> elements) where T : IComparable, IConvertible
        {
            int counter = 0;
            T sum= elements.Sum();

            foreach (T element in elements)
            {
                counter++;
            }
            T average = (dynamic)sum / (dynamic)counter;
            return average;
        }

    }
}
