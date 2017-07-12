using System;
using System.Linq;
using System.Collections.Generic;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

            var LFruits = from fruit in fruits
            where fruit[0] == 'L'
            select fruit;
            Console.WriteLine($"Fruits that start with L: {string.Join(", ", LFruits)}");

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            var fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0);
            Console.WriteLine($"Numbers that are multiples of 4 or 6:  {string.Join(", ", fourSixMultiples)}");


            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre" 
            };
            var descend = from name in names
            orderby name descending
            select name;
            Console.WriteLine($"Names in reverse order: {string.Join(", ", descend)}");

            // Build a collection of these numbers sorted in ascending order
            List<int> numbers2 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            var ascendNumbers = numbers2.OrderBy(number => number);
            Console.WriteLine( $"Numbers in ascending order: {string.Join(", ", ascendNumbers)}");

            // Output how many numbers are in this list
            List<int> numbers3 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            int Count = numbers3.Count();
            Console.WriteLine($"There are {Count} numbers in the list");

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            var total = purchases.Sum(number => number);
            Console.WriteLine($"We made {total}.");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            var maxPrice = prices.Max(price => price);
            Console.WriteLine($"The highest price is {maxPrice}");

            /*
                Store each number in the following List until a perfect square
                is detected.

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };
            var firstSquare = wheresSquaredo.TakeWhile(number => Math.Sqrt(number) % 1 != 0);
            Console.WriteLine($"Numbers until the first square {string.Join(", ", firstSquare)}");

            // Build a collection of customers who are millionaires
            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };
            var groupByBank = customers
                .Where(customer => customer.Balance >= 1000000)
                .GroupBy(customer => customer.Bank, customer => customer);
                
            foreach(var bank in groupByBank)
            {
                Console.WriteLine($"{bank.Key}: {bank.Count()}");
            }

             // Create some banks and store in a List
            List<Bank> banks = new List<Bank>() {
                new Bank(){ Name="First Tennessee", Symbol="FTB"},
                new Bank(){ Name="Wells Fargo", Symbol="WF"},
                new Bank(){ Name="Bank of America", Symbol="BOA"},
                new Bank(){ Name="Citibank", Symbol="CITI"},
            };

            var millionaireReport = from bank in banks
                                    join customer in groupByBank on bank.Symbol equals customer.Key
                                    select new { Bank = bank.Name, Customer = customer};

            foreach (var millionaire in millionaireReport)
            {
                foreach (var customer in millionaire.Customer)
                {
                    Console.WriteLine($"{customer.Name} has an account at {millionaire.Bank}");
                }
            }
        }
    }
}
