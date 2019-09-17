namespace PizzaCalories
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] pizzaData = Console
                .ReadLine()
                .Split(" ");

            string pizzaName = pizzaData[1];

            string[] doughData = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string doughType = doughData[1];
            string doughTechnique = doughData[2];
            int doughWeight = int.Parse(doughData[3]);

            Pizza pizza;

            try
            {
                pizza = new Pizza(pizzaName, doughType, doughTechnique, doughWeight);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            string userInput = Console.ReadLine();

            while (userInput != "END")
            {
                string[] topingData = userInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string topingName = topingData[1];
                int topingWeight = int.Parse(topingData[2]);

                try
                {
                    Toping newToping = new Toping(topingName, topingWeight);
                    pizza.AddToping(newToping);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }

                userInput = Console.ReadLine();
            }

            Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:F2} Calories.");
        }
    }
}
