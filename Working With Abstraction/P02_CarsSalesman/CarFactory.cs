using System;
using System.Linq;

namespace P02_CarsSalesman
{
    public class CarFactory
    {
        private string[] carData;
        private EngineCatalogue engines;

        public CarFactory(string[] carProperties, EngineCatalogue enginesCatalogue)
        {
            this.carData = carProperties;
            this.engines = enginesCatalogue;
        }

        public Car Create()
        {
            string model = this.carData[0];
            string engineModel = this.carData[1];
            var engine = GetEngineFromCatalogue(this.engines, engineModel);
            int weight = -1;

            Car newCar;

            if (this.carData.Length == 3 && int.TryParse(this.carData[2], out weight))
            {
                newCar = new Car(model, engine, weight);
            }
            else if (this.carData.Length == 3)
            {
                string color = this.carData[2];
                newCar = new Car(model, engine, color);
            }
            else if (this.carData.Length == 4)
            {
                string color = this.carData[3];
                newCar = new Car(model, engine, int.Parse(this.carData[2]), color);
            }
            else
            {
                newCar = new Car(model, engine);
            }

            return newCar;
        }

        private Engine GetEngineFromCatalogue(EngineCatalogue engines, string modelSearched)
        {
            var enginesList = engines.GetAllEngines();

            var engineSearched = enginesList.FirstOrDefault(e => e.Model == modelSearched);

            return engineSearched;
        }
    }
}
