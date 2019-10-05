namespace Vehicles.Vehicles
{
    public static class VehicleFactory
    {
        public static Vehicle Create(string[] vehicleData)
        {
            string vehicleType = vehicleData[0];
            double fuelQuantity = double.Parse(vehicleData[1]);
            double fuelConsumption = double.Parse(vehicleData[2]);
            double tankCapacity = double.Parse(vehicleData[3]);

            if (vehicleType == "Car")
            {
                return new Car(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if(vehicleType == "Truck")
            {
                return new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else
            {
                return new Bus(fuelQuantity, fuelConsumption, tankCapacity);
            }
        }
    }
}
