using _03BarracksFactory.Contracts;
using System;

namespace P03_BarraksWars.Core.UserCommands
{
    public class RetireCommand : BaseCommand
    {
        public RetireCommand(IRepository repository, IUnitFactory unitFactory, string[] data)
            : base(repository, unitFactory, data)
        {
        }

        public override string Execute()
        {
            string unitToRemove = Data[1];

            string message = string.Empty;

            try
            {
                message = this.Repository.RemoveUnit(unitToRemove);
            }
            catch (InvalidOperationException ex)
            {
                message = ex.Message;
            }

            return message;
        }
    }
}
