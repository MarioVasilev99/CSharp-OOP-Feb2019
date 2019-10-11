namespace InfernoInfinity.Models.Gems
{
    public class Emerald : BaseGem
    {
        private const int DefaultStrengthBonus = 1;
        private const int DefaultAgilityBonus = 4;
        private const int DefaultVitalityBonus = 9;

        public Emerald(string clarity)
            : base(DefaultStrengthBonus, DefaultAgilityBonus, DefaultVitalityBonus, clarity)
        {
        }
    }
}
