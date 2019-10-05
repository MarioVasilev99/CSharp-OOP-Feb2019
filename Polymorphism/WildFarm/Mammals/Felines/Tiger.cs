using System.Collections.Generic;

namespace WildFarm.Animals.Felines
{
    public class Tiger : BaseFeline
    {
        public Tiger(string name, double weight, string region, string breed)
            : base(name, weight, region, breed)
        {
            this.FoodsAbleToEat = new List<string>
            {
                "Meat"
            };

            this.WeightGainMultiplier = 1.00;
        }

        protected override List<string> FoodsAbleToEat { get; set; }

        protected override double WeightGainMultiplier { get; set; }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
