namespace Vehicles.Vehicles
{
    using Exceptions;

    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double consumption, double tankCapacity)
            : base(fuelQuantity, consumption, tankCapacity)
        {
            this.IncreaseFuelConsumption(1.6);
        }

        public override void Refuel(double fuelAmount)
        {
            this.ValidateRefuelAmount(fuelAmount);
            if (this.CanBeRefueled(fuelAmount))
            {
                fuelAmount -= fuelAmount * 5 / 100;
                base.Refuel(fuelAmount);
            }
            else
            {
                string exceptionMessage = $"Cannot fit {fuelAmount} fuel in the tank";
                throw new InvalidRefuelAmountException(exceptionMessage);
            }
        }

        private bool CanBeRefueled(double fuelAmount)
        {
            double emptyFuelSpace = this.TankCapacity - this.FuelQuantity;
            if (emptyFuelSpace >= fuelAmount)
            {
                return true;
            }

            return false;
        }
    }
}
