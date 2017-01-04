using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevisibleByTwoNums
{
    class Startup
    {
        static void Main(string[] args)
        {
            /* Problem 6. Divisible by 7 and 3
Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.*/

            int[] IntNumArray = new int[] { 4, 8, 14, 21, 35, 53, 60, 70, 42, 101, 111, 84 };
            var devidableBy3And7Lambda = IntNumArray.DevisibleByTwoNymbersLambda(3, 7);
            foreach(int num in devidableBy3And7Lambda)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------");

            var devidableBy3And7Linq = IntNumArray.DevisibleByTwoNymbersLinq(3, 7);
            foreach (int num in devidableBy3And7Linq)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

        }
    }
}
