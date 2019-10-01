using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.ISoldiers;

namespace MilitaryElite.Soldiers
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, string corps, List<Repair> repairs)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = repairs;
        }

        public List<Repair> Repairs { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
            result.AppendLine($"Corps: {this.Corps}");

            if (this.Repairs.Count > 0)
            {
                result.AppendLine($"Repairs:");
                result.Append($"  {string.Join(Environment.NewLine + "  ", this.Repairs)}");
            }
            else
            {
                result.Append($"Repairs:");
            }

            return result.ToString().TrimEnd();
        }
    }
}
