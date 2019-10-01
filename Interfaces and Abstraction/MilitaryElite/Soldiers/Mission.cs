namespace MilitaryElite.Soldiers
{
    using System;
    using System.Linq;
    using System.Text;

    public class Mission
    {
        private string[] validMissionStates = new string[]
        {
            "inProgress",
            "Finished"
        };

        private string state;

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; set; }

        public string State
        {
            get => this.state;
            private set
            {
                this.ValidateMissionState(value);
                this.state = value;
            }
        }

        public void CompleteMission()
        {
            this.state = "Finished";
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append($"Code Name: {this.CodeName} State: {this.State}");

            return result.ToString();
        }

        private void ValidateMissionState(string value)
        {
            if (!this.validMissionStates.Contains(value))
            {
                throw new ArgumentException();
            }
        }
    }
}
