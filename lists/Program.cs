using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> lastPlanets = new List<string>(){"Uranus", "Neptune"};
            planetList.AddRange(lastPlanets);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            List<string> rockyPlanets = planetList.GetRange(0, 4);

            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

             foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }
            
        }
    }
}
