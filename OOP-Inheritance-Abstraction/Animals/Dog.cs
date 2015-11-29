using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog:Animal
    {

        public Dog(string name, int age, bool isMale)
            : base(name, age, isMale) 
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("I am {0}, my name is {1}.I can bark: WOW-WOW", this.GetType(), this.Name);
        }

    }
}
