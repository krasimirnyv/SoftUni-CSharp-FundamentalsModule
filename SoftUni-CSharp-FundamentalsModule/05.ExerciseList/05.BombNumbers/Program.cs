using System;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            int[] commands = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            int bomb = commands[0];
            int power = commands[1];

            while (numbers.Contains(bomb))
            {
                int index = numbers.IndexOf(bomb);
                
                int leftIndex = Math.Max(0, index - power);
                int rightIndex = Math.Min(numbers.Count - 1, index + power);
                numbers.RemoveRange(leftIndex, rightIndex - leftIndex + 1);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
