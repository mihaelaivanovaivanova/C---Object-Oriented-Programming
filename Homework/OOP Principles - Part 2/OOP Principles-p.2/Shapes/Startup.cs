using Shapes.Contracts;
using Shapes.Models;
using System;

namespace Shapes
{
    class Startup
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new Shape[5]
            {
                new Rectangle(2,5),
                new Triangle(8.5,4),
                new Square(12),
                new Triangle(3.1,8),
                new Rectangle(6.2,7)
            };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(shapes[i].CalculateSurface());
            }
    
        }
    }
}
