using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers.Utilities
{
    public class Validators
    {
        public static void ValidateName(string name)
        {
            if (name.Length <= 1)
            {
                throw new ArgumentOutOfRangeException(Constants.NameValidationLengthException);
            }

            if (name == null)
            {
                throw new ArgumentNullException(Constants.NameValidationNullException);
            }
        }

        public static void GradeValidation(int grade)
        {
            if (grade < Constants.firstGrade || grade > Constants.lastGrade)
            {
                throw new ArgumentOutOfRangeException(Constants.GradeValidationException);
            }
        }

        public static void SalaryValidation(double salary)
        {
            if (salary < Constants.minWeekSalary || salary > Constants.maxWeekSalary)
            {
                throw new ArgumentOutOfRangeException(Constants.SalaryValidationException);
            }
        }

        public static void WorkHoursPerDayValidation(double hours)
        {
            if (hours < Constants.minWorkingHours || hours > Constants.maxWorkingHours)
            {
                throw new ArgumentOutOfRangeException(Constants.WorkingHoursException);
            }
        }
    }
}
