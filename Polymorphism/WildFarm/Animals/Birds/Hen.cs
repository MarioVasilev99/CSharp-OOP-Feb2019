using System.Collections.Generic;

namespace WildFarm.Animals.Birds
{
    public class Hen : BaseBird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
            this.FoodsAbleToEat = new List<string>
            {
                "Fruit", "Meat", "Seeds", "Vegetable"
            };

            this.WeightGainMultiplier = 0.35;
        }

        protected override List<string> FoodsAbleToEat { get; set; }

        protected override double WeightGainMultiplier { get; set; }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
