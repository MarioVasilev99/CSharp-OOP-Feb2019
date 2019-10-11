namespace InfernoInfinity.Models.Gems
{
    public class Ruby : BaseGem
    {
        private const int DefaultStrengthBonus = 7;
        private const int DefaultAgilityBonus = 2;
        private const int DefaultVitalityBonus = 5;

        public Ruby(string clarity)
            : base(DefaultStrengthBonus, DefaultAgilityBonus, DefaultVitalityBonus, clarity)
        {
        }
    }
}
