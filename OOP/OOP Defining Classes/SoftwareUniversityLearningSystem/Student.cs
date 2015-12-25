using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUniversityLearningSystem
{
    class Student : Person
    {
        private int studentNumber;
        private double averageGrade;

        #region Constructor

        public Student(string firstName, string lastName, int age,int studentNumber, double averageGrade)
            :base(firstName,lastName,age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        #endregion

        #region Properties

        public int StudentNumber 
        {
            get { return this.studentNumber; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentException("Student Number cannot be negative!");
                }
                this.studentNumber = value;
            }
        }

        public double AverageGrade
        {
            get { return this.averageGrade; }
            set
            {
                if (value < 0||value>6)
                {
                    throw new ArgumentException("Student Number cannot be negative or bigger than 6!");
                }
                this.averageGrade = value;
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return base.ToString() + string.Format("Role: {0}\nStudent number: {1}\nAverage grade: {2}\n",
                                            this.GetType().Name, this.StudentNumber, this.AverageGrade);
        }

        #endregion

    }
}
