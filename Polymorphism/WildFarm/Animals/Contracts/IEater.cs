using System.Collections.Generic;

namespace WildFarm.Animals.Contracts
{
    public interface IEater
    {
        List<string> FoodsThatCanBeEaten { get; }
    }
}
