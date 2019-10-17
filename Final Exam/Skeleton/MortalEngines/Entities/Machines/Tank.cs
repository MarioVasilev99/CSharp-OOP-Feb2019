using System;

namespace MortalEngines.Entities.Machines
{
    public class Tank : BaseMachine
    {
        private const int InitialHealthPointsConst = 100;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints, InitialHealthPointsConst)
        {
            this.DefenseMode = false;
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.DefenseMode = false;
                this.AttackPoints += 40;
                this.DefensePoints -= 30;
            }
            else
            {
                this.DefenseMode = true;
                this.AttackPoints -= 40;
                this.DefensePoints += 30;
            }
        }

        public override string ToString()
        {
            string defenseModeMessage = string.Empty;

            if (this.DefenseMode)
            {
                defenseModeMessage = " *Defense: ON";
            }
            else
            {
                defenseModeMessage = " *Defense: OFF";
            }

            string resultString = base.ToString() + Environment.NewLine + defenseModeMessage;

            return resultString;
        }
    }
}
