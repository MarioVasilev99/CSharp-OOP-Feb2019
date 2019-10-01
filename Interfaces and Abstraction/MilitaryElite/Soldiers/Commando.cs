namespace MilitaryElite.Soldiers
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MilitaryElite.ISoldiers;

    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, string corps, List<Mission> missions)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = missions;
        }

        public List<Mission> Missions { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
            result.AppendLine($"Corps: {this.Corps}");

            if (this.Missions.Count > 0)
            {
                result.AppendLine("Missions:");
                result.Append($"  {string.Join(Environment.NewLine + "  ", this.Missions)}");
            }
            else
            {
                result.Append("Missions:");
            }

            return result.ToString().TrimEnd();
        }
    }
}
