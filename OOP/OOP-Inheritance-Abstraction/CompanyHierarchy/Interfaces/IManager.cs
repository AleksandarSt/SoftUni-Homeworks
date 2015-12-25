using CompanyHierarchy.Models;
using System.Collections.Generic;

namespace CompanyHierarchy.Interfaces
{
    public interface IManager : IEmployee
    {
        IEnumerable<Employee> employeesUnderComand { get; }

        void AddEmployee(IEmployee employee);

        void RemoveEmployee(IEmployee employee);
    }
}
