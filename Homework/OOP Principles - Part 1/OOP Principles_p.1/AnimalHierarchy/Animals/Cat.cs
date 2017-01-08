using System;
using AnimalHierarchy.Contracts;

namespace AnimalHierarchy.Animals
{
    public class Cat: Animal,ISound
    {
        public Cat(string name,int age, SexEnum sex): base(name, age, sex)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meooouu!");
        }
    }
}
