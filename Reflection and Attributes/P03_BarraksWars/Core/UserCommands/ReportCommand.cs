namespace P03_BarraksWars.Core.UserCommands
{
    using _03BarracksFactory.Contracts;

    public class ReportCommand : BaseCommand
    {
        public ReportCommand(IRepository repository, IUnitFactory unitFactory, string[] data)
            : base(repository, unitFactory, data)
        {
        }

        public override string Execute()
        {
            string output = this.Repository.Statistics;

            return output;
        }
    }
}
