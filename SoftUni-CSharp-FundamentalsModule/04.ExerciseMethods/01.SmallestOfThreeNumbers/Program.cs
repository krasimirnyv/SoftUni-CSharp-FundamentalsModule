namespace _01.SmallestOfThreeNumbers;

class Program
{
    static void Main(string[] args)
    {
        int smallestNumber = int.MaxValue;
        for (int i = 1; i <= 3; i++)
        {
            int number = int.Parse(Console.ReadLine());
            smallestNumber = SmallestNumber(smallestNumber, number);
        }

        Console.WriteLine(smallestNumber);
    }

    private static int SmallestNumber(int smallestNumber, int number)
    {
        if (smallestNumber > number)
        {
            smallestNumber = number;
        }

        return smallestNumber;
    }
}
