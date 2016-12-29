using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part2
{
    struct Point3D
    {
        private static readonly Point3D pointO = new Point3D(0, 0, 0);

        public static Point3D PointO
        {
            get
            {
                return pointO;
            }
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            string coordinates = $"Point coordinates: x={this.X}; y={this.Y}; z={this.Z}";
            return coordinates;
        }

    }
}
