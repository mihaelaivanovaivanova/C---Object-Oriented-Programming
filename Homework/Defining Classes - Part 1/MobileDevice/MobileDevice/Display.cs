using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class Display
    {
        private int? size=null;
        private int? numOfColors=null;

        public Display(int? size, int? numOfColors)
        {
            this.Size = size;
            this.NumOfColors = numOfColors;
        }

        public int? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Size must have a positive value!");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public int? NumOfColors
        {
            get
            {
                return this.numOfColors;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The number of colors must have a positive value!");
                }
                else
                {
                    this.numOfColors = value;
                }
            }
        }
    }
}
