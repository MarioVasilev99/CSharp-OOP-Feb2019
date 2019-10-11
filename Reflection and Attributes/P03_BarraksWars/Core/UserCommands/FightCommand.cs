using _03BarracksFactory.Contracts;
using System;

namespace P03_BarraksWars.Core.UserCommands
{
    public class FightCommand : BaseCommand
    {
        public FightCommand(IRepository repository, IUnitFactory unitFactory, string[] data)
            : base(repository, unitFactory, data)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);

            return string.Empty;
        }
    }
}
