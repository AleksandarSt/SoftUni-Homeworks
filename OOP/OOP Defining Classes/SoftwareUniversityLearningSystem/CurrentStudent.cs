using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUniversityLearningSystem
{
    class CurrentStudent : Student
    {
        private string currentCourse;

        #region Constructors
        
        public CurrentStudent(string firstName, string lastName, int age,int studentNumber, double averageGrade, string currentCourse)
            : base(firstName, lastName, age,studentNumber, averageGrade) 
        {
            this.CurrentCourse = currentCourse;
        }

        #endregion

        #region Properties

        public string CurrentCourse 
        {
            get { return this.currentCourse; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Current course cannot be empty!");
                }

                this.currentCourse = value;
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return base.ToString() + string.Format("Current course : {0}\n", this.CurrentCourse);
        }

        #endregion
    }
}
