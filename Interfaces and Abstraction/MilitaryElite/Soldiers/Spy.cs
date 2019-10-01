using MilitaryElite.ISoldiers;
using System.Text;

namespace MilitaryElite.Soldiers
{
    public class Spy : Soldier, ISoldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}");
            result.Append($"Code Number: {this.CodeNumber}");

            return result.ToString().TrimEnd();
        }
    }
}
