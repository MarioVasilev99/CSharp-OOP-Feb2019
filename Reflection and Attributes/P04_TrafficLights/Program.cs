namespace TrafficLights
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var trafficLights = new List<int>();

            var trafficLightsInfo = Console.ReadLine().Split(" ");
            foreach (var trafficLightInfo in trafficLightsInfo)
            {
                var newTrafficLight = (TrafficLight)Enum.Parse(typeof(TrafficLight), trafficLightInfo);
                trafficLights.Add((int)newTrafficLight);
            }

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < trafficLights.Count; j++)
                {
                    if (trafficLights[j] + 1 > 2)
                    {
                        trafficLights[j] = 0;
                    }
                    else
                    {
                        trafficLights[j]++;
                    }

                    if (j == trafficLights.Count - 1)
                    {
                        Console.Write((TrafficLight)trafficLights[j]);
                    }
                    else
                    {
                        Console.Write((TrafficLight)trafficLights[j] + " ");
                    }
                }

                Console.WriteLine();
            }

        }
    }
}
