namespace Animals
{
    using System;
    using System.Linq;

    public static class Validator
    {
        private static string[] animalTypes;

        static Validator()
        {
            animalTypes = new string[]
                {
                    "Dog",
                    "Cat",
                    "Frog",
                    "Kitten",
                    "Tomcat"
                };
        }

        public static void AnimalInfo(string[] animalInfo)
        {
            if (animalInfo.Length != 3)
            {
                ThrowException();
            }
        }

        public static void String(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                ThrowException();
            }
        }

        public static void Integer(int value)
        {
            if (value < 0)
            {
                ThrowException();
            }
        }

        public static void AnimalType(string value)
        {
            if (!animalTypes.Contains(value))
            {
                ThrowException();
            }
        }

        private static void ThrowException()
        {
            throw new ArgumentException("Invalid input!");
        }
    }
}
