using System;

namespace MortalEngines.Entities.Machines
{
    public class Fighter : BaseMachine
    {
        private const double InitialHealthConst = 200;

        public Fighter(string name, double attackPoints, double defensePoints) : base(name, attackPoints, defensePoints, InitialHealthConst)
        {
            this.AggressiveMode = false;
            this.ToggleAggressiveMode();
        }

        public bool AggressiveMode { get; private set; } // ???? SET? GET?

        public void ToggleAggressiveMode()
        {
            if (this.AggressiveMode)
            {
                this.AggressiveMode = false;
                this.AttackPoints -= 50;
                this.DefensePoints += 25;
            }
            else
            {
                this.AggressiveMode = true;
                this.AttackPoints += 50;
                this.DefensePoints -= 25;
            }
        }

        public override string ToString()
        {
            string aggresiveModeMessage = string.Empty;

            if (this.AggressiveMode)
            {
                aggresiveModeMessage = " *Aggressive: ON";
            }
            else
            {
                aggresiveModeMessage = " *Aggressive: OFF";
            }

            string resultString = base.ToString() + Environment.NewLine + aggresiveModeMessage;

            return resultString;
        }
    }
}
