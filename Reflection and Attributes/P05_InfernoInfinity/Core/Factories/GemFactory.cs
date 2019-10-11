
namespace InfernoInfinity.Core.Factories
{
    using InfernoInfinity.Models.Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public static class GemFactory
    {
        public static IGem CreateGem(string gemTypeString, string gemClarity)
        {
            var gemType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == gemTypeString);

            var gemInstance = (IGem)Activator.CreateInstance(gemType, new object[] { gemClarity });

            return gemInstance;
        }
    }
}
