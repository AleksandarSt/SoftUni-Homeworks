﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUniversityLearningSystem
{
    class OnlineStudent:CurrentStudent
    {
        #region Constructors

        public OnlineStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse)
            :base(firstName,lastName,age,studentNumber, averageGrade,currentCourse)
        {

        }

        #endregion
    }
}
