namespace InfernoInfinity.Core.Factories
{
    using InfernoInfinity.Models.Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public static class WeaponFactory
    {
        public static IWeapon CreateWeapon(string weaponToCreate, string weaponRarity, string weaponName)
        {
            var weaponType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == weaponToCreate);

            var weapon = (IWeapon)Activator
                .CreateInstance(weaponType, new object[] { weaponName, weaponRarity});

            return weapon;
        }
    }
}
