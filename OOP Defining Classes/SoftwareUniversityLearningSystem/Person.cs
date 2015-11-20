using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUniversityLearningSystem
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        #region Constructors

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Person()
            : this(null, null, 0)
        {

        }

        #endregion

        #region Properties

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty.");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value<0||string.IsNullOrEmpty(value.ToString()))
                {
                    throw new ArgumentException("Person Age cannot be null, empty or negative!");
                }

                this.age = value;
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("First name: {0}\nLast name: {1}\nAge: {2}\n",
                            this.FirstName, this.LastName, this.Age);
        }

        #endregion
    }
}
