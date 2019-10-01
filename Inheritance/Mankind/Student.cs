namespace Mankind
{
    using System;
    using System.Linq;
    using System.Text;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string number)
            : base(firstName, lastName)
        {
            this.FacultyNumber = number;
        }

        public string FacultyNumber
        {
            get => this.facultyNumber;
            private set
            {
                this.ValidateFacultyNumber(value);
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"First Name: {this.FirstName}");
            result.AppendLine($"Last Name: {this.LastName}");
            result.AppendLine($"Faculty number: {this.FacultyNumber}");

            return result.ToString();
        }

        private void ValidateFacultyNumber(string value)
        {
            if (value.Length < 5 ||
                value.Length > 10
                || value.All(c => char.IsLetterOrDigit(c) == false))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
        }
    }
}
