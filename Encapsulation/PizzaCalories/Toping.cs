using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Toping
    {
        private string type;
        private int weight;
        private Dictionary<string, double> typeModifiers;

        public Toping(string topingType, int topingWeight)
        {
            this.typeModifiers = new Dictionary<string, double>();
            this.InitialiseModifiers();
            this.Type = topingType;
            this.Weight = topingWeight;
        }

        public string Type
        {
            get => this.type;
            private set
            {
                this.ValidateType(value);
                this.type = value;
            }
        }

        public int Weight
        {
            get => this.weight;
            private set
            {
                this.ValidateWeight(value);
                this.weight = value;
            }
        }

        public double CaloriesPerGram
        {
            get => this.CalculateCalories();
        }

        private double CalculateCalories()
        {
            double calories = this.weight * 2 * this.typeModifiers[this.type.ToLower()];

            return calories;
        }

        private void ValidateWeight(int value)
        {
            if (value < 1 || value > 50)
            {
                throw new
                    ArgumentException($"{this.Type} weight should be in the range [1..50].");
            }
        }

        private void ValidateType(string value)
        {
            if (!this.typeModifiers.ContainsKey(value.ToLower()))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
        }

        private void InitialiseModifiers()
        {
            this.typeModifiers.Add("meat", 1.2);
            this.typeModifiers.Add("veggies", 0.8);
            this.typeModifiers.Add("cheese", 1.1);
            this.typeModifiers.Add("sauce", 0.9);
        }
    }
}
