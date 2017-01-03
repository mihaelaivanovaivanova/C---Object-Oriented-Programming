using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [Version(2, 4)]
    class SampleClass
    {
        public static void PrintVersion()
        {
            var type = typeof(SampleClass);
            var attributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attribute in attributes)
            {
                Console.WriteLine($"Version: {attribute.Version}");
            }
        }
    }
}
