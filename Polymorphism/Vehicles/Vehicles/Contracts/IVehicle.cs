namespace Vehicles.Vehicles.Contracts
{
    public interface IVehicle
    {
        double FuelQuantity { get; }

        double FuelConsumption { get; }

        string Drive(double distance);

        double TankCapacity { get;}

        void Refuel(double fuelAmount);
    }
}
