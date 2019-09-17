namespace P02_CarsSalesman
{
    public class EngineFactory
    {
        private string[] engineData;

        public EngineFactory(string[] engineProps)
        {
            this.engineData = engineProps;
        }

        public Engine Create()
        {
            string model = this.engineData[0];
            int power = int.Parse(this.engineData[1]);
            int displacement = -1;

            Engine newEngine;

            if (this.engineData.Length == 3 && int.TryParse(this.engineData[2], out displacement))
            {
                newEngine = new Engine(model, power, displacement);
            }
            else if (this.engineData.Length == 3)
            {
                string efficiency = this.engineData[2];
                newEngine = new Engine(model, power, efficiency);
            }
            else if (this.engineData.Length == 4)
            {
                string efficiency = this.engineData[3];
                newEngine = new Engine(model, power, int.Parse(this.engineData[2]), efficiency);
            }
            else
            {
                newEngine = new Engine(model, power);
            }

            return newEngine;
        }
    }
}
