using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Student_Worker
{
    class Worker:Human
    {
        const int weekWorkDays = 5;

        private decimal weeklySalary;

        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weeklySalary, decimal workHoursPerDay)
            :base(firstName,lastName)
        {
            this.WeeklySalary = weeklySalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeeklySalary
        {
            get { return this.weeklySalary; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative.");
                }

                this.weeklySalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Work hours cannot be negative.");
                }

                this.workHoursPerDay = value;
            }
        }


        public decimal MoneyPerHour()
        {
            return this.WeeklySalary / (this.WorkHoursPerDay * weekWorkDays);
        }
    }
}
