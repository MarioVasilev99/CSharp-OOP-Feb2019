namespace Animals
{
    public static class AnimalFactory
    {
        public static Animal Create(string animalType, string[] animalInfo)
        {
            Validator.AnimalType(animalType);
            Validator.AnimalInfo(animalInfo);

            string name = animalInfo[0];
            int age = int.Parse(animalInfo[1]);
            string gender = animalInfo[2];

            switch (animalType)
            {
                case "Dog":
                    var newDog = new Dog(name, age, gender);
                    return newDog;

                case "Cat":
                    var newCat = new Cat(name, age, gender);
                    return newCat;

                case "Frog":
                    var newFrog = new Frog(name, age, gender);
                    return newFrog;

                case "Kitten":
                    var kitten = new Kitten(name, age, gender);
                    return kitten;

                case "Tomcat":
                    var tomcat = new Tomcat(name, age, gender);
                    return tomcat;
            }

            return null;
        }
    }
}
