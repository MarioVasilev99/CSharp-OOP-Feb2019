namespace InfernoInfinity
{
    using InfernoInfinity.Core;
    using InfernoInfinity.Models;

    public class EntryPoint
    {
        public static void Main()
        {
            WeaponRepository repository = new WeaponRepository();
            Engine engine = new Engine(repository);

            engine.Run();
        }
    }
}
