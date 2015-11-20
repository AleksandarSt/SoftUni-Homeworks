using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUniversityLearningSystem
{
    class DropoutStudent:Student
    {

        private string dropoutReason;

        #region Constructors

        public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string dropoutReason)
            : base(firstName, lastName, age,studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        #endregion

        #region Properties

        public string DropoutReason
        {
            get { return this.dropoutReason; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw  new ArgumentException("Dropout reason cannot be null or empty!");
                }

                this.dropoutReason = value;
            }
        }

        #endregion

        #region Methods

        public string Reapply()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("First Name: {0}", this.FirstName));
            result.AppendLine(string.Format("Last Name: {0}", this.LastName));
            result.AppendLine(string.Format("Age: {0}", this.Age));
            result.AppendLine(string.Format("Student Number: {0}", this.StudentNumber));
            result.AppendLine(string.Format("Average grade: {0}", this.AverageGrade));
            result.AppendLine(string.Format("Dropout Reason: {0}", this.DropoutReason));

            return result.ToString();
        }
        #endregion
    }
}
