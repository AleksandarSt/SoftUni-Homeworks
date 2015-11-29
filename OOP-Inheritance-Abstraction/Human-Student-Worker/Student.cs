using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Student_Worker
{
    class Student:Human
    {
        private string facultyNumber;

        public Student(string firsName, string lastName, string facultyNumber) 
            :base(firsName,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set 
            {
                if (value.Length<5||value.Length>10||string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Faculty number cannot be null or empty and must be between 5 and 10 characters invlusive");
                }

                this.facultyNumber=value;
            }
        }
    }
}
