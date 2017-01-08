using AnimalHierarchy.Contracts;
using AnimalHierarchy.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace AnimalHierarchy.Animals
{
    public abstract class Animal:ISound
    {
        private int age;
        private string name;

        public Animal(string name, int age, SexEnum sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validations.NameValidation(value);
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                Validations.AgeValidation(value);
                this.age = value;
            }
        }
        
        public SexEnum Sex { get; }

        public abstract void ProduceSound();
        public static double CalculateAverageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(a => a.Age);
        }
    }
}
