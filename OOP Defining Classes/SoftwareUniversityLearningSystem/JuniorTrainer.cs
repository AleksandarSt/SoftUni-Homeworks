using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUniversityLearningSystem
{
    class JuniorTrainer:Trainer
    {
        #region Constructors

        public JuniorTrainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age) 
        {

        }

        #endregion
    }
}
