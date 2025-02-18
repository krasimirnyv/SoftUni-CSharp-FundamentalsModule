using System.Text;

namespace _11.ArrayManipulator;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        
        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] tokens = input.Split();
            switch (tokens[0])
            {
                case "exchange":
                    int index = int.Parse(tokens[1]);
                    numbers = ExchangeIndex(numbers, index);
                    break;
                case "max":
                    string evenOrOdd = tokens[1];
                    ReturnMaxIndex(evenOrOdd, numbers);
                    break;
                case "min":
                    evenOrOdd = tokens[1];
                    ReturnMinIndex(evenOrOdd, numbers);
                    break;
                case "first":
                    int count = int.Parse(tokens[1]);
                    evenOrOdd = tokens[2];
                    FirstElement(evenOrOdd, count, numbers);
                    break;
                case "last":
                    count = int.Parse(tokens[1]);
                    evenOrOdd = tokens[2];
                    LastElement(evenOrOdd, count, numbers);
                    break;
            }
        }

        Console.WriteLine($"[{string.Join(", ", numbers).Trim(',', ' ')}]");
    }

    private static int[] ExchangeIndex(int[] numbers, int index)
    {
        if (IndexValidation(numbers, index))
        {
            Console.WriteLine("Invalid index");
            return numbers;
        }
        
        int[] result = new int[numbers.Length];
        int resultsIndex = 0;
        for (int i = index + 1; i < numbers.Length; i++)
        {
            result[resultsIndex++] = numbers[i];
        }

        for (int i = 0; i <= index; i++)
        {
            result[resultsIndex++] = numbers[i];
        }
        
        return result;
    }

    private static void ReturnMaxIndex(string evenOrOdd, int[] numbers)
    {
        int maxNumber = int.MinValue;
        int indexMaxNumber = -1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (EvenOrOddNumber(evenOrOdd, numbers, i)
                && numbers[i] >= maxNumber)
            {
                maxNumber = numbers[i];
                indexMaxNumber = i;
            }
        }

        if (MatchIndexValidation(indexMaxNumber))
        {
            Console.WriteLine("No matches");
            return;
        }

        Console.WriteLine(indexMaxNumber);
    }
    
    private static void ReturnMinIndex(string evenOrOdd, int[] numbers)
    {
        int minNumber = int.MaxValue;
        int indexMinNumber = -1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (EvenOrOddNumber(evenOrOdd, numbers, i)
                && numbers[i] <= minNumber)
            {
                minNumber = numbers[i];
                indexMinNumber = i;
            }
        }

        if (MatchIndexValidation(indexMinNumber))
        {
            Console.WriteLine("No matches");
            return;
        }

        Console.WriteLine(indexMinNumber);
    }

    private static void FirstElement(string evenOrOdd, int count, int[] numbers)
    {
        if (CountValidation(numbers, count))
        {
            Console.WriteLine("Invalid count");
            return;
        }
        
        string result = string.Empty;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (EvenOrOddNumber(evenOrOdd, numbers, i)
                && count > 0)
            {
                count--;
                result += $"{numbers[i]}, ";
            }
            
            if (IsCountZero(count))
            {
                break;
            }
        }

        Console.WriteLine($"[{result.Trim(',', ' ')}]");
    }

    private static void LastElement(string evenOrOdd, int count, int[] numbers)
    {
        if (CountValidation(numbers, count))
        {
            Console.WriteLine("Invalid count");
            return;
        }
        
        string result = string.Empty;
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            if (EvenOrOddNumber(evenOrOdd, numbers, i)
                && count > 0)
            {
                count--;
                result = $"{numbers[i]}, " + result;
            }

            if (IsCountZero(count))
            {
                break;
            }
        }
        
        Console.WriteLine($"[{result.Trim(',', ' ')}]");
    }
    

    private static bool IndexValidation(int[] numbers, int index)
    {
        return index < 0 || index >= numbers.Length;
    }
    
    private static bool CountValidation(int[] numbers, int count)
    {
        return count < 0 || count > numbers.Length;
    }
    
    private static bool EvenOrOddNumber(string evenOrOdd, int[] numbers, int i)
    {
        return (evenOrOdd == "even" && numbers[i] % 2 == 0) 
               || (evenOrOdd == "odd" && numbers[i] % 2 != 0);
    }

    private static bool MatchIndexValidation(int index)
    {
        return index == -1;
    }
    
    private static bool IsCountZero(int count)
    {
        return count == 0;
    }
    
}
