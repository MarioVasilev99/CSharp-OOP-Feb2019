namespace Animals
{
    using System;
    using System.Text;

    public abstract class Animal : ISoundProducable
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get => this.name;
            protected set
            {
                Validator.String(value);
                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;
            protected set
            {
                Validator.Integer(value);
                this.age = value;
            }
        }

        public string Gender
        {
            get => this.gender;
            protected set
            {
                Validator.String(value);
                this.gender = value;
            }
        }

        public abstract string ProduceSound();
        

        public override string ToString()
        {
            StringBuilder stringbuilder = new StringBuilder();

            stringbuilder.AppendLine($"{this.GetType().Name}");
            stringbuilder.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            stringbuilder.Append(this.ProduceSound());

            return stringbuilder.ToString();
        }
    }
}
