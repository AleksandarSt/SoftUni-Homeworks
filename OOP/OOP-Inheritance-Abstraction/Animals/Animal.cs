using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Interfaces;

namespace Animals
{
    public abstract class Animal : ISoundProducible
    {
        private string name;

        private int age;

        private bool isMale;

        protected Animal(string name, int age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.IsMale = isMale;

        }

        public string Name { get; set; }

        public int Age { get; set; }

        public bool IsMale { get; set; }

        public abstract void ProduceSound();
    }
}
