namespace Ferrari
{
    using System;

    public class Ferrari : IFerrari
    {
        private string gasMessage;
        private string brakeMessage;

        public Ferrari(string driverName)
        {
            this.Model = "488-Spider";
            this.gasMessage = "Zadu6avam sA!";
            this.brakeMessage = "Brakes!";
            this.Driver = driverName;
        }

        public string Model { get; set; }

        public string Driver { get; set; }

        public string PushTheGas()
        {
            return this.gasMessage;
        }

        public string UseBrakes()
        {
            return this.brakeMessage;
        }
    }
}
