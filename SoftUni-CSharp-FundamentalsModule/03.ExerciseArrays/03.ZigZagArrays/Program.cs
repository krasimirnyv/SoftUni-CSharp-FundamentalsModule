namespace _03.ZigZagArrays;

class Program
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());
        
        string[] firstArr = new string[lines];
        string[] secondArr = new string[lines];
        
        for (int i = 0; i < lines; i++)
        {
            string[] input = Console.ReadLine().Split();
            
            string firstArrElement = input[0];
            string secondArrElement = input[1];

            if (i % 2 == 0)
            {
                firstArr[i] = firstArrElement;
                secondArr[i] = secondArrElement;
            }
            else // (i % 2 != 0)
            {
                firstArr[i] = secondArrElement;
                secondArr[i] = firstArrElement;
            }
        }

        Console.WriteLine($"{string.Join(" ", firstArr).TrimEnd()}\n" +
                          $"{string.Join(" ", secondArr).TrimEnd()}");
    }
}
