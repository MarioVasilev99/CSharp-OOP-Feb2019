using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Toping> topings;
        private Dough dough;

        public Pizza(
            string name,
            string doughType,
            string doughTechnique,
            int doughWeight)
        {
            this.Name = name;
            this.topings = new List<Toping>();
            this.dough = new Dough(doughType, doughTechnique, doughWeight);
        }

        public string Name
        {
            get => this.name;
            private set
            {
                this.ValidateName(value);
                this.name = value;
            }
        }

        public int ToppingsCount
        {
            get => this.topings.Count;
        }

        public double TotalCalories
        {
            get => this.CalculateCalories();
        }

        public void AddToping(Toping newToping)
        {
            if (this.ToppingsCount >= 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            else
            {
                this.topings.Add(newToping);
            }
        }

        private double CalculateCalories()
        {
            double totalCalories = 0;

            totalCalories += this.dough.CaloriesPerGram;

            foreach (var topping in this.topings)
            {
                totalCalories += topping.CaloriesPerGram;
            }

            return totalCalories;
        }

        private void ValidateName(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
            {
                throw new ArgumentException($"Pizza name should be between 1 and 15 symbols.");
            }
        }
    }
}
