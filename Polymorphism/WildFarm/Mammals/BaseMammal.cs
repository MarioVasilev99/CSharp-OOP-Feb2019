namespace WildFarm.Animals.Mammals
{
    using WildFarm.Animals;

    public abstract class BaseMammal : BaseAnimal
    {
        public BaseMammal(string name, double weight, string region)
            : base(name, weight)
        {
            this.LivingRegion = region;
        }

        public string LivingRegion { get; set; }

        public override string ToString()
        {
            string animalType = this.GetType().Name;

            string stringToReturn = $"{animalType} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";

            return stringToReturn;
        }
    }
}
