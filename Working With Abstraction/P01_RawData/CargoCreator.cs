namespace P01_RawData
{
    public class CargoCreator
    {
        private int cargoWeight;
        private string cargoType;

        public CargoCreator(int weight, string type)
        {
            this.cargoWeight = weight;
            this.cargoType = type;
        }

        public Cargo Create()
        {
            var newCargo = new Cargo(this.cargoWeight, this.cargoType);

            return newCargo;
        }
    }
}
