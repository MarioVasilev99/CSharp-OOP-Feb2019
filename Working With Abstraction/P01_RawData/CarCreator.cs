using System.Linq;

namespace P01_RawData
{
    public class CarCreator
    {
        private string[] carProperties;

        public CarCreator(string[] carProps)
        {
            this.carProperties = carProps;
        }

        public Car Create()
        {
            string model = this.carProperties[0];
            int engineSpeed = int.Parse(this.carProperties[1]);
            int enginePower = int.Parse(this.carProperties[2]);
            int cargoWeight = int.Parse(this.carProperties[3]);
            string cargoType = this.carProperties[4];
            string[] tireProperties = carProperties.Skip(5).ToArray();

            Car newCar = new Car(
                model,
                engineSpeed,
                enginePower,
                cargoWeight,
                cargoType,
                tireProperties);

            return newCar;
        }
    }
}
