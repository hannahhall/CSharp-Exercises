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
                // Console.WriteLine(planet);
            }

            Dictionary<string, List<string>> mars = new Dictionary<string, List<string>>();
            mars.Add("Mars", new List<string>(){
                "craft3", "craft2"
            });

            Dictionary<string, List<string>> Earth = new Dictionary<string, List<string>>();
            Earth.Add("Earth", new List<string>(){
                "craft5", "craft1", "craft9"
            });

            List<Dictionary<string, List<string>>> spacecraft = new List<Dictionary<string, List<string>>>()
            {
                mars, Earth
            };

            foreach (string planet in planetList)
            {
                string visitors = "";

                foreach(var pair in spacecraft)
                {
                    foreach(var kvp in pair)
                    {
                        if(kvp.Key == planet)
                        {
                            visitors = string.Join(", ", kvp.Value);
                        }
                    }
                }
                if (visitors != "")
                {
                    Console.WriteLine($"{planet}: {visitors}");
                }
            }
        }
    }
}
