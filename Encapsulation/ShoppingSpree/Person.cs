namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        private string name;
        private decimal money;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<Product>(); 
        }

        public List<Product> Products { get; private set; }

        public string Name
        {
            get => this.name;
            set
            {
                this.ValidateName(value);

                this.name = value;
            }
        }

        public decimal Money
        {
            get => this.money;
            set
            {
                this.ValidateMoney(value);

                this.money = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (this.Products.Count == 0)
            {
                result.Append($"{this.Name} - Nothing bought");
            }
            else
            {
                result.Append($"{this.Name} - {string.Join(", ", this.Products)}");
            }

            return result.ToString();
        }

        private void ValidateName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
        }

        private void ValidateMoney(decimal price)
        {
            if (price < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
        }
    }
}
