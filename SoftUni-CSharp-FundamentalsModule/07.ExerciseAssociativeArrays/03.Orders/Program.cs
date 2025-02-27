namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            
            string input = default;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] tokens = input.Split();
                string name = tokens[0];
                decimal price = decimal.Parse(tokens[1]);
                uint quantity = uint.Parse(tokens[2]);
                
                if (!products.ContainsKey(name))
                {
                    products.Add(name, new Product(name, price, quantity));
                }
                else // products.ContainsKey(name)
                {
                    products[name].Update(price, quantity);
                }
            }

            foreach (KeyValuePair<string,Product> product in products)
            {
                Console.WriteLine(product.Value);
            }
        }
    }

    class Product
    {
        public Product(string name, decimal price, uint quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public uint Quantity { get; set; }
        public decimal TotalPrice => Price * Quantity;

        public void Update(decimal price, uint quantity)
        {
            Price = price;
            Quantity += quantity;
        }
        public override string ToString()
        {
            return $"{Name} -> {TotalPrice:F2}";
        }
    }
}
