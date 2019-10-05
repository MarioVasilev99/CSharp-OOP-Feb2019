namespace Vehicles.Vehicles
{
    using Contracts;

    public class Bus : Vehicle, IVehicle
    {
        public Bus(double fuelQuantity, double consumption, double tankCapacity)
            : base(fuelQuantity, consumption, tankCapacity)
        {
        }

        public override string Drive(double distance)
        {
            double tempConsump = this.FuelConsumption;
            this.IncreaseFuelConsumption(1.4);
            string completedDriveMessage = base.Drive(distance);
            this.FuelConsumption = tempConsump;

            return completedDriveMessage;
        }

        public override string DriveEmpty(double distance)
        {
            return base.Drive(distance);
        }
    }
}
