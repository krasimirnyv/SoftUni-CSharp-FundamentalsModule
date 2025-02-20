using System;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            string command = String.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "Add":
                        int number = int.Parse(tokens[1]);
                        numbers.Add(number);
                        break;
                    case "Insert":
                        number = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        if (IsIndexInRange(index, numbers))
                        {
                            numbers.Insert(index, number);
                        }
                        
                        break;
                    case "Remove":
                        index = int.Parse(tokens[1]);
                        if (IsIndexInRange(index, numbers))
                        {
                            numbers.RemoveAt(index);
                        }     
                        
                        break;
                    case "Shift":
                        string direction = tokens[1];
                        int count = int.Parse(tokens[2]);
                        ShiftNumbers(numbers, direction, count);
                        break;
                }
            }
            
            Console.WriteLine(string.Join(" ", numbers));
        }
        
        private static void ShiftNumbers(List<int> numbers, string direction, int count)
        {
            count %= numbers.Count;
            if (direction == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    numbers.Add(numbers[0]);
                    numbers.RemoveAt(0);
                }
            }
            else // direction == "right"
            {
                for (int i = count - 1; i >= 0; i--)
                {
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                    numbers.RemoveAt(numbers.Count - 1);
                }           
            }        
        }
        
        private static bool IsIndexInRange(int index, List<int> numbers)
        {
            if (index < 0 || index >= numbers.Count)
            {
                Console.WriteLine("Invalid index");
                return false;
            }
            
            return true;
        }

    }
}
