namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();

            string[] peopleArguments = Console
                .ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var personArgs in peopleArguments)
            {
                string[] personInfo = personArgs.Split("=", StringSplitOptions.RemoveEmptyEntries);

                string personName = personInfo[0];
                decimal personMoney = decimal.Parse(personInfo[1]);

                try
                {
                    Person newPerson = new Person(personName, personMoney);
                    people.Add(newPerson);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            List<Product> products = new List<Product>();

            string[] productsArguments = Console
                .ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var productArgs in productsArguments)
            {
                string[] currentProductInfo = productArgs
                    .Split("=", StringSplitOptions.RemoveEmptyEntries);

                string productName = currentProductInfo[0];
                decimal productPrice = decimal.Parse(currentProductInfo[1]);

                try
                {
                    Product newProduct = new Product(productName, productPrice);
                    products.Add(newProduct);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            string userInput = Console.ReadLine();

            while (userInput != "END")
            {
                string[] userCommandArguments = userInput
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string buyerName = userCommandArguments[0];
                string productName = userCommandArguments[1];

                Person buyer = people.FirstOrDefault(b => b.Name == buyerName);
                Product product = products.FirstOrDefault(p => p.Name == productName);

                if (buyer.Money > product.Price)
                {
                    buyer.Money -= product.Price;
                    buyer.Products.Add(product);

                    Console.WriteLine($"{buyer.Name} bought {product.Name}");
                }
                else
                {
                    Console.WriteLine($"{buyer.Name} can't afford {product.Name}");
                }

                userInput = Console.ReadLine();
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
