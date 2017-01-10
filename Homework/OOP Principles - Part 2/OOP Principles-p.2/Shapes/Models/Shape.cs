using Shapes.Contracts;
using Shapes.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Models
{
    public abstract class Shape:IShape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                Validations.DimentionValidation(value);
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                Validations.DimentionValidation(value);
                this.height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}
