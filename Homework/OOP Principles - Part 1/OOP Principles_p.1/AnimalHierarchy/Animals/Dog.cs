using AnimalHierarchy.Contracts;
using System;

namespace AnimalHierarchy.Animals
{
    public class Dog:Animal,ISound
    {
        public Dog(string name, int age, SexEnum sex): base(name, age, sex)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("BauUauUuu!");
        }
    }
}
