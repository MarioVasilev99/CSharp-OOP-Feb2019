namespace Vehicles.Vehicles.Exceptions
{
    using System;

    public class NotEnoughFuelException : Exception
    {
        public NotEnoughFuelException(string message)
            : base(message)
        {
        }
    }
}
