namespace WildFarm
{
    using System;
    using System.Collections.Generic;
    using WildFarm.Animals;
    using WildFarm.Foods;

    public class Program
    {
        public static void Main()
        {
            string userInput = Console.ReadLine();

            var animals = new List<BaseAnimal>();

            while (userInput != "End")
            {
                string[] animalInfo = userInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var newAnimal = AnimalFactory.Create(animalInfo);
                animals.Add(newAnimal);
                
                string[] foodInfo = Console.ReadLine().Split(" ");
                var food = FoodFactory.Create(foodInfo);

                Console.WriteLine(newAnimal.ProduceSound());

                try
                {
                    newAnimal.Eat(food, food.Quantity);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                userInput = Console.ReadLine();
            }

            Console.WriteLine($"{string.Join(Environment.NewLine, animals)}");
        }
    }
}
