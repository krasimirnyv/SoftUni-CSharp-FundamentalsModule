namespace _06.EqualSum;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        if (numbers.Length == 1)
        {
            Console.WriteLine(0);
            return;
        }
        
        for (int index = 0; index < numbers.Length; index++)
        {
            int rightSum = 0;
            int leftSum = 0;
            if (index < numbers.Length - 1)
            {
                for (int j = index + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }
            }

            if (index > 0)
            {
                for (int j = index - 1; j >= 0; j--)
                {
                    leftSum += numbers[j];
                }
            }

            if (rightSum == leftSum)
            {
                Console.WriteLine(index);
                return;
            }
        }
        
        Console.WriteLine("no");
    }
}
