using System;

class Program
{
    static void Main()
    {
        int firstCharIndex = int.Parse(Console.ReadLine());
        int endCharIndex = int.Parse(Console.ReadLine());

        for (int i = firstCharIndex; i < endCharIndex; i++)
        {
            Console.Write($"{(char)i} ");
        }

        Console.Write($"{(char)endCharIndex}");
    }
}
