# C# Value Tuples

## Instructions

1. In `Main` method, create a list of value tuples that will hold individual transactions for a hardware business. Each tuple will store the product, the total amount of the transaction, and the quantity of the product.
    ```cs
    List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
    ```
1. Add 5, or more, transactions to the list.
1. Iterate over the list of tuples and calculate how many total products you sold today, and what your total revenue was.
    ```cs
    foreach ((string product, double amount, int quantity) t in transactions)
    {
        // Logic goes here to look up quantity and amount in each transaction
    }
    ```

Sample output

```
Items sold today: 23
Total revenue: $3011.76
```