using System.ComponentModel.Design;

namespace _10.LadyBugs;

class Program
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());
        
        int[] field = new int[length];
        
        int[] bugIndexes = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        
        for (int i = 0; i < bugIndexes.Length; i++)
        {
            if (bugIndexes[i] >= 0 && bugIndexes[i] < field.Length)
            {
                field[bugIndexes[i]] = 1;
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] tokens = command.Split();
            int currentIndex = int.Parse(tokens[0]);
            string direction = tokens[1];
            int distance = int.Parse(tokens[2]);

            if (currentIndex >= 0 && currentIndex < field.Length && field[currentIndex] == 1)
            {
                field[currentIndex] = 0;
                switch (direction)
                {
                    case "right":
                        for (int i = currentIndex + distance; i < field.Length; i += distance)
                        {
                            if (i >= field.Length || i < 0)
                            {
                                break;
                            }
                            
                            if (field[i] == 0 && i >= 0 && i < field.Length)
                            {
                                field[i] = 1;
                                break;
                            }
                        }
                        break;
                    case "left":
                        for (int i = currentIndex - distance; i >= 0; i -= distance)
                        {
                            if (i >= field.Length || i < 0)
                            {
                                break;
                            }
                            
                            if (field[i] == 0 && i >= 0 && i < field.Length)
                            {
                                field[i] = 1;
                                break;
                            }
                        }
                        break;
                    default:
                        continue;
                }
            }
        }

        Console.WriteLine(string.Join(" ", field).TrimEnd());
    }
}
