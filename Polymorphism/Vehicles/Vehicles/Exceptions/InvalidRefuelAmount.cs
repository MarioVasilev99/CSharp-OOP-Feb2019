namespace Vehicles.Vehicles.Exceptions
{
    using System;

    public class InvalidRefuelAmountException : Exception
    {
        public InvalidRefuelAmountException(string message)
            : base(message)
        {
        }
    }
}
