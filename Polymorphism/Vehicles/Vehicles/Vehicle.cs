namespace Vehicles.Vehicles
{
    using System;
    using Contracts;
    using Exceptions;

    public class Vehicle : IVehicle
    {
        private string type;
        private double fuelQuantity;

        public Vehicle(double fuelQuantity, double consumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = consumption;
            this.type = this.GetType().Name;
        }

        public double FuelQuantity
        {
            get => this.fuelQuantity;
            protected set
            {
                this.ValidateRefuelAmount(value);

                if (value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public double FuelConsumption { get; protected set; }

        public double TankCapacity { get; }

        public virtual string Drive(double distance)
        {
            double fuelRequiredToDrive = distance * this.FuelConsumption;
            
            if (this.FuelQuantity < fuelRequiredToDrive)
            {
                throw new NotEnoughFuelException($"{this.type} needs refueling");
            }
            else
            {
                this.FuelQuantity -= fuelRequiredToDrive;
                return $"{this.GetType().Name} travelled {distance} km";
            }
        }

        public virtual string DriveEmpty(double distance)
        {
            return this.Drive(distance);
        }

        public virtual void Refuel(double fuelAmount)
        {
            this.ValidateRefuelAmount(fuelAmount);
            this.AddFuel(fuelAmount);
        }
        
        public override string ToString()
        {
            return $"{type}: {this.FuelQuantity:F2}";
        }

        protected void IncreaseFuelConsumption(double increaseAmount)
        {
            this.FuelConsumption += increaseAmount;
        }

        protected void ValidateRefuelAmount(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
        }

        protected void AddFuel(double fuelAmount)
        {
            double freeTankSpace = this.TankCapacity - this.FuelQuantity;

            if (fuelAmount <= freeTankSpace)
            {
                this.fuelQuantity += fuelAmount;
            }
            else
            {
                string exceptionMessage = $"Cannot fit {fuelAmount} fuel in the tank";
                throw new InvalidRefuelAmountException(exceptionMessage);
            }
        }
    }
}
