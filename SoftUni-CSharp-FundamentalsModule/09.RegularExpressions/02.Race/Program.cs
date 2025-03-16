using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race;

class Program
{
    static void Main()
    {
        List<string> participants = Console.ReadLine()
            .Split(", ")
            .ToList();

        List<Participant> racers = new List<Participant>();
        string input = default;
        while ((input = Console.ReadLine()) != "end of race")
        {
            string namePattern = @"(?<name>[A-Za-z])";
            StringBuilder nameBuild = new StringBuilder();
            foreach (Match match in Regex.Matches(input, namePattern))
            {
                nameBuild.Append(match.Groups["name"].Value);
            }
            
            string name = nameBuild.ToString();
            if (participants.Contains(name))
            {
                string distancePattern = @"(?<distance>\d)";
                uint distance = 0;
                foreach (Match match in Regex.Matches(input, distancePattern))
                {
                    distance += uint.Parse(match.Groups["distance"].Value);
                }
                
                if (!racers.Exists(x => x.Name == name))
                {
                    racers.Add(new Participant(name, distance));
                    continue;
                }
                
                racers.Find(x => x.Name == name).Distance += distance;
            }
        }

        List<Participant> sortedRacers = racers
            .OrderByDescending(x => x.Distance)
            .Take(3)
            .ToList();
        
        Console.WriteLine($"1st place: {sortedRacers[0]}\n"+
                          $"2nd place: {sortedRacers[1]}\n"+
                          $"3rd place: {sortedRacers[2]}");
    }
}

class Participant
{
    public Participant(string name, uint distance)
    {
        Name = name;
        Distance = distance;
    }

    public string Name { get; set; }
    public uint Distance { get; set; }
    public override string ToString()
    {
        return Name;
    }
}
