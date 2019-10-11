namespace InfernoInfinity.Models.Gems
{
    using InfernoInfinity.Models.Contracts;

    public abstract class BaseGem : IGem
    {
        public BaseGem(int strengthBonus, int agilityBonus, int vitalityBonus, string clarity)
        {
            this.StrenghtBonus = strengthBonus;
            this.VitalityBonus = vitalityBonus;
            this.AgilityBonus = agilityBonus;
            this.ApplyGemClarityBonus(clarity);
        }

        public int StrenghtBonus { get; private set; }

        public int AgilityBonus { get; private set; }

        public int VitalityBonus { get; private set; }

        private void ApplyGemClarityBonus(string clarity)
        {
            switch (clarity.ToLower())
            {
                case "chipped":
                    this.IncreaseStats(1);
                    break;

                case "regular":
                    this.IncreaseStats(2);
                    break;

                case "perfect":
                    this.IncreaseStats(5);
                    break;

                case "flawless":
                    this.IncreaseStats(10);
                    break;
            }
        }

        private void IncreaseStats(int increasement)
        {
            this.StrenghtBonus += increasement;
            this.AgilityBonus += increasement;
            this.VitalityBonus += increasement;
        }
    }
}
