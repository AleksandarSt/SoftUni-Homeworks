﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programing
{
    public class Student
    {

        public Student
            (
                string firstName,
                string lastName,
                int age,
                string facultyNumber,
                string phone,
                string email,
                IList<int> marks,
                int groupNumber,
                string groupName
            )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.GroupName = groupName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public int GroupNumber { get; set; }

        public IList<int> Marks { get; set; }

        public string GroupName { get; set; }
    }
}
