using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten:Cat
    {
        public Kitten(string name, int age)
            : base(name, age, false) 
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("I am {0}, my name is {1}.I can meow: Miau-Miau", this.GetType(), this.Name);
        }
    }
}
