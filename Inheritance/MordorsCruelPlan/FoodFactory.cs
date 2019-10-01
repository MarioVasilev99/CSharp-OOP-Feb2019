namespace MordorsCruelPlan
{
    using System.Collections.Generic;
    using System.Linq;

    public class FoodFactory
    {
        private string[] foodsEaten;
        private Dictionary<string, int> gandalfFoods;

        public FoodFactory(string[] foods)
        {
            this.gandalfFoods = new Dictionary<string, int>();
            this.InitialiseFoods();
            this.foodsEaten = foods.Select(f => f.ToLower()).ToArray();
        }

        public int GetFoodHappiness()
        {
            int totalFoodHappiness = 0;

            foreach (var food in this.foodsEaten)
            {
                if (this.gandalfFoods.ContainsKey(food))
                {
                    totalFoodHappiness += this.gandalfFoods[food];
                }
                else
                {
                    totalFoodHappiness -= 1;
                }
            }

            return totalFoodHappiness;
        }

        private void InitialiseFoods()
        {
            this.gandalfFoods.Add("cram", 2);
            this.gandalfFoods.Add("lembas", 3);
            this.gandalfFoods.Add("apple", 1);
            this.gandalfFoods.Add("melon", 1);
            this.gandalfFoods.Add("honeycake", 5);
            this.gandalfFoods.Add("mushrooms", -10);
        }
    }
}
