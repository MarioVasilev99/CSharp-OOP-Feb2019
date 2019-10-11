namespace InfernoInfinity.Models
{
    using InfernoInfinity.Models.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class WeaponRepository : IRepository
    {
        private List<IWeapon> weapons;

        public WeaponRepository()
        {
            this.weapons = new List<IWeapon>();
        }

        public void AddWeapon(IWeapon weapon)
        {
            this.weapons.Add(weapon);
        }

        public IWeapon GetWeapon(string weaponName)
        {
            IWeapon weaponToReturn = this
                .weapons
                .FirstOrDefault(w => w.Name == weaponName);

            return weaponToReturn;
        }

        public List<IWeapon> GetAllWeapons()
        {
            return this.weapons;
        }
    }
}
