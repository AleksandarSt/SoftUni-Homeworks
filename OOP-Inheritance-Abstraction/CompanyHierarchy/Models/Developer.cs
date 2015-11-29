using CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using CompanyHierarchy.Models;

namespace CompanyHierarchy.Models
{
    public class Developer : RegularEmployee, IDeveloper
    {
        public Developer(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName,salary,department)
        {
        }

        public IEnumerable<IProject> Projects
        {
            get;
            set;
        }
    }
}
