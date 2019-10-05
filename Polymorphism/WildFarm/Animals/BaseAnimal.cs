namespace WildFarm.Animals
{
    using Foods;
    using System;
    using System.Collections.Generic;

    public abstract class BaseAnimal
    {
        public BaseAnimal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; set; }

        public double Weight { get; set; }

        public int FoodEaten { get; set; }

        protected abstract List<string> FoodsAbleToEat { get; set; }

        protected abstract double WeightGainMultiplier { get; set; }

        public void Eat(Food food, int timesToEat)
        {
            string foodType = food.GetType().Name;

            this.ValidateFood(foodType);

            this.Weight += this.WeightGainMultiplier * timesToEat;
            this.FoodEaten += timesToEat;
        }

        public abstract string ProduceSound();

        protected void ValidateFood(string food)
        {
            if (!this.FoodsAbleToEat.Contains(food))
            {
                string animalType = this.GetType().Name;

                throw new ArgumentException($"{animalType} does not eat {food}!");
            }
        }
    }
}
