using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Contracts
{
    public interface ITeacher
    {
        void AddDiscipline(Disciplines discipline);
        void RemoveDiscipline(Disciplines discipline);

    }
}
