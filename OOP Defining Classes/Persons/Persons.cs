using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Persons
    {
        private string name;
        private int age;
        private string email;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Invalid argument! Age should be between 1 and 100.");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (IsValidEmail(value) == false && value != null)
                {
                    throw new ArgumentException("Invalid e-mail!");
                }

                this.email = value;
            }
        }

        public Persons(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Persons(string name, int age)
            : this(name, age, null)
        {
            this.Name = name;
            this.Age = age;
        }

        private bool IsValidEmail(string email)
        {
            bool isValid = false;
            foreach (char ch in email)
            {
                if (ch == '@')
                {
                    isValid = true;
                    break;
                }
            }
            return isValid;
        }

        public override string ToString()
        {
            return string.Format("Person's name: {0} \nAge: {1} \nemail: {2}", this.name, this.age, this.email);
        }

        static void Main()
        {

            Persons someDude = new Persons("Ivan Ivanov", 50,"bai_ivan@abv.bg");
            //Persons someDude = new Persons("Ivan Ivanov", 150, "bai_ivan@abv.bg");
            //Persons someDude = new Persons("Ivan Ivanov", 50, "shfshdfghg");

            Console.WriteLine(someDude);
        }
    }
}
