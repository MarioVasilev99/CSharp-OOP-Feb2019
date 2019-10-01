namespace Ferrari
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string driverName = Console.ReadLine();
            var ferrari = new Ferrari(driverName);

            Console.WriteLine($"{ferrari.Model}/{ferrari.UseBrakes()}/{ferrari.PushTheGas()}/{ferrari.Driver}");
        }
    }
}
