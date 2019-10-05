namespace WildFarm.Animals.Felines
{
    using Mammals;

    public abstract class BaseFeline : BaseMammal
    {
        public BaseFeline(string name, double weight, string region, string breed)
            : base(name, weight, region)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }

        public override string ToString()
        {
            string animalType = this.GetType().Name;

            string stringToReturn =
                $"{animalType} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";

            return stringToReturn;
        }
    }
}
