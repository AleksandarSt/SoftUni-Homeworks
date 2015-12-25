using CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;

namespace CompanyHierarchy.Models
{
    public class Manager : Employee,IManager
    {
        public Manager(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName,salary,department)
        {
        }

        public IEnumerable<Employee> employeesUnderComand
        {
            get;
            set;
        }


        public void AddEmployee(IEmployee employee)
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(IEmployee employee)
        {
            throw new NotImplementedException();
        }
    }
}
