using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Contracts
{
    public interface IShape
    {
        double CalculateSurface();

        double Width
        {
            get;
            set;
        }
        double Height
        {
            get;
            set;
        }
    }
}
