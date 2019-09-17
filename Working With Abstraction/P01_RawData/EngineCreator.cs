namespace P01_RawData
{
    public class EngineCreator
    {
        private int engineSpeed;
        private int enginePower;

        public EngineCreator(int speed, int power)
        {
            this.engineSpeed = speed;
            this.enginePower = power;
        }

        public Engine Create()
        {
            var newEngine = new Engine(this.engineSpeed, this.enginePower);

            return newEngine;
        }
    }
}
