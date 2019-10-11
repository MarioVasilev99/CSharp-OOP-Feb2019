namespace P03_BarraksWars.Core.UserCommands
{
    using _03BarracksFactory.Contracts;

    public abstract class BaseCommand : IExecutable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;
        private string[] data;

        protected BaseCommand(IRepository repository, IUnitFactory unitFactory, string[] data)
        {
            this.Repository = repository;
            this.UnitFactory = unitFactory;
            this.Data = data;
        }

        protected IRepository Repository { get; set; }

        protected IUnitFactory UnitFactory { get; set; }

        public string[] Data { get; set; }

        public abstract string Execute();
    }
}
