using Defining_Classes_Part2.Generic_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class
{
    class StartUp
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>(5);
            Console.WriteLine(list.Size);
            list.AddElement(128);

            for (int i = 0; i < 6; i++)
            {
                list.AddElement(i * 2 + 3);
            }

            Console.WriteLine(list.Size);

            Console.WriteLine(list.ToString());

            Console.WriteLine("Number of elements before removal:{0}",list.Count);

            list.RemoveElementAtIndex(3);
            Console.WriteLine(list.ToString());

            Console.WriteLine("Number of elements after removal:{0}", list.Count);

            list.InsertElementAtIndex(4, 1000);
            Console.WriteLine(list.ToString());

            Console.WriteLine("Number of elements after insertion:{0}", list.Count);

            Console.WriteLine("Element 1000 is at possition {0}",list.FindElementByValue(1000)); 

            Console.WriteLine($"Min: {list.Min()}");
            Console.WriteLine($"Max: {list.Max()}");

            list.Clear();
            Console.WriteLine("Number of elements after clear:{0}", list.Count);
        }
    }
}
