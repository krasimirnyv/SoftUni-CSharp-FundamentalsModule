using System;

class Program
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = firstNum; i <= secondNum; i++)
        {
            sum += i;
            Console.Write($"{i} ");
        }
        
        Console.WriteLine($"\nSum: {sum}");
    }
}
