using CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;

namespace CompanyHierarchy.Models
{
    public class Project : IProject
    {
        private string projectName;

        public Project(string projectName, DateTime startDate, State state, string details)
        {
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.State = state;
            this.Details = details;
        }

        public string ProjectName
        {
            get
            {
                return this.projectName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Project name cannot be empty");
                }
                this.projectName = value;
            }
        }

        public DateTime StartDate
        {
            get;
            set;
        }

        public State State
        {
            get;
            set;
        }

        public string Details
        {
            get;
            set;
        }

        public void CloseProject()
        {
            Console.WriteLine("Project is closed!");
        }
    }
}
