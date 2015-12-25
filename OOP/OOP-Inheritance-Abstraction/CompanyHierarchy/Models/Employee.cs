using CompanyHierarchy.Interfaces;
using System;

namespace CompanyHierarchy.Models
{
    public abstract class Employee:Person,IEmployee
    {
        private decimal salary;

        private Department department;

        public Employee(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary 
        {
            get { return this.salary; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative.");
                }
            }
        }

        public Department Department { get; set; }

        public override string ToString()
        {
            return String.Format(
                "Employee Report (" +
                this.GetType().Name +
                "):" +
                Environment.NewLine +
                this.FirstName +
                " " +
                this.LastName +
                Environment.NewLine +
                "ID: " +
                this.Id +
                Environment.NewLine +
                "Salary: " +
                this.Salary +
                Environment.NewLine +
                "Department: " +
                this.Department.ToString() +
                Environment.NewLine);
        }
    }
}
