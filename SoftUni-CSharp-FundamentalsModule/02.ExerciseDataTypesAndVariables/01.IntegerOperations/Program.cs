using System;

class Program
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());
        int fourthNum = int.Parse(Console.ReadLine());

        int additionSum = firstNum + secondNum;
        int divisionSum = additionSum / thirdNum;
        int multiplicationSum = divisionSum * fourthNum;

        Console.WriteLine(multiplicationSum);
    }
}
