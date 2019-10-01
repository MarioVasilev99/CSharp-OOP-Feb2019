namespace Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private decimal weekSalary;
        private int hoursPerDay;

        public Worker(string firstName, string lastName, decimal salary, int hours)
            : base(firstName, lastName)
        {
            this.WeekSalary = salary;
            this.HoursPerDay = hours;
        }

        public decimal WeekSalary
        {
            get => this.weekSalary;
            private set
            {
                this.ValidateWeekSalary(value);
                this.weekSalary = value;
            }
        }

        public int HoursPerDay
        {
            get => this.hoursPerDay;
            private set
            {
                this.ValidateHoursPerDay(value);
                this.hoursPerDay = value;
            }
        }

        public decimal SalaryPerHour
        {
            get => this.CalculateSalaryPerHour();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"First Name: {this.FirstName}");
            result.AppendLine($"Last Name: {this.LastName}");
            result.AppendLine($"Week Salary: {this.WeekSalary:f2}");
            result.AppendLine($"Hours per day: {this.HoursPerDay:f2}");
            result.AppendLine($"Salary per hour: {this.SalaryPerHour:f2}");

            return result.ToString();
        }

        private decimal CalculateSalaryPerHour()
        {
            decimal salaryPerHour = this.WeekSalary / (this.HoursPerDay * 5);

            return salaryPerHour;
        }

        private void ValidateWeekSalary(decimal value)
        {
            if (value <= 10)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
            }
        }

        private void ValidateHoursPerDay(int value)
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
        }
    }
}
