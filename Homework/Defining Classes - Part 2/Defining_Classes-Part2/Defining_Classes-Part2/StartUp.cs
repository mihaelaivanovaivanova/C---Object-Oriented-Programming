using System;

namespace Defining_Classes_Part2.Point
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

            PathStorage.WritePoint(3);

            Console.WriteLine("-------------------------------------");
            //PathStorage.ReadPoints(15);

            Point3D firstPoint = new Point3D(5, 8, 2);
            Point3D secondPoint = new Point3D(2, 3, 6);
            double distance = Distance.CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine($"{distance:F2}");
            
        }
    }
}
