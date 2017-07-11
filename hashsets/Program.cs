using System;
using System.Collections.Generic;

namespace hashsets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Rogue");
            Showroom.Add("Wrangler");
            Showroom.Add("Camaro");
            Showroom.Add("Compass");
            Console.WriteLine($"There are {Showroom.Count} cars in the showroom");
            Showroom.Add("Camaro");
            Console.WriteLine($"There are still {Showroom.Count} cars in the showroom");

            HashSet<string> UsedLot = new HashSet<string>(){"Jalupa", "El Camino"};
            Showroom.UnionWith(UsedLot);
            // Showroom.Remove("Camaro");

            HashSet<string> Junkyard = new HashSet<string>{"Camaro", "Lemon", "Compass", "Tacoma"};
            // Junkyard.IntersectWith(Showroom);
            // foreach(string car in Junkyard)
            // {
            //     Console.WriteLine(car);
            // }

            Showroom.UnionWith(Junkyard);
            Showroom.Remove("Lemon");
            foreach(string car in Showroom)
            {
                Console.WriteLine(car);
            }
            
            
            
        }
    }
}
