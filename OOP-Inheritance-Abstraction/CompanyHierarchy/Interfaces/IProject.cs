using CompanyHierarchy.Models;
using System;
using System.Collections.Generic;

namespace CompanyHierarchy.Interfaces
{
    public interface IProject
    {
        string ProjectName { get; set; }

        DateTime StartDate { get; set; }

        string Details { get; set; }

        State State { get; set; }

        void CloseProject();
    }
}
