using System.Collections.Generic;

namespace WildFarm.Animals.Mammals
{
    public class Mouse : BaseMammal
    {
        public Mouse(string name, double weight, string region)
            : base(name, weight, region)
        {
            this.FoodsAbleToEat = new List<string>
            {
                "Vegetable", "Fruit"
            };

            this.WeightGainMultiplier = 0.10;
        }

        protected override List<string> FoodsAbleToEat { get; set; }

        protected override double WeightGainMultiplier { get; set; }

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
