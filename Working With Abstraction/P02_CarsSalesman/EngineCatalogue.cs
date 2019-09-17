namespace P02_CarsSalesman
{
    using System.Collections.Generic;

    public class EngineCatalogue
    {
        private List<Engine> engines;

        public EngineCatalogue()
        {
            this.engines = new List<Engine>();
        }

        public void Add(Engine newEngine)
        {
            this.engines.Add(newEngine);
        }

        public IReadOnlyList<Engine> GetAllEngines()
        {
            return this.engines.AsReadOnly();
        }

    }
}
