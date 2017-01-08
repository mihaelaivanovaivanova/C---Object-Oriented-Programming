using AnimalHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Animals
{
    class Kitten:Cat,ISound
    {
        public Kitten(string name, int age): base(name, age, SexEnum.Female)
        {
        }

    }
}
