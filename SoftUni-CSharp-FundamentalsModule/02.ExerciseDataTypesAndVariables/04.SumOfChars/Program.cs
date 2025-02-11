using System;

class Program
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= lines; i++)
        {
            char letter = char.Parse(Console.ReadLine());
            sum += letter;
        }
        
        Console.WriteLine($"The sum equals: {sum}");
    }
}
