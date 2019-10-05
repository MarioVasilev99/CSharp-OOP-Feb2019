using WildFarm.Animals;
using WildFarm.Animals.Birds;
using WildFarm.Animals.Felines;
using WildFarm.Animals.Mammals;

namespace WildFarm
{
    public static class AnimalFactory
    {
        public static BaseAnimal Create(string[] animalProps)
        {
            string type = animalProps[0];
            string name = animalProps[1];
            double weight = double.Parse(animalProps[2]);

            if (animalProps.Length == 5)
            {
                string livingRegion = animalProps[3];
                string breed = animalProps[4];

                if (type == "Cat")
                {
                    return new Cat(name, weight, livingRegion, breed);
                }
                else
                {
                    return new Tiger(name, weight, livingRegion, breed);
                }
            }
            else if (type == "Owl" || type == "Hen")
            {
                double windSize = double.Parse(animalProps[3]);

                if (type == "Owl")
                {
                    return new Owl(name, weight, windSize);
                }
                else
                {
                    return new Hen(name, weight, windSize);
                }
            }
            else if (type == "Mouse" || type == "Dog")
            {
                string livingRegion = animalProps[3];

                if (type == "Mouse")
                {
                    return new Mouse(name, weight, livingRegion);
                }
                else if(type == "Dog")
                {
                    return new Dog(name, weight, livingRegion);
                }
            }

            return null;
        }
    }
}
