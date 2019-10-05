namespace Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Vehicles;

    public class EntryPoint
    {
        public static void Main()
        {
            string[] carInfo = Console.ReadLine().Split(" ");
            var car = VehicleFactory.Create(carInfo);

            string[] truckInfo = Console.ReadLine().Split(" ");
            var truck = VehicleFactory.Create(truckInfo);

            string[] busInfo = Console.ReadLine().Split(" ");
            var bus = VehicleFactory.Create(busInfo);

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] userCommandProps = Console.ReadLine().Split(" ");

                string command = userCommandProps[0];
                string vehicleType = userCommandProps[1];

                try
                {
                    if (vehicleType == "Car")
                    {
                        if (command == "Refuel")
                        {
                            double fuel = double.Parse(userCommandProps[2]);
                            car.Refuel(fuel);
                        }
                        else if (command == "Drive")
                        {
                            double distance = double.Parse(userCommandProps[2]);
                            Console.WriteLine(car.Drive(distance));
                        }
                    }
                    else if (vehicleType == "Truck")
                    {
                        if (command == "Refuel")
                        {
                            double fuel = double.Parse(userCommandProps[2]);
                            truck.Refuel(fuel);
                        }
                        else if (command == "Drive")
                        {
                            double distance = double.Parse(userCommandProps[2]);
                            Console.WriteLine(truck.Drive(distance));
                        }
                    }
                    else if (vehicleType == "Bus")
                    {
                        if (command == "Refuel")
                        {
                            double fuel = double.Parse(userCommandProps[2]);
                            bus.Refuel(fuel);
                        }
                        else if (command == "Drive")
                        {
                            double distance = double.Parse(userCommandProps[2]);
                            Console.WriteLine(bus.Drive(distance));
                        }
                        else if (command == "DriveEmpty")
                        {
                            double distance = double.Parse(userCommandProps[2]);
                            Console.WriteLine(bus.DriveEmpty(distance));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
    }
}
