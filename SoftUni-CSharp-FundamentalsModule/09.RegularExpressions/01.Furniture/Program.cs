using System.Text.RegularExpressions;

namespace _01.Furniture;

class Program
{
    static void Main()
    {
        List<Furniture> furnitures = new List<Furniture>();
        
        string input = default;
        while ((input = Console.ReadLine()) != "Purchase")
        {
            string pattern = @"\>\>(?<name>[A-Za-z]+)\<\<(?<price>\d+\.\d+|\d+\,\d+|\d+)\!(?<quantity>\d+)";

            foreach (Match match in Regex.Matches(input, pattern))
            {
                string name = match.Groups["name"].Value;
                decimal price = decimal.Parse(match.Groups["price"].Value);
                uint quantity = uint.Parse(match.Groups["quantity"].Value);

                furnitures.Add(new Furniture(name, price, quantity));
            }
        }
        
        Console.WriteLine("Bought furniture:");
        decimal spendedMoney = 0;
        furnitures.ForEach(x =>
        {
            Console.WriteLine(x);
            spendedMoney += x.TotalPrice;
        });
        
        Console.WriteLine($"Total money spend: {spendedMoney:F2}");
    }
}

class Furniture
{
    public Furniture(string name, decimal price, uint quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public uint Quantity { get; set; }
    public decimal TotalPrice => Price * Quantity;
    public override string ToString()
    {
        return Name;
    }
}
