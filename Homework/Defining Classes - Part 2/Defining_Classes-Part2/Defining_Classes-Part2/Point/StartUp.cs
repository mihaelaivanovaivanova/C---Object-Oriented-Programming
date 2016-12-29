using Defining_Classes_Part2.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part2
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Path somePath = new Path();
            somePath.Add(new Point3D(4, 8, 6));
            for (int i = 0; i < 10; i++)
            {
                somePath.Add(new Point3D(i+5, i-3, i));
            }
            for (int i = 0; i < somePath.Length(); i++)
            {
                Console.WriteLine(somePath[i].ToString());
            }
            somePath.RemoveFirstMatch(new Point3D(4, 8, 6));
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < somePath.Length(); i++)
            {
                Console.WriteLine(somePath[i].ToString());
            }

            PathStorage.WritePoint();
            PathStorage.ReadPoints(8);

        }
    }
}
