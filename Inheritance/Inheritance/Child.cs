using System;

namespace Inheritance
{
    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {
        }

        public override int Age
        {
            get => base.Age;

            set
            {
                this.ValidateChildAge(value);
                base.Age = value;
            }
        }

        private void ValidateChildAge(int value)
        {
            if (value > 15)
            {
                throw new ArgumentException("Child's age must be less than 15!");
            }
        }
    }
}
