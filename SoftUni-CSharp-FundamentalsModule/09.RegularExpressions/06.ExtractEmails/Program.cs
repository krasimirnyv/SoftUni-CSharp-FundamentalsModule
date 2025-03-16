using System.Text.RegularExpressions;

namespace _06.ExtractEmails;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        string pattern = @"(?<email>(?<user>(?<![\w\.\-])[a-z0-9]+(?:[\.\-_][a-z0-9]+)*)(?![\w\.\-])\@(?<host>(?<![\w\.\-])(?:[a-z]+(?:\-[a-z]+)*)+(?:\.(?:[a-z]+(?:\-[a-z]+)*)+)+))";
        
        MatchCollection emails = Regex.Matches(text, pattern);
        foreach (Match email in emails)
        {
            Console.WriteLine(email);
        }
    }
}
