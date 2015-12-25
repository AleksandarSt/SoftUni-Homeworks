using CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;

namespace CompanyHierarchy.Models
{
    class SalesEmployee:RegularEmployee,ISalesEmployee
    {

        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
 
        }
        public IList<ISale> Sales
        {
	        get { throw new NotImplementedException(); }
        }
    }
}
