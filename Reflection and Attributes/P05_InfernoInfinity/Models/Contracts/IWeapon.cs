namespace InfernoInfinity.Models.Contracts
{
    public interface IWeapon
    {
        string Name { get; }

        string Rarity { get; }

        void AddGem(IGem gem, int socketIndex);

        void RemoveGem(int socketIndex);
    }
}
