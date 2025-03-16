using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome;

class Program
{
    static void Main()
    {
        List<Order> orders = new List<Order>();
        string input = default;
        while ((input = Console.ReadLine()) != "end of shift")
        {
            string pattern = @"\%(?<customer>[A-Z][a-z]+)\%[^\|\$\%\.]*\<(?<product>\w+)\>[^\|\$\%\.]*\|(?<count>\d+)\|[^\|\$\%\.]*?(?<price>\d+\.\d+|\d+\,\d+|\d+)\$";
        
            if (Regex.IsMatch(input, pattern))
            {
                Match match = Regex.Match(input, pattern);
                string customer = match.Groups["customer"].Value;
                string product = match.Groups["product"].Value;
                uint count = uint.Parse(match.Groups["count"].Value);
                decimal price = decimal.Parse(match.Groups["price"].Value);

                orders.Add(new Order(customer, product, count, price));
                Console.WriteLine($"{customer}: {product} - {(count * price):F2}");
            }
        }

        Console.WriteLine($"Total income: {orders.Sum(x => x.TotalIncome):F2}");
    }
}

class Order
{
    public Order(string customer, string product, uint count, decimal price)
    {
        Customer = customer;
        Product = product;
        Count = count;
        Price = price;
    }

    public string Customer { get; set; }
    public string Product { get; set; }
    public uint Count { get; set; }
    public decimal Price { get; set; }
    public decimal TotalIncome => Count * Price;
}
