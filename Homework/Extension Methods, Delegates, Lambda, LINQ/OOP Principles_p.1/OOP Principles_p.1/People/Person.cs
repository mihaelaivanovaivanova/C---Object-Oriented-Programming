
using School.Utilities;

namespace School.People
{
    class Person
    {
        private string firstName;
        private string lastName;
        
        public Person(string firstName, string lastName)
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
                Validations.NameValidation(value);
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
                Validations.NameValidation(value);
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
