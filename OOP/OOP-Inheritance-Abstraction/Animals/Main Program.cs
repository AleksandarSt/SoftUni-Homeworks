using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Main_Program
    {
        static void Main()
        {
            Animal[] animals = new Animal[10]
            {
                new Dog("Sharo",12,true),
                new Dog("Rex",10,true),
                new Cat("Puffy",8,false),
                new Cat("Tom",5,true),
                new Frog("Jaba",3,true),
                new Frog("Princes-Frog",22,false),
                new Tomcat("Garfield",13),
                new Tomcat("Gaspar",9),
                new Kitten("Shely",7),
                new Kitten("Cherry",9)
            };

            //foreach (var item in animals)
            //{
            //    item.ProduceSound();
            //}

            //animals.ToList().ForEach(Console.WriteLine);
            //Console.WriteLine();

            animals
                .GroupBy(animal => animal.GetType().Name)
                .Select(group => new
                {
                    AnimalName = group.Key,
                    AverageAge = group.Average(a => a.Age)
                }
                )
                .OrderBy(group => group.AverageAge)
                .ToList()
                .ForEach(group => Console.WriteLine("{0}'s average age is: {1}",group.AnimalName,group.AverageAge));
        }
    }
}
