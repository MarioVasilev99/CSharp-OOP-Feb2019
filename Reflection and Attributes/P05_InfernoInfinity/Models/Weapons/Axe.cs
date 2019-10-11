namespace InfernoInfinity.Models.Weapons
{
    public class Axe : BaseWeapon
    {
        private const int MaxDamageConst = 10;
        private const int MinDamageConst = 5;
        private const int GemSocketsConst = 4;

        public Axe(string name, string rarity)
            : base(name, rarity, MaxDamageConst, MinDamageConst, GemSocketsConst)
        {
        }
    }
}
