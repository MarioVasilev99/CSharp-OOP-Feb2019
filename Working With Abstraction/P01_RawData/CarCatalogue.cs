namespace P01_RawData
{
    using System.Collections.Generic;
    using System.Linq;

    public class CarCatalogue
    {
        private List<Car> data;

        public CarCatalogue()
        {
            this.data = new List<Car>();
        }

        public void Add(Car carToAdd)
        {
            this.data.Add(carToAdd);
        }

        public List<Car> GetFragileVehicles()
        {
            var fragileVehicles = this.data
                .Where(c => c.Cargo.Type == "fragile")
                .Where(c => c.HasFragileTire())
                .ToList();

            return fragileVehicles;
        }

        public List<Car> GetFlamableVehicles()
        {
            var flamableEngines = this.data
                .Where(c => c.Cargo.Type == "flamable")
                .Where(c => c.Engine.Power > 250)
                .ToList();

            return flamableEngines;
        }
    }
}
