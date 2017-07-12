using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){ 
                {"name", "Dara"},
                {"age", "24"}
            });

            myFamily.Add("dad", new Dictionary<string, string>(){
                {"name", "Thomas"},
                {"age", "55"}
            });

            myFamily.Add("mom", new Dictionary<string, string>(){
                {"name", "Jamie"},
                {"age", "56"}
            });

            foreach (var person in myFamily)
            {
                Console.WriteLine($"{person.Value["name"]} is my {person.Key} and is {person.Value["age"]}");
                
            }
            
        }
    }
}
