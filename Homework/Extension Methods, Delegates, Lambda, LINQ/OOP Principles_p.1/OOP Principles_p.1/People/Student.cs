
namespace School.People
{
    class Student:Person
    {
        private static int numberCount = 0;
        private int classNumber;

        public Student(string firstName, string lastName):base(firstName,lastName)
        {
            this.ClassNumber = classNumber;

        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
          private set
            {
                numberCount++;
                this.classNumber = numberCount;
            }
        }
    }
}
