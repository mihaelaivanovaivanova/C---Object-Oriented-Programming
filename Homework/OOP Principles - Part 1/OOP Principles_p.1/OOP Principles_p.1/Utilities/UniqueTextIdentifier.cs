using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Utilities
{
   public static class UniqueTextIdentifier
    {
        private static IList<string> usedIdentifiers;
        static UniqueTextIdentifier()
        {
            usedIdentifiers = new List<string>();
        }

        public static string GenerateUniqueIdentifier()
        {
            while (true)
            {
                Random rnd = new Random();
                string identifier = RandomText(rnd, string.Empty);

                if (usedIdentifiers.IndexOf(identifier) < 0)
                {
                    usedIdentifiers.Add(identifier);
                    return identifier;
                }
            }
        }

        static string RandomText(Random number, string rndIdentifier)
        {
            for (int i = 0; i < 6; i++)
            {
                int lowerOrUpper = number.Next(0, 2);

                if (lowerOrUpper == 0)
                {
                    rndIdentifier += (char)number.Next(65, 91);
                }
                else
                {
                    rndIdentifier += (char)number.Next(97, 123);
                }
            }
            return rndIdentifier;
        }
    }
}
