using System;
using System.Collections.Generic;

namespace CompanyHierarchy.Interfaces
{
    public interface IDeveloper : IRegularEmployee
    {
        IEnumerable<IProject> Projects { get; set; }
    }
}
