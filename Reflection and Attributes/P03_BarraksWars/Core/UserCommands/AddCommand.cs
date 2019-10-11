using _03BarracksFactory.Contracts;

namespace P03_BarraksWars.Core.UserCommands
{
    public class AddCommand : BaseCommand
    {
        public AddCommand(IRepository repository, IUnitFactory unitFactory, string[] data)
            : base(repository, unitFactory, data)
        {
        }

        public override string Execute()
        {
            string unitType = Data[1];

            IUnit unitToAdd = this.UnitFactory.CreateUnit(unitType);
            this.Repository.AddUnit(unitToAdd);

            string output = unitType + " added!";
            return output;
        }
    }
}
