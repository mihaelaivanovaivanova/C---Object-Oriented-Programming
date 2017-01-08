
namespace StudentsAndWorkers.Utilities
{
    public class Constants
    {
        public const string NameValidationLengthException = "Name must be at least 2 symbols long!";
        public const string NameValidationNullException = "Name can not be null!";
        public const string GradeValidationException = "Grade must be a number between 1 and 12!";
        public const int firstGrade = 1;
        public const int lastGrade = 12;
        public const double minWeekSalary = 120;
        public const double maxWeekSalary = 1300;
        public const string SalaryValidationException = "Week salary must be between 120 and 1300 lv.!";
        public const double maxWorkingHours = 8;
        public const double minWorkingHours = 1;
        public const string WorkingHoursException = "Working hours per day must be between 1 and 8";
        public const int workingDaysInWeek = 5;


    }
}
