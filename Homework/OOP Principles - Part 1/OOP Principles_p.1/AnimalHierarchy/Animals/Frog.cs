using AnimalHierarchy.Contracts;
using System;

namespace AnimalHierarchy.Animals
{
    public class Frog:Animal,ISound
    {
        public Frog(string name, int age, SexEnum sex): base(name, age, sex)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Kuuuaaak!");
        }
    }
}
