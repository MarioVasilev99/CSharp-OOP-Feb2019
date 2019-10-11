namespace InfernoInfinity.Models.Gems
{
    public class Amethyst : BaseGem
    {
        private const int DefaultStrengthBonus = 2;
        private const int DefaultAgilityBonus = 8;
        private const int DefaultVitalityBonus = 4;

        public Amethyst(string clarity)
            : base(DefaultStrengthBonus, DefaultAgilityBonus, DefaultVitalityBonus, clarity)
        {
        }
    }
}
