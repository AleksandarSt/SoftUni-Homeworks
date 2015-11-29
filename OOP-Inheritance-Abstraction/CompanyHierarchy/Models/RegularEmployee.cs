using CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;

namespace CompanyHierarchy.Models
{
    public class RegularEmployee:Employee,IRegularEmployee
    {
       public RegularEmployee(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName,salary,department)
        {
        }
    }
}
