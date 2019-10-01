namespace MilitaryElite.Soldiers
{
    using System;
    using System.Linq;

    public abstract class SpecialisedSoldier : Private
    {
        private string[] validCorps = new string[]
        {
            "Airforces", "Marines"
        };

        private string corps;

        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get => this.corps;
            set
            {
                this.ValidateCorps(value);
                this.corps = value;
            }
        }

        private void ValidateCorps(string value)
        {
            if (!validCorps.Contains(value))
            {
                throw new ArgumentException();
            }
        }
    }
}
