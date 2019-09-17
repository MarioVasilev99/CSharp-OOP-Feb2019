namespace P01_RawData
{
    using System.Collections.Generic;
    using System.Linq;

    public class Car
    {
        public Car(
            string model,
            int engineSpeed,
            int enginePower,
            int cargoWeight,
            string cargoType,
            string[] tireProperties)
        {
            this.Model = model;

            var engineCreator = new EngineCreator(engineSpeed, enginePower);
            this.Engine = engineCreator.Create();

            var cargoCreator = new CargoCreator(cargoWeight, cargoType);
            this.Cargo = cargoCreator.Create();
            this.Tires = this.SetTires(tireProperties);
        }

        public string Model { get; private set; }

        public Engine Engine { get; private set; }

        public Cargo Cargo { get; private set; }

        public List<Tire> Tires { get; private set; }

        public bool HasFragileTire()
        {
            var fragileTires = this.Tires.Where(t => t.Pressure < 1).ToArray();

            if (fragileTires.Length > 0)
            {
                return true;
            }

            return false;
        }

        private List<Tire> SetTires(string[] tireData)
        {
            var tiresList = new List<Tire>();

            for (int i = 0; i < tireData.Length; i += 2)
            {
                double tirePressure = double.Parse(tireData[i]);
                int tireAge = int.Parse(tireData[i + 1]);

                var newTire = new Tire(tirePressure, tireAge);
                tiresList.Add(newTire);
            }

            return tiresList;
        }
    }
}
