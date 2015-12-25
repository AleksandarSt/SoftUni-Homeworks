using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Tomcat:Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, true) 
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("I am {0}, my name is {1}.I can meow: Mrrrr-Miau", this.GetType(), this.Name);
        }
    }
}
