namespace Ferrari
{
    interface IFerrari
    {
        string Model { get; set; }

        string Driver { get; set; }

        string UseBrakes();
        string PushTheGas();
    }
}
