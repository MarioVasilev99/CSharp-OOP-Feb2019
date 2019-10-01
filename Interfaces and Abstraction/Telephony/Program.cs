namespace Telephony
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] numbersToCall = Console.ReadLine().Split(" ");
            string[] sitesToBrowse = Console.ReadLine().Split(" ");

            var smartPhone = new Smartphone(numbersToCall, sitesToBrowse);

            Console.WriteLine(smartPhone.Call());
            Console.WriteLine(smartPhone.Browse());
        }
    }
}
