namespace MortalEngines.Core
{
    using Contracts;
    using MortalEngines.Entities;
    using MortalEngines.Entities.Contracts;
    using MortalEngines.Entities.Machines;
    using System.Collections.Generic;
    using System.Linq;

    public class MachinesManager : IMachinesManager
    {
        private List<IPilot> pilots;
        private List<IMachine> machines;

        public MachinesManager()
        {
            this.pilots = new List<IPilot>();
            this.machines = new List<IMachine>();
        }

        public string HirePilot(string name)
        {
            var pilotNeeded = this.pilots.FirstOrDefault(p => p.Name == name);

            if (pilotNeeded != null)
            {
                return $"Pilot {name} is hired already";
            }

            var newPilot = new Pilot(name);
            this.pilots.Add(newPilot);

            return $"Pilot {name} hired";
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            var tankSearched = this.machines.FirstOrDefault(m => m.Name == name) as Tank;

            if (tankSearched != null)
            {
                return $"Machine {name} is manufactured already";
            }

            var newTank = new Tank(name, attackPoints, defensePoints);
            this.machines.Add(newTank);

            return $"Tank {newTank.Name} manufactured - attack: {newTank.AttackPoints:f2}; defense: {newTank.DefensePoints:f2}";
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            var fighterSearched = this.machines.FirstOrDefault(m => m.Name == name) as Fighter;

            if (fighterSearched != null)
            {
                return $"Machine {name} is manufactured already";
            }

            var newFighter = new Fighter(name, attackPoints, defensePoints);
            this.machines.Add(newFighter);

            return $"Fighter {newFighter.Name} manufactured - attack: {newFighter.AttackPoints:f2}; defense: {newFighter.DefensePoints:f2}; aggressive: ON";
        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            var pilotSearched = this.pilots.FirstOrDefault(p => p.Name == selectedPilotName);

            if (pilotSearched == null)
            {
                return $"Pilot {selectedPilotName} could not be found";
            }

            var machineSearched = this.machines.FirstOrDefault(m => m.Name == selectedMachineName);

            if (machineSearched == null)
            {
                return $"Machine {selectedMachineName} could not be found";
            }

            if (machineSearched.Pilot != null)
            {
                return $"Machine {selectedMachineName} is already occupied";
            }

            pilotSearched.AddMachine(machineSearched);
            machineSearched.Pilot = pilotSearched;

            return $"Pilot {selectedPilotName} engaged machine {selectedMachineName}";
        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            var attackingMachine = this.machines.FirstOrDefault(m => m.Name == attackingMachineName);

            var defendingMachine = this.machines.FirstOrDefault(m => m.Name == defendingMachineName);

            if (attackingMachine == null)
            {
                return $"Machine {attackingMachineName} could not be found";
            }
            else if (defendingMachine == null)
            {
                return $"Machine {defendingMachineName} could not be found";
            }

            if (attackingMachine.HealthPoints == 0)
            {
                return $"Dead machine {attackingMachineName} cannot attack or be attacked";
            }
            else if (defendingMachine.HealthPoints == 0)
            {
                return $"Dead machine {defendingMachineName} cannot attack or be attacked";
            }

            attackingMachine.Attack(defendingMachine);

            return $"Machine {defendingMachineName} was attacked by machine {attackingMachineName} - current health: {defendingMachine.HealthPoints:f2}";
        }

        public string PilotReport(string pilotReporting)
        {
            var pilot = this.pilots.FirstOrDefault(p => p.Name == pilotReporting);

            return pilot.Report();
        }

        public string MachineReport(string machineName)
        {
            var machine = this.machines.FirstOrDefault(m => m.Name == machineName);

            return machine.ToString();
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            var fighterSearched = this.machines.FirstOrDefault(m => m.Name == fighterName) as Fighter;

            if (fighterSearched != null)
            {
                fighterSearched.ToggleAggressiveMode();
                return $"Fighter {fighterName} toggled aggressive mode";
            }

            return $"Machine {fighterName} could not be found";
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            var tankSearched = this.machines.FirstOrDefault(m => m.Name == tankName) as Tank;

            if (tankSearched != null)
            {
                tankSearched.ToggleDefenseMode();
                return $"Tank {tankName} toggled defense mode";
            }

            return $"Machine {tankName} could not be found";
        }
    }
}