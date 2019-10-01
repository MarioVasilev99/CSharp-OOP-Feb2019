namespace Animals
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string animalType = Console.ReadLine();
            var animals = new List<Animal>();

            while (animalType != "Beast!")
            {
                string[] animalInfo = Console.ReadLine().Split(" ");

                try
                {
                    var animal = AnimalFactory.Create(animalType, animalInfo);
                    animals.Add(animal);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                animalType = Console.ReadLine();
            }

            Console.WriteLine($"{string.Join(Environment.NewLine, animals)}");
        }
    }
}
