using System.Collections.Generic;

namespace WildFarm.Animals.Felines
{
    public class Cat : BaseFeline
    {
        public Cat(string name, double weight,string region, string breed)
            : base(name, weight, region, breed)
        {
            this.FoodsAbleToEat = new List<string>
            {
                "Vegetable", "Meat"
            };

            this.WeightGainMultiplier = 0.30;
        }

        protected override List<string> FoodsAbleToEat { get; set; }

        protected override double WeightGainMultiplier { get; set; }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
