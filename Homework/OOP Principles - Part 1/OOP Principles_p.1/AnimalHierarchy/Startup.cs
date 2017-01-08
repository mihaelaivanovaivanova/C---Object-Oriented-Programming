using AnimalHierarchy.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Startup
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Dog("Sharo",5,SexEnum.Male),
                new Dog("Balkan",2,SexEnum.Male),
                new Dog("Nord",3,SexEnum.Male),
                new Dog("Lady",4,SexEnum.Female),
                new Dog("Iggy",7,SexEnum.Female),
                new Frog("Kurmit",12,SexEnum.Male),
                new Frog("Kikirica",14,SexEnum.Female),
                new Frog("Prince",11,SexEnum.Male),
                new Kitten("Fluffy",1),
                new Kitten("Leila",2),
                new Kitten("Rosy",8),
                new Kitten("Roni",7),
                new Tomcat("Tom",4),
                new Tomcat("Garfield",6),
                new Tomcat("Bruno",2),
                new Tomcat("Mars",4)
            };

            var dogs = animals.Where(animal => animal is Dog);
            var frogs = animals.Where(animal => animal is Frog);
            var cats = animals.Where(animal => (animal is Kitten) || (animal is Tomcat));

            foreach(var dog in dogs)
            {
                Console.WriteLine($"{dog.Name} - Age: {dog.Age}");
            }
            Console.WriteLine($"Average dog age: {Animal.CalculateAverageAge(dogs):F2}");

            foreach (var frog in frogs)
            {
                Console.WriteLine($"{frog.Name} - Age: {frog.Age}");
            }
            Console.WriteLine($"Average frog age: {Animal.CalculateAverageAge(frogs):F2}");

            foreach (var cat in cats)
            {
                Console.WriteLine($"{cat.Name} - Age: {cat.Age}");
            }
            Console.WriteLine($"Average cat age: {Animal.CalculateAverageAge(cats):F2}");

        }
    }
}
