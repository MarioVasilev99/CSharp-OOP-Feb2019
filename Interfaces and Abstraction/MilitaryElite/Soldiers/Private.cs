namespace MilitaryElite.Soldiers
{
    using MilitaryElite.ISoldiers;
    using System.Text;

    public class Private : Soldier, IPrivate
    {
        public Private(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
