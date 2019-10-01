namespace BookShop
{
    using System;
    using System.Linq;
    using System.Text;

    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public Book(string authorName, string title, decimal price)
        {
            this.Author = authorName;
            this.Title = title;
            this.Price = price;
        }

        public string Title
        {
            get => this.title;
            private set
            {
                this.ValidateTitle(value);
                this.title = value;
            }
        }

        public string Author
        {
            get => this.author;

            private set
            {
                this.ValidateAuthor(value);
                this.author = value;
            }
        }

        public virtual decimal Price
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

            result.AppendLine($"Type: {GetType().Name}");
            result.AppendLine($"Title: {this.Title}");
            result.AppendLine($"Author: {this.Author.ToString()}");
            result.Append($"Price: {this.Price:f2}");

            return result.ToString();
        }

        private void ValidateTitle(string value)
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
        }

        private void ValidatePrice(decimal value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
        }

        private void ValidateAuthor(string value)
        {
            if (value.Any(c => char.IsDigit(c)))
            {
                throw new ArgumentException("Author not valid!");
            }
        }
    }
}
