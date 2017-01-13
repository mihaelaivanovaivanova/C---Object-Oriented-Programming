using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_Exceptions
{
    class Startup
    {
        private const string InvalidInput = "Invalid input!";

        public static void Main()
        {
            var numbers = new int[] { -335, 7, 1099 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                if (numbers[i] < 0 || numbers[i] > 100)
                {
                    try
                    {
                        throw new InvalidRangeException<int>(InvalidInput, 1, 100);
                    }
                    catch (InvalidRangeException<int> e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    Console.WriteLine();
                }
            }

            DateTime date = new DateTime(1945, 03, 05);
            DateTime start = new DateTime(1980, 01, 01);
            DateTime end = new DateTime(2013, 12, 31);

            if (date < start || date > end)
            {
                try
                {
                    throw new InvalidRangeException<DateTime>(InvalidInput, new DateTime(1980, 01, 01), new DateTime(2013, 12, 31));
                }
                catch (InvalidRangeException<DateTime> e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}