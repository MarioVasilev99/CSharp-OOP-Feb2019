namespace _03BarracksFactory.Core.Factories
{
    using System;
    using System.Reflection;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitTypeName)
        {
            var unitType = Type.GetType("_03BarracksFactory.Models.Units." + unitTypeName);

            var unitInstance = (IUnit)Activator.CreateInstance(unitType);

            return unitInstance;
        }
    }
}
