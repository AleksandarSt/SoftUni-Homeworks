using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog:Animal
    {
        public Frog(string name, int age, bool isMale)
            : base(name, age, isMale) 
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("I am {0}, my name is {1}.I can qwak: Qwak-Qwak", this.GetType(), this.Name);
        }
    }
}
