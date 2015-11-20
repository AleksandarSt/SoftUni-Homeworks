using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUniversityLearningSystem
{
    class OnsiteStudent:CurrentStudent
    {
        private int numberOfVisits;

        #region Constructors

        public OnsiteStudent(string firstName, string lastName, int age,int studentNumber, double averageGrade, string currentCourse,int numberOfVisits)
            :base(firstName,lastName,age,studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        #endregion

        #region Properties

        public int NumberOfVisits
        {
            get { return this.numberOfVisits; }
            set
            {
                if (value<0)
                {
                    throw  new ArgumentException("Number of visits cannot be negative!");
                }

                this.numberOfVisits = value;
            }
        }

        #endregion
    }
}
