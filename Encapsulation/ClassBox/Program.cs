namespace ClassBox
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double boxLenght = double.Parse(Console.ReadLine());
            double boxWidth = double.Parse(Console.ReadLine());
            double boxHeight = double.Parse(Console.ReadLine());

            var box = CreateBox(boxLenght, boxWidth, boxHeight);

            if (box == null)
            {
                return;
            }

            Console.WriteLine(box.ToString());
        }

        public static Box CreateBox(double boxLenght, double boxWidth, double boxHeight)
        {
            try
            {
                return new Box(boxLenght, boxWidth, boxHeight);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
