using School.People;
using System;


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

            Teacher maria = new Teacher("Maria", "Ivanova");
            Teacher pesho = new Teacher("Petar", "Iordanov");


            Class class8A = new Class();
            Class class8B = new Class();
            Console.WriteLine(class8A.UniqueTextIdentifier);
            Console.WriteLine(class8B.UniqueTextIdentifier);

            class8A.AddStudent(ivan);
            class8A.AddTeacher(maria);
            class8B.AddStudent(stamat);

            maria.AddComment("This is an amazing teacher!");
            maria.AddComment("She isnt that good, duh");
            maria.RemoveComment("She isnt that good, duh");


        }
    }
}
