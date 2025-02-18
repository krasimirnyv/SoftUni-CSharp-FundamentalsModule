namespace _03.CharactersInRange;

class Program
{
    static void Main(string[] args)
    {
        char firstLetter = char.Parse(Console.ReadLine());
        char secondLetter = char.Parse(Console.ReadLine());
        
        PrintCharsFromASCII(firstLetter, secondLetter);
    }

    private static void PrintCharsFromASCII(char firstLetter, char secondLetter)
    {
        int biggerLetter = Math.Max(firstLetter, secondLetter);
        int smallerLetter = Math.Min(firstLetter, secondLetter);

        for (int i = smallerLetter + 1; i < biggerLetter; i++)
        {
            Console.Write($"{(char)i} ");
        }
    }
}
