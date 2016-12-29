using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part2.Point
{
    class Path
    {
        private List<Point3D> sequenceOfPoints;
        public Path()
        {
            this.sequenceOfPoints = new List<Point3D>();
        }

        public List<Point3D> SequenceOfPoints
        {
            get
            {
                return this.sequenceOfPoints;
            }
        }

        public Point3D this[int index] // always do it in this way and not with a method!!!
        { 
            get
            {
                return this.sequenceOfPoints[index];
            }

            set
            {
                this.SequenceOfPoints[index] = value; // sets a value at a certan index of the list
            }
        }

        public int Length()
        {
            return this.sequenceOfPoints.Count;
        }

        public void Add(Point3D point)
        {
            this.sequenceOfPoints.Add(point);
        }

        public void RemoveFirstMatch(Point3D point)
        {
            int length = this.Length();

            for (int i = 0; i < length; i++)
            {
                if (this.sequenceOfPoints[i].Equals(point))
                {
                    this.sequenceOfPoints.Remove(this.sequenceOfPoints[i]);
                    break;
                }
            };
        }

        public void RemoveAllMatches(Point3D point)
        {
            int length = Length();

            for (int i=0; i<length; i++)
            {
                if (this.sequenceOfPoints[i].Equals(point))
                {
                    this.sequenceOfPoints.Remove(this.sequenceOfPoints[i]);
                }
            }
        }

        public void RemoveAt(int index)
        {
            this.sequenceOfPoints.RemoveAt(index);
        }

        public void Print(Path path)
        {
            for (int i = 0; i < path.Length(); i++)
            {
                Console.WriteLine(path[i].ToString());
            }
        }

    }
}
