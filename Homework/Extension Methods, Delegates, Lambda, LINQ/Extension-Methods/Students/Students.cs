using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
   public class Students
    {
        private string firstName;
        private string lastName;
        private ushort age;
        public long Fn { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<byte> Marks { get; set; }
        public int GroupNumber { get; set; }
        public Students(string firstName, string lastName, ushort age, long fn, string tel, string email, List<byte> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Fn = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value.Length <= 1)
                {
                    throw new ArgumentException("First name must be at least 2 sybbols long");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value.Length <= 1)
                {
                    throw new ArgumentException("Last name must be at least 2 sybbols long");
                }
                this.lastName = value;
            }
        }

            public ushort Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value <= 6)
                {
                    throw new ArgumentOutOfRangeException("The age of the student can not be less than 6 years!");
                }
                if (value >= 50)
                {
                    throw new ArgumentOutOfRangeException("The age of the student can not be more than 50 years!");
                }
                this.age = value;
            }
        }
    }
}
