using StudentsAndWorkers.Utilities;

namespace StudentsAndWorkers.People
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                Validators.ValidateName(value);
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                Validators.ValidateName(value);
                this.lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return $"{this.FirstName} {this.LastName}";
            }
        }

    }
}
