using System.Collections.Generic;

namespace WildFarm.Animals.Birds
{
    public class Owl : BaseBird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
            this.FoodsAbleToEat = new List<string>
            {
                "Meat"
            };

            this.WeightGainMultiplier = 0.25;
        }

        protected override List<string> FoodsAbleToEat { get; set; }

        protected override double WeightGainMultiplier { get; set; }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
