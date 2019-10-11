namespace InfernoInfinity.Models.Weapons
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using InfernoInfinity.Models.Contracts;

    public abstract class BaseWeapon : IWeapon
    {
        public BaseWeapon(string name, string rarity, int maxDamage, int minDamage, int socketsCount)
        {
            this.Name = name;
            this.Rarity = rarity;
            this.MaxDamage = maxDamage;
            this.MinDamage = minDamage;
            this.ApplyRarityDamageMultiplier();
            this.SocketsCount = socketsCount;
            this.gems = new IGem[this.SocketsCount];
        }

        public string Name { get; set; }

        public string Rarity { get; set; }

        protected int MinDamage { get; set; }

        protected int MaxDamage { get; set; }

        protected int Strenght { get; set; }

        protected int Agility { get; set; }

        protected int Vitality { get; set; }

        protected int SocketsCount { get; set; }

        protected IGem[] gems;

        public void AddGem(IGem gem, int socketIndex)
        {
            bool isIndexValid = this.ValidateSocketIndex(socketIndex);
            bool isSockedEmpty = this.CheckIfSocketIsEmpty(socketIndex);

            if (isIndexValid)
            {
                if (!isSockedEmpty)
                {
                    var gemToRemove = this.gems[socketIndex];
                    this.RemoveGemBonusStats(gemToRemove);
                }

                this.gems[socketIndex] = gem;
                this.ApplyGemBonusStats(gem);
            }
        }

        public void RemoveGem(int socketIndex)
        {
            bool isIndexValid = this.ValidateSocketIndex(socketIndex);
            bool isSocketEmpty = this.CheckIfSocketIsEmpty(socketIndex);

            if (isIndexValid && isSocketEmpty == false)
            {
                IGem gemToRemove = this.gems[socketIndex];

                this.RemoveGemBonusStats(gemToRemove);
                this.gems[socketIndex] = null;
            }
        }

        public override string ToString()
        {
            string resultString =
                $"{this.Name}: {this.MinDamage}-{this.MaxDamage} Damage, " +
                $"+{this.Strenght} Strength, +{this.Agility} Agility, +{this.Vitality} Vitality";

            return resultString;
        }

        private void ApplyGemBonusStats(IGem gem)
        {
            this.Strenght += gem.StrenghtBonus;
            this.Agility += gem.AgilityBonus;
            this.Vitality += gem.VitalityBonus;

            int minDamageBonus = this.CalculateGemMinDamageBonus(gem);
            int maxDamageBonus = this.CalculateGemMaxDamageBonus(gem);

            this.MinDamage += minDamageBonus;
            this.MaxDamage += maxDamageBonus;
        }

        private void RemoveGemBonusStats(IGem gem)
        {
            this.Strenght -= gem.StrenghtBonus;
            this.Agility -= gem.AgilityBonus;
            this.Vitality -= gem.VitalityBonus;

            int minDamageBonus = this.CalculateGemMinDamageBonus(gem);
            int maxDamageBonus = this.CalculateGemMaxDamageBonus(gem);

            this.MinDamage -= minDamageBonus;
            this.MaxDamage -= maxDamageBonus;
        }

        private int CalculateGemMinDamageBonus(IGem gem)
        {
            int minDamageBonus = gem.StrenghtBonus * 2 + gem.AgilityBonus;

            return minDamageBonus;
        }

        private int CalculateGemMaxDamageBonus(IGem gem)
        {
            int maxDamageBonus = gem.StrenghtBonus * 3 + gem.AgilityBonus * 4;

            return maxDamageBonus;
        }

        private bool CheckIfSocketIsEmpty(int socketIndex)
        {
            if (this.gems.ElementAtOrDefault(socketIndex) == null)
            {
                return true;
            }

            return false;
        }

        private bool ValidateSocketIndex(int socketIndex)
        {
            if (socketIndex > this.SocketsCount - 1 
                || socketIndex < 0)
            {
                return false;
            }

            return true;
        }

        private void ApplyRarityDamageMultiplier()
        {
            switch (this.Rarity.ToLower())
            {
                case "uncommon ":
                    this.IncreaseDamage(2);
                    break;

                case "rare":
                    this.IncreaseDamage(3);
                    break;

                case "epic":
                    this.IncreaseDamage(5);
                    break;
            }
        }

        private void IncreaseDamage(int multiplier)
        {
            this.MaxDamage *= multiplier;
            this.MinDamage *= multiplier;
        }
    }
}
