namespace ShoppingSpree
{
    using System;
    using System.Text;

    public class Product
    {
        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
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

        public decimal Price
        {
            get => this.price;
            private set
            {
                this.ValidatePrice(value);
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(this.Name);

            return result.ToString();
        }

        private void ValidateName(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
        }

        private void ValidatePrice(decimal price)
        {
            if (price < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
        }
    }
}
