namespace InfernoInfinity.Models.Weapons
{
    public class Knife : BaseWeapon
    {
        private const int MaxDamageConst = 4;
        private const int MinDamageConst = 3;
        private const int GemSocketsConst = 2;

        public Knife(string name, string rarity)
            : base(name, rarity, MaxDamageConst, MinDamageConst, GemSocketsConst)
        {
        }
    }
}
