// Define a bank
public class Bank
{
    public string Symbol { get; set; }
    public string Name { get; set; }
}

// Define a customer
public class Customer
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
}
