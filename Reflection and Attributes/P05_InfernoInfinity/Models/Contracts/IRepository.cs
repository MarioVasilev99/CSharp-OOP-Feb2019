namespace InfernoInfinity.Models.Contracts
{
    using System.Collections.Generic;

    public interface IRepository
    {
        void AddWeapon(IWeapon weapon);

        IWeapon GetWeapon(string weaponName);

        List<IWeapon> GetAllWeapons();
    }
}
