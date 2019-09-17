namespace AnimalFarm
{
    using System;
    using AnimalFarm.Models;
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Chicken chicken = GetNewChicken(name, age);

            if (chicken == null)
            {
                return;
            }

            Console.WriteLine(
                "Chicken {0} (age {1}) can produce {2} eggs per day.",
                chicken.Name,
                chicken.Age,
                chicken.ProductPerDay);
        }

        private static Chicken GetNewChicken(string name, int age)
        {
            try
            {
                return new Chicken(name, age);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }
    }
}
