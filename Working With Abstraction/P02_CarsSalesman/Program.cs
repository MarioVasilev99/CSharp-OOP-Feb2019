namespace P02_CarsSalesman
{
    using System;
    
    public class CarSalesman
    {
        public static void Main()
        {
            var carCatalogue = new CarCatalogue();
            var engineCatalogue = new EngineCatalogue();

            int engineCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < engineCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var engineFactory = new EngineFactory(parameters);
                var newEngine = engineFactory.Create();

                engineCatalogue.Add(newEngine);
            }

            int carCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var carFactory = new CarFactory(parameters, engineCatalogue);
                var newCar = carFactory.Create();

                carCatalogue.Add(newCar);
            }

            foreach (var car in carCatalogue.GetAllCars())
            {
                Console.WriteLine(car);
            }
        }
    }
}
