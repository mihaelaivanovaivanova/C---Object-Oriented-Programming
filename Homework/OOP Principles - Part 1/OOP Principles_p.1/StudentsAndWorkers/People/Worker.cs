using StudentsAndWorkers.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers.People
{
   public class Worker:Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName,string lastName, double weekSalary,double workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkkHoursPerDay = workHoursPerDay;
        }

        protected double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                Validators.SalaryValidation(value);
                this.weekSalary = value;
            }
        }

        protected double WorkkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                Validators.WorkHoursPerDayValidation(value);
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            double moneyPerHour = this.weekSalary / (Constants.workingDaysInWeek * workHoursPerDay);
            return moneyPerHour;
        }
    }
}
