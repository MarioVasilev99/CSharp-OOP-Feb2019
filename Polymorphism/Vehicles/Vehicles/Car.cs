namespace Vehicles.Vehicles
{
    using Contracts;

    public class Car : Vehicle, IVehicle
    {
        public Car(double fuelQuantity, double consumption, double tankCapacity)
            : base(fuelQuantity, consumption, tankCapacity)
        {
            this.IncreaseFuelConsumption(0.9);
        }
    }
}
