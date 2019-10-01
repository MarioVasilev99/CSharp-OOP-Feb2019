namespace MordorsCruelPlan
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] gandalfFood = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var foodFactory = new FoodFactory(gandalfFood);
            int foodHappinessPoints = foodFactory.GetFoodHappiness();

            var moodFactory = new MoodFactory(foodHappinessPoints);
            string gandalfMood = moodFactory.GetMood();

            Console.WriteLine(foodHappinessPoints);
            Console.WriteLine(gandalfMood);
        }
    }
}
