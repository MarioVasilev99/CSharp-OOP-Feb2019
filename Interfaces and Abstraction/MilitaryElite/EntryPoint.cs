namespace MilitaryElite
{
    using MilitaryElite.Soldiers;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EntryPoint
    {
        public static void Main()
        {
            List<Soldier> soldiers = new List<Soldier>();

            string userInput = Console.ReadLine();

            while (userInput != "End")
            {
                string[] soldierInfo = userInput.Split(" ");

                string soldierType = soldierInfo[0];
                int id = int.Parse(soldierInfo[1]);
                string firstName = soldierInfo[2];
                string lastName = soldierInfo[3];
                decimal salary;
                bool isSalary = decimal.TryParse(soldierInfo[4], out salary);

                Soldier newSoldier;

                switch (soldierType)
                {
                    case "Private":
                        newSoldier = new Private(id, firstName, lastName, salary);
                        soldiers.Add(newSoldier);
                        break;

                    case "LieutenantGeneral":
                        int[] privatesToAddIds = soldierInfo.Skip(5).Select(int.Parse).ToArray();
                        List<Private> privates = GetPrivates(privatesToAddIds, soldiers);

                        newSoldier = new LieutenantGeneral(id, firstName, lastName, salary, privates);
                        soldiers.Add(newSoldier);

                        break;

                    case "Spy":
                        int codeNumber = int.Parse(soldierInfo[4]);
                        Spy newSpy = new Spy(id, firstName, lastName, codeNumber);
                        soldiers.Add(newSpy);

                        break;

                    case "Engineer":
                        string corps = soldierInfo[5];
                        List<Repair> repairs = GetRepairs(soldierInfo);

                        try
                        {
                            Engineer newEngineer = new Engineer(id, firstName, lastName, salary, corps, repairs);
                            soldiers.Add(newEngineer);
                        }
                        catch
                        {
                            userInput = Console.ReadLine();
                            continue;
                        }
                        
                        break;

                    case "Commando":
                        string commandoCorps = soldierInfo[5];
                        List<Mission> missions = GetMissions(soldierInfo);

                        Commando newCommando = new Commando(id, firstName, lastName, salary, commandoCorps, missions);
                        soldiers.Add(newCommando);

                        break;
                }

                userInput = Console.ReadLine();
            }

            Console.WriteLine($"{string.Join(Environment.NewLine, soldiers)}");
        }

        private static List<Mission> GetMissions(string[] soldierInfo)
        {
            string[] missionsInfo = soldierInfo.Skip(6).ToArray();

            List<Mission> missions = new List<Mission>();

            for (int i = 0; i < missionsInfo.Length; i += 2)
            {
                string codeName = missionsInfo[i];
                string state = missionsInfo[i + 1];

                try
                {
                    Mission newMission = new Mission(codeName, state);
                    missions.Add(newMission);
                }
                catch (Exception)
                {
                }
            }

            return missions;
        }

        private static List<Repair> GetRepairs(string[] soldierInfo)
        {
            string[] repairsInfo = soldierInfo.Skip(6).ToArray();
            List<Repair> repairs = new List<Repair>();

            for (int i = 0; i < repairsInfo.Length; i += 2)
            {
                string repairPart = repairsInfo[i];
                int repairHours = int.Parse(repairsInfo[i + 1]);

                Repair newRepair = new Repair(repairPart, repairHours);
                repairs.Add(newRepair);
            }

            return repairs;
        }

        private static List<Private> GetPrivates(int[] privatesToAddIds, List<Soldier> soldiers)
        {
            var privates = new List<Private>();

            foreach (var id in privatesToAddIds)
            {
                Soldier newPrivate = soldiers.FirstOrDefault(s => s.Id == id);

                if (newPrivate != null)
                {
                    privates.Add((Private)newPrivate);
                }
            }

            return privates;
        }
    }
}
