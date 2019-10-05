namespace WildFarm.Animals.Birds
{
    public abstract class BaseBird : BaseAnimal
    {
        public BaseBird(string name, double weight, double wingSize)
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get; set; }

        public override string ToString()
        {
            string animalType = this.GetType().Name;

            string stringToReturn = 
                $"{animalType} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";

            return stringToReturn;
        }
    }
}
