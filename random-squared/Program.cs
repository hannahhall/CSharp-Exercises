using System;
using System.Collections.Generic;


namespace random_squared
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> randomList = new List<int>();
            Random random = new Random();   
            for (int i = 0; i < 20; i++)
            {
                
                randomList.Add(random.Next(1,50));
            }
            Console.WriteLine($"Random numbers: {string.Join(", ", randomList)}");

            List<int> randomListSquared = new List<int>();
            foreach (int num in randomList)
            {
                randomListSquared.Add((int) Math.Pow(num, 2));
            }
            Console.WriteLine($"Random numbers squared: {string.Join(", ", randomListSquared)}");

            for (int i = 0; i < randomListSquared.Count; i ++)
            {
                if (randomListSquared[i] % 2 != 0)
                {  
                    randomListSquared.Remove(randomListSquared[i]);
                }
            }
            Console.WriteLine($"Random numbers squared without odds: {string.Join(", ", randomListSquared)}");
        }
    }
}
