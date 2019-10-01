namespace MilitaryElite.Soldiers
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MilitaryElite.ISoldiers;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, List<Private> privates)
            : base(id, firstName, lastName, salary)
        {
            this.Privates = privates;
        }

        public List<Private> Privates { get;}
       
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
            result.AppendLine($"Privates:");
            result.Append($"  {string.Join(Environment.NewLine + "  ", this.Privates)}");

            return result.ToString().TrimEnd();
        }
    }
}
