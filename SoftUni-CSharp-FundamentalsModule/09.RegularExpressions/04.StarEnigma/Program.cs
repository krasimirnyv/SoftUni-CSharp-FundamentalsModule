using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma;

class Program
{
    static void Main()
    {
        List<Message> messages = new List<Message>();
        uint messagesCount = uint.Parse(Console.ReadLine());
        for (int i = 0; i < messagesCount; i++)
        {
            string encryptMsg = Console.ReadLine();
            string starPattern = @"[SsTtAaRr]";

            int decryptionKey = Regex.Matches(encryptMsg, starPattern).Count;
            StringBuilder builderMsg = new StringBuilder(capacity: encryptMsg.Length);
            for (int j = 0; j < encryptMsg.Length; j++)
            {
                builderMsg.Append((char)(encryptMsg[j] - decryptionKey));
            }
            
            string decryptedMsg = builderMsg.ToString();
            string msgPattern = @"@(?<name>[A-Za-z]+)[^\@\-\!\:\>]*\:(?<population>\d+)[^\@\-\!\:\>]*\!(?<type>A|D)\![^\@\-\!\:\>]*\-\>(?<soldier>\d+)";
            Match match = Regex.Match(decryptedMsg, msgPattern);
            if (match.Success)
            {
                string name = match.Groups["name"].Value;
                uint population = uint.Parse(match.Groups["population"].Value);
                string type = match.Groups["type"].Value;
                uint soldier = uint.Parse(match.Groups["soldier"].Value);
                
                messages.Add(new Message(name, population, type, soldier));
            }
        }
        
        List<Message> foundMsgs = messages
            .Where(x =>x.Type == AttackType.Attack)
            .OrderBy(x => x.Name)
            .ToList();

        Console.WriteLine($"Attacked planets: {foundMsgs.Count}");
        foundMsgs.ForEach(x => Console.WriteLine($"-> {x.Name}"));
        
        foundMsgs = messages
            .Where(x => x.Type == AttackType.Destruction)
            .OrderBy(x => x.Name)
            .ToList();
        
        Console.WriteLine($"Destroyed planets: {foundMsgs.Count}");
        foundMsgs.ForEach(x => Console.WriteLine($"-> {x.Name}"));
    }
}

class Message
{
    public Message(string name, uint population, string type, uint soldiers)
    {
        Name = name;
        Population = population;
        Type = type == "A" ? AttackType.Attack : AttackType.Destruction;
        Soldiers = soldiers;
    }

    public string Name { get; set; }
    public uint Population { get; set; }
    public AttackType Type { get; set; }
    public uint Soldiers { get; set; }
}

public enum AttackType
{
    Attack,
    Destruction
}
