using System.Text.RegularExpressions;

namespace _05.NetherRealms;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] demonPatterns = input
            .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<Demon> demons = new List<Demon>();
        foreach (string demon in demonPatterns)
        {
            long health = CalculateHealth(demon);
            decimal damage = CalculateDamage(demon);
            
            demons.Add(new Demon(demon, health, damage));
        }

        demons = demons.OrderBy(x => x.Name).ToList();
        foreach (Demon demon in demons)
        {
            Console.WriteLine(demon);
        }
    }

    private static long CalculateHealth(string demonName)
    {
        long health = 0;
        string charPattern = @"[^\d+\+\-\*\/\.]";
        
        MatchCollection matches = Regex.Matches(demonName, charPattern);
        foreach (Match match in matches)
        {
            health += char.Parse(match.Value);
        }
        
        return health;
    }
    
    private static decimal CalculateDamage(string demonName)
    {
        decimal damage = 0;
        string numberPattern = @"(?:(?:[-+]*)(?:\d+\.\d+|\d+))";
        
        MatchCollection matches = Regex.Matches(demonName, numberPattern);
        foreach (Match match in matches)
        {
            decimal number;
            decimal.TryParse(match.Value, out number);
            damage += number;
        }
        
        string multiOrDivPattern = @"\*|\/";
        foreach (Match match in Regex.Matches(demonName, multiOrDivPattern))
        {
            switch (match.Value)
            {
                case "*":
                    damage *= 2;
                    break;
                case "/":
                    damage /= 2;
                    break;
            }
        }
        
        return damage;
    }
}

class Demon
{
    public Demon(string name, long health, decimal damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public string Name { get; set; }
    public long Health { get; set; }
    public decimal Damage { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Health} health, {Damage:F2} damage";
    }
}