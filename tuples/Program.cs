using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            transactions.Add(("cookies", 1.23, 55));
            transactions.Add(("tacos", 5.53, 60));
            transactions.Add(("pizza", 6.23, 85));
            transactions.Add(("cheese", 4.23, 43));
            transactions.Add(("ice cream", 8.34, 21));

            int itemsSold = 0;
            double revenue= 0.0;

            foreach ((string product, double amount, int quantity) t in transactions)
            {
                // Logic goes here to look up quantity and amount in each transaction
                itemsSold += t.quantity;
                revenue += t.amount;
            }
            Console.WriteLine($"Items sold today: {itemsSold}\nTotal Revenue: {revenue}");

        }
    }
}
