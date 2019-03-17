using System;
using System.Collections.Generic;

namespace planets_spaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> anotherList = new List<string>(){"Uranus", "Neptune"};

            planetList.AddRange(anotherList);
            planetList.Insert(1, "Earth");
            planetList.Insert(2, "Venus");
            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");

            List<string> mercuryMissions = new List<string> { "Mariner 10", "MESSENGER", "BepiColombo", "Mio" };
            List<string> venusMissions = new List<string> { "Tyazhely Sputnik", "Venera 1", "Mariner 1", "Cosmos 21" };
            List<string> earthMissions = new List<string> { "Mariner 10", "Pioneer 10", "Pioneer 11", "Voyager" };
            List<string> marsMissions = new List<string> { "Mars 2", "Mariner 9", "Viking", "Phoenix" };
            List<string> jupiterMissions = new List<string> { "Mariner 3", "Zond", "Balloon" };
            List<string> saturnMissions = new List<string> { "Cassini", "Voyager 1" };
            List<string> uranusMissions = new List<string> { "Voyager 2" };
            List<string> neptuneMissions = new List<string> { "Voyager 2" };

            var spacecrafts = new Dictionary<string, List<string>>();
            spacecrafts.Add(planetList[0], mercuryMissions);
            spacecrafts.Add(planetList[1], venusMissions);
            spacecrafts.Add(planetList[2], earthMissions);
            spacecrafts.Add(planetList[3], marsMissions);
            spacecrafts.Add(planetList[4], jupiterMissions);
            spacecrafts.Add(planetList[5], saturnMissions);
            spacecrafts.Add(planetList[6], uranusMissions);
            spacecrafts.Add(planetList[7], neptuneMissions);

                        foreach (var planet in planetList)
            {
                string shuttles = "";
                foreach (var shuttle in spacecrafts[planet])
                {
                    if (shuttle != spacecrafts[planet][0])
                    {
                    shuttles += $", {shuttle}";
                    } else
                    {
                        shuttles += $"{shuttle}";
                    }
                }
                Console.WriteLine($"{planet}: {shuttles}\n");
            }

        }
    }
}
