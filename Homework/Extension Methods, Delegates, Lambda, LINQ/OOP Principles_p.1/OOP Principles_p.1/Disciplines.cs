using School.Utilities;

namespace School
{
    public class Disciplines
    {
        private string name;

        public Disciplines(string name, int numberrOfLectures, int numberOfExcersises)
        {
            this.Name = name;
            this.NumberOfLectures = numberrOfLectures;
            this.NumberOfExcersises = numberOfExcersises;
        }

        public int NumberOfLectures { get; set; }
        public int NumberOfExcersises { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validations.NameValidation(value);
                this.name = value;
            }
        }

    }
}
