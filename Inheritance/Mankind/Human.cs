namespace Mankind
{
    using System;

    public class Human
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
            get => this.firstName;
            private set
            {
                this.ValidateFirstName(value);
                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            set
            {
                this.ValidateLastName(value);
                this.lastName = value;
            }
        }

        private void ValidateFirstName(string value)
        {
            if (!char.IsUpper(value[0]))
            {
                throw new
                    ArgumentException($"Expected upper case letter! Argument: firstName");
            }
            else if (value.Length < 4)
            {
                throw new ArgumentException($"Expected length at least 4 symbols! " +
                    $"Argument: firstName");
            }
        }

        private void ValidateLastName(string value)
        {
            if (!char.IsUpper(value[0]))
            {
                throw new
                    ArgumentException($"Expected upper case letter! Argument: lastName");
            }
            else if (value.Length < 3)
            {
                throw new
                    ArgumentException($"Expected length at least 3 symbols! " +
                    $"Argument: lastName");
            }
        }
    }
}
