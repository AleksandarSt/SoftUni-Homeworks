using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUniversityLearningSystem
{
    class Trainer:Person
    {

        #region Constructors

        public Trainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {

        }

        #endregion

        #region Methods

        public void CreateCourse(string courseName)
        {
            Console.WriteLine("Course {0} has been created!", courseName);
        }

        public override string ToString()
        {
            string result = base.ToString() + string.Format("Role: {0}\n", this.GetType().Name);
            return result;
        }

        #endregion
    }
}
