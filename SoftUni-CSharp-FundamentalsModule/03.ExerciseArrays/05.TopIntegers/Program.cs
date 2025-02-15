namespace _05.TopIntegers;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        
        string result = String.Empty;
        int lastElement = numbers[numbers.Length - 1];
        int topInteger = Int32.MinValue;
        
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] <= numbers[i + 1])
            {
                continue;
            }

            int index = i;
            topInteger = numbers[i];
            
            while (topInteger > numbers[i + 1] && index < numbers.Length - 1)
            {
                if (index == numbers.Length - 2 && topInteger > numbers[numbers.Length - 1])
                {
                    result += $"{topInteger} ";
                }

                index++;
            }
        }
        
        result += $"{lastElement}";
        Console.WriteLine($"{result}");
    }
}
