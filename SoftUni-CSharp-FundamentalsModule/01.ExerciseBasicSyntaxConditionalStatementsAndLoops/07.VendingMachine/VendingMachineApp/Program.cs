using System;

class Program
{
    static void Main()
    {
        string coinInput = Console.ReadLine();

        double sum = 0;
        while (coinInput != "Start")
        {
            bool isCoin = double.TryParse(coinInput, out double coin);
            if (isCoin == false && coinInput != "Start")
            {
                Console.WriteLine($"Cannot accept {coinInput}");
            }
            else
            {
                double coins = double.Parse(coinInput);
                if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                else
                {
                    sum += coins;
                }
            }
            
            coinInput = Console.ReadLine();
        }

        string productInput = Console.ReadLine();
        while (productInput != "End")
        {
            switch (productInput)
            {
                case "Nuts":
                    double nutsPrice = 2;
                    if (sum >= nutsPrice)
                    {
                        sum -= nutsPrice;
                        Console.WriteLine($"Purchased {productInput.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    productInput = Console.ReadLine();
                    break;
                
                case "Water":
                    double waterPrice = 0.7;
                    if (sum >= waterPrice)
                    {
                        sum -= waterPrice;
                        Console.WriteLine($"Purchased {productInput.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    productInput = Console.ReadLine();
                    break;
                
                case "Crisps":
                    double crispsPrice = 1.5;
                    if (sum >= crispsPrice)
                    {
                        sum -= crispsPrice;
                        Console.WriteLine($"Purchased {productInput.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    productInput = Console.ReadLine();
                    break;
                
                case "Soda":
                    double sodaPrice = 0.8;
                    if (sum >= sodaPrice)
                    {
                        sum -= sodaPrice;
                        Console.WriteLine($"Purchased {productInput.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    productInput = Console.ReadLine();
                    break;
                
                case "Coke":
                    double cokePrice = 1;
                    if (sum >= cokePrice)
                    {
                        sum -= cokePrice;
                        Console.WriteLine($"Purchased {productInput.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    productInput = Console.ReadLine();
                    break;
                
                default:
                    Console.WriteLine($"Invalid product");
                    productInput = Console.ReadLine();
                    break;
            }
        }

        Console.WriteLine($"Change: {sum:F2}");
    }
}
