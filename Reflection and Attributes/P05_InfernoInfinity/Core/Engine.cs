namespace InfernoInfinity.Core
{
    using InfernoInfinity.Core.Contracts;
    using InfernoInfinity.Core.Factories;
    using InfernoInfinity.Models.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private IRepository repository;

        public Engine(IRepository repository)
        {
            this.repository = repository;
        }

        public void Run()
        {
            while (true)
            {
                string userInput = Console.ReadLine();
                string[] data = userInput.Split(";");
                string commandName = data[0];


                if (commandName == "Create")
                {
                    string[] weaponInfo = data[1].Split(" ");
                    string weaponRarity = weaponInfo[0];
                    string weaponType = weaponInfo[1];
                    string weaponName = data[2];

                    var weapon = WeaponFactory.CreateWeapon(weaponType, weaponRarity, weaponName);

                    this.repository.AddWeapon(weapon);
                }
                else if (commandName == "Add")
                {
                    string weaponName = data[1];
                    IWeapon weapon = this.repository.GetWeapon(weaponName);

                    int gemSocketIndex = int.Parse(data[2]);

                    string[] gemInfo = data[3].Split(" ");
                    string gemClarity = gemInfo[0];
                    string gemType = gemInfo[1];

                    var gem = GemFactory.CreateGem(gemType, gemClarity);

                    weapon.AddGem(gem, gemSocketIndex);
                }
                else if (commandName == "Remove")
                {
                    string weaponName = data[1];
                    IWeapon weapon = this.repository.GetWeapon(weaponName);

                    int socketToRemoveIndex = int.Parse(data[2]);

                    weapon.RemoveGem(socketToRemoveIndex);
                }
                else if (commandName == "Print")
                {
                    string weaponName = data[1];

                    var weapon = this.repository.GetWeapon(weaponName);

                    Console.WriteLine(weapon.ToString());
                }
                else if (commandName == "END")
                {
                    break;
                }
            }
        }
    }
}
