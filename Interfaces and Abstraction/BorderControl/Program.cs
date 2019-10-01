namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var people = new List<IBuyer>();

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split(" ");

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                if (personInfo.Length == 4)
                {
                    string id = personInfo[2];
                    string birthDate = personInfo[3];

                    var newCitizen = new Citizen(name, age, id, birthDate);
                    people.Add(newCitizen);
                }
                else if (personInfo.Length == 3)
                {
                    string group = personInfo[2];

                    var newRebel = new Rebel(name, age, group);
                    people.Add(newRebel);
                }
            }

            string personBuyingFoodName = Console.ReadLine();

            while (personBuyingFoodName != "End")
            {
                var buyer = FindBuyer(personBuyingFoodName, people);

                if (buyer != null)
                {
                    buyer.BuyFood();
                }

                personBuyingFoodName = Console.ReadLine();
            }

            int totalFoodBought = CalculateTotalFoodBought(people);
            Console.WriteLine(totalFoodBought);
        }

        private static int CalculateTotalFoodBought(List<IBuyer> people)
        {
            int totalFoodBought = people.Sum(p => p.Food);

            return totalFoodBought;
        }

        private static IBuyer FindBuyer(string personBuyingFoodName, List<IBuyer> people)
        {
            var buyer = people.FirstOrDefault(p => p.Name == personBuyingFoodName);

            return buyer;
        }
    }
}
