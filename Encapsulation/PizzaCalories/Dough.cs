namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;

    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int weight;
        private Dictionary<string, double> flourModifiers;
        private Dictionary<string, double> bakingTechniqueModifiers;

        public Dough(string flourType, string technique, int weight)
        {
            this.flourModifiers = new Dictionary<string, double>();
            this.SeedFlourModifiers();

            this.bakingTechniqueModifiers = new Dictionary<string, double>();
            this.SeedBakingModifiers();

            this.FlourType = flourType;
            this.BakingTechnique = technique;
            this.Weight = weight;
        }

        private string FlourType
        {
            set
            {
                this.ValidateFlourType(value);
                this.flourType = value;
            }
        }

        private string BakingTechnique
        {
            set
            {
                this.ValidateBakingTechnique(value);
                this.bakingTechnique = value;
            }
        }

        private int Weight
        {
            set
            {
                this.ValidateWeight(value);
                this.weight = value;
            }
        }

        public double CaloriesPerGram
        {
            get => this.CalculateCaloriesPerGram();
        }

        private double CalculateCaloriesPerGram()
        {
            double caloriesPerGram =
                2 * this.weight *
                this.flourModifiers[this.flourType.ToLower()] *
                this.bakingTechniqueModifiers[this.bakingTechnique.ToLower()];

            return caloriesPerGram;
        }

        private void SeedFlourModifiers()
        {
            this.flourModifiers.Add("white", 1.5);
            this.flourModifiers.Add("wholegrain", 1.0);
        }

        private void SeedBakingModifiers()
        {
            this.bakingTechniqueModifiers.Add("crispy", 0.9);
            this.bakingTechniqueModifiers.Add("chewy", 1.1);
            this.bakingTechniqueModifiers.Add("homemade", 1.0);
        }

        private void ValidateFlourType(string value)
        {
            if (!this.flourModifiers.ContainsKey(value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
        }

        private void ValidateBakingTechnique(string value)
        {
            if (!this.bakingTechniqueModifiers.ContainsKey(value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
        }

        private void ValidateWeight(int value)
        {
            if (value > 200 || value < 1)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
        }
    }
}
