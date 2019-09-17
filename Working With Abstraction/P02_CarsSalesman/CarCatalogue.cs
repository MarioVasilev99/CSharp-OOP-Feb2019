using System.Collections.Generic;

namespace P02_CarsSalesman
{
    public class CarCatalogue
    {
        private List<Car> cars;

        public CarCatalogue()
        {
            this.cars = new List<Car>();
        }

        public void Add(Car carToAdd)
        {
            this.cars.Add(carToAdd);
        }

        public IReadOnlyList<Car> GetAllCars()
        {
            return this.cars.AsReadOnly();
        }
    }
}
