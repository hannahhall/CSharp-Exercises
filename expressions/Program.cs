using System;
using System.Collections.Generic;

namespace expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Predators = new List<string>(){
                "Birds",
                "Frogs",
                "Lizards",
                "Snacks"
            };

            List<string> Prey = new List<string>(){
                "Leaves",
                "Flowers",
                "Smaller Bugs?",
            };

            Bug LadyBug = new Bug("Carol", "Lady Bug", Predators, Prey);

            Console.WriteLine($"{LadyBug.FormalName} eats {LadyBug.PreyList()}. It's predators are {LadyBug.PredatorList()}. {LadyBug.Eat("Leaves")} {LadyBug.Eat("beer")}");
        }
    }
}
