
using School.Utilities;

namespace School.People
{
    public class Person
    {
        private string firstName;
        private string lastName;
        
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        protected string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                Validations.NameValidation(value);
                this.firstName = value;
            }
        }

        protected string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                Validations.NameValidation(value);
                this.lastName = value;
            }
        }

        protected string FullName
        {
            get
            {
                return $"{this.FirstName} {this.LastName}";
            }
        }

    }
}
