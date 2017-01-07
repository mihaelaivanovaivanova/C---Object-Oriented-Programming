using School.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Startup
    {
        static void Main(string[] args)
        {
            Student ivan = new Student("Ivan", "Ivanov");
            Student stamat = new Student("Stamat", "Traykov");
            Console.WriteLine(ivan.ClassNumber);
            Console.WriteLine(stamat.ClassNumber);

        }
    }
}
