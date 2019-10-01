namespace Inheritance
{
    using System;
    using System.Text;

    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                this.ValidateName(value);
                this.name = value;
            }
        }

        public virtual int Age
        {
            get => this.age;
            set
            {
                this.ValidateAge(value);
                this.age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append($"Name: {this.Name}, Age: {this.Age}");

            return result.ToString();
        }

        private void ValidateName(string value)
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Name's length should not be less than 3 symbols!");
            }
        }

        private void ValidateAge(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Age must be positive!");
            }
        }
    }
}
