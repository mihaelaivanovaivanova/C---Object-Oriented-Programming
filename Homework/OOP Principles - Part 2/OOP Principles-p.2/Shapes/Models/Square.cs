using Shapes.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Models
{
    public class Square:Rectangle, IShape
    {
        public Square(double width) : base(width, width)
        {

        }
    }
}
