namespace MortalEngines.Core
{
    using MortalEngines.Core.Contracts;
    using System;
    using System.Linq;

    public class Engine : IEngine
    {
        private IMachinesManager machinesManager;

        public Engine()
        {
            this.machinesManager = new MachinesManager();
        }

        public void Run()
        {
            string userInput = Console.ReadLine();

            while (userInput != "Quit")
            {
                string[] splittedInput = userInput
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string commandName = splittedInput[0];
                string[] commandArgs = splittedInput.Skip(1).ToArray();

                string result = InterpredCommand(commandName, commandArgs);
                Console.WriteLine(result);


                //try
                //{
                //    string[] splittedInput = userInput
                //        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //    string commandName = splittedInput[0];
                //    string[] commandArgs = splittedInput.Skip(1).ToArray();

                //    string result = InterpredCommand(commandName, commandArgs);
                //    Console.WriteLine(result);
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Error:" + ex.Message);
                //}

                userInput = Console.ReadLine();
            }
        }

        private string InterpredCommand(string commandName, string[] commandArgs)
        {
            string name = commandArgs[0];

            string result = string.Empty;

            switch (commandName)
            {
                case "HirePilot":
                    result = this.machinesManager.HirePilot(name);
                    break;

                case "PilotReport":
                    result = this.machinesManager.PilotReport(name);
                    break;

                case "ManufactureTank":
                    double attackPoints = double.Parse(commandArgs[1]);
                    double defensePoints = double.Parse(commandArgs[2]);
                    result = this.machinesManager.ManufactureTank(name, attackPoints, defensePoints);
                    break;

                case "ManufactureFighter":
                    double fighterAttackPoints = double.Parse(commandArgs[1]);
                    double fighterDefensePoints = double.Parse(commandArgs[2]);
                    result = this.machinesManager.ManufactureFighter(name, fighterAttackPoints, fighterDefensePoints);
                    break;

                case "MachineReport":
                    result = this.machinesManager.MachineReport(name);
                    break;

                case "AggressiveMode":
                    result = this.machinesManager.ToggleFighterAggressiveMode(name);
                    break;

                case "DefenseMode":
                    result = this.machinesManager.ToggleTankDefenseMode(name);
                    break;

                case "Engage":
                    string selectedMachineName = commandArgs[1];
                    result = this.machinesManager.EngageMachine(name, selectedMachineName);
                    break;

                case "Attack":
                    string defendingMachineName = commandArgs[1];
                    result = this.machinesManager.AttackMachines(name, defendingMachineName);
                    break;
            }

            return result;
        }
    }
}
