using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part2.Point
{
    static class PathStorage
    {
        private static string fileDirectory = Directory.GetCurrentDirectory()+"\\Storage.txt";

        static PathStorage()
        {
            fileDirectory = Directory.GetCurrentDirectory() + "\\Storage.txt";
        }

        private static string CreateRandomPoint(int index)
        { 

            return RandomPoint(index).ToString();
        }

        public static StringBuilder RandomPoint(int index)
        {
            Random rnd = new Random();
            StringBuilder returnPoints = new StringBuilder();
            for (int i = 0; i < index; i++)
            {
                Point3D point = new Point3D();
                point.X = rnd.Next(-200, 201);
                point.Y = rnd.Next(-200, 201);
                point.Z = rnd.Next(-200, 201);
                returnPoints.Append($"{point.X} {point.Y} {point.Z}");
                if (i != index - 1)
                {
                    returnPoints.AppendLine();
                }
            }

            return returnPoints;
        }

        internal static void WritePoint(int pointsToWrite)
        {
            var writer = new StreamWriter(fileDirectory, false);

            if (!File.Exists(fileDirectory))
            {
                File.CreateText(fileDirectory);
            }

            using (writer)
            {
                writer.WriteLine(CreateRandomPoint(pointsToWrite));
            }
        }

         internal static void FillFile(int fillPoints)
        {
            var writer = new StreamWriter(fileDirectory, false);

            if (!File.Exists(fileDirectory))
            {
                File.CreateText(fileDirectory);
            }

            using (writer)
            {
                writer.WriteLine(RandomPoint(fillPoints));
            }
        }
        internal static void ReadPoints(int numPoints)
        {
            for (int i = 0; i < numPoints; i++)
            {
                FillFile(numPoints);
            }

            var reader = new StreamReader(fileDirectory);
            string line;
            Path path = new Path();
            while ((line = reader.ReadLine()) != null)
            {
                var separator = new char[] { ' ', ',', '(', ')', '{', '}' };
                var coordinates = line.Split(separator, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(double.Parse)
                                      .ToArray();

                double X = coordinates[0];
                double Y = coordinates[1];
                double Z = coordinates[2];
                path.Add(new Point3D(X, Y, Z));
            }
            for (int i = 0; i < path.Length(); i++)
            {
                Console.WriteLine(path[i].ToString());
            }
        }
    }
}
