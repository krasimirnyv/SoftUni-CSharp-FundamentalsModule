using System;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "Delete":
                        int element = int.Parse(tokens[1]);
                        numbers.RemoveAll(e => e == element);
                        break;
                    case "Insert":
                        element = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        numbers.Insert(index, element);
                        break;
                }
            }
            
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
