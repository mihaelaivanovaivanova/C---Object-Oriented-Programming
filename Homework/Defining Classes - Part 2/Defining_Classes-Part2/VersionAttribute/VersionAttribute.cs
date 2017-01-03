using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    public class VersionAttribute : Attribute
    {
        private ushort Major { get; set; }
        private ushort Minor { get; set; }

        public VersionAttribute(ushort major, ushort minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public string Version
        {
            get
            {
                return string.Format($"{this.Major}.{this.Minor}");
            }
        }
    }
}
