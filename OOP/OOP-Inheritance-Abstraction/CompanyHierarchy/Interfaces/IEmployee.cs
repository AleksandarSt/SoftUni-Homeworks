using CompanyHierarchy.Models;


namespace CompanyHierarchy.Interfaces
{
    public interface IEmployee : IPerson
    {
        decimal Salary { get; }

        Department Department { get; }
    }
}
