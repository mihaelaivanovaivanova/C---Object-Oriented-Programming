using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder someText = new StringBuilder();
            someText.Append("This is just for the needs of the test");
            string partText = someText.Substring(8, 18).ToString();
            Console.WriteLine(partText);
            Console.WriteLine("----------------------------");

            List<double> someDoubleList = new List<double>();
            for (int i = 0; i < 12; i++)
            {
                someDoubleList.Add((i * 8 - 3) / 5.0);
            }
            foreach (var item in someDoubleList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            double sum = someDoubleList.Sum();
            double product = someDoubleList.Product();
            double min = someDoubleList.Min();
            double max = someDoubleList.Max();
            double avrg = someDoubleList.Average();
            Console.WriteLine("sum= "+sum);
            Console.WriteLine("product={0:F2}", product);
            Console.WriteLine("min="+min);
            Console.WriteLine("max=" + max);
            Console.WriteLine("average={0:F2}",avrg);
        }
    }
}
