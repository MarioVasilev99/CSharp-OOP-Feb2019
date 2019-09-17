namespace P01_RawData
{
    using System;
    using System.Collections.Generic;
   
    public class Startup
    {
        public static void Main()
        {
            var carCatalogue = new CarCatalogue();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] carParameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var carCreator = new CarCreator(carParameters);
                var newCar = carCreator.Create();

                carCatalogue.Add(newCar);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                var fragileVehicles = carCatalogue.GetFragileVehicles();

                PrintVehicles(fragileVehicles);
            }
            else
            {
                var flamableVehicles = carCatalogue.GetFlamableVehicles();

                PrintVehicles(flamableVehicles);
            }
        }

        private static void PrintVehicles(List<Car> fragileVehicles)
        {
            foreach (var car in fragileVehicles)
            {
                Console.WriteLine($"{car.Model}");
            }
        }
    }
}
