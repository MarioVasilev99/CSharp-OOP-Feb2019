using System.Text;

namespace MilitaryElite.Soldiers
{
    public class Repair
    {
        public Repair(string partName, int hours)
        {
            this.PartName = partName;
            this.HoursWorked = hours;
        }

        public string PartName { get; set; }

        public int HoursWorked { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append($"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}");

            return result.ToString().TrimEnd();
        }
    }
}
