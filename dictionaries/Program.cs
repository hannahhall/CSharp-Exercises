using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();

            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("CH", "Chocolate");
            stocks.Add("AP", "Airplane");

            string GM = stocks["GM"];

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GM", shares: 32, price: 17.87));
            purchases.Add((ticker: "CAT", shares: 80, price: 19.02));
            purchases.Add((ticker: "CH", shares: 880, price: 100.42));
            purchases.Add((ticker: "CH", shares: 100, price: 21.24));
            purchases.Add((ticker: "AP", shares: 180, price: 56.35));
            purchases.Add((ticker: "AP", shares: 45, price: 15.72));

            Dictionary<string, int> aggPurchases = new Dictionary<string, int>();

            // Iterate over the purchases and 
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                int total = (int) purchase.price * (int) purchase.shares;
                // Does the company name key already exist in the report dictionary?
                if (aggPurchases.ContainsKey(stocks[purchase.ticker]))
                {
                    // If it does, update the total valuation
                    aggPurchases[stocks[purchase.ticker]] += total;
                }
                else
                {
                    // If not, add the new key and set its value
                    aggPurchases.Add(stocks[purchase.ticker], total);
                }      
            }
            
            foreach(KeyValuePair<string, int> item in aggPurchases)
            {
                Console.WriteLine($"{item.Key} sold {item.Value}");
            }
        }
    }
}
