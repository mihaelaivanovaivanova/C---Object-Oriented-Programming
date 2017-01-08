using School.Contracts;
using School.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Contracts
{
    public interface IClass
    {
        void AddStudent(Student student);
        void AddTeacher(Teacher teacher);
        void RemoveStudent(Student student);
        void RemoveTeacher(Teacher teacher);

    }
}
