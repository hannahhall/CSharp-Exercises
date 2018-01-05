using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Animal
    {
        public string Name {get; set;}
        public string Species   { get; set; }
        public virtual string Walk()
        {
            return "Roaming Free";
        }
    }

    public class Dog : Animal
    {
        public override string Walk()
        {
            return "Walking on a leash";
        }
    }
}
