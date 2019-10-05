namespace WildFarm.Animals.Mammals
{
    using System;
    using System.Collections.Generic;
    using WildFarm.Foods;

    public class Dog : BaseMammal
    {
        private string foodToEat = "Meat";

        public Dog(string name, double weight, string region)
            : base(name, weight, region)
        {
            this.FoodsAbleToEat = new List<string>
            {
                "Meat"
            };

            this.WeightGainMultiplier = 0.40;
        }

        protected override List<string> FoodsAbleToEat { get; set; }

        protected override double WeightGainMultiplier { get; set; }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
