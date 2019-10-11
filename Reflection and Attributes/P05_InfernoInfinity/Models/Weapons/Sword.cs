namespace InfernoInfinity.Models.Weapons
{
    public class Sword : BaseWeapon
    {
        private const int MaxDamageConst = 6;
        private const int MinDamageConst = 4;
        private const int GemSocketsConst = 3;

        public Sword(string name, string rarity)
            : base(name, rarity, MaxDamageConst, MinDamageConst, GemSocketsConst)
        {
        }
    }
}
