namespace InfernoInfinity.Core.Contracts
{
    public interface ICommandInterpreter
    {
        void InterpredCommand(string commandName, string[] data);
    }
}
