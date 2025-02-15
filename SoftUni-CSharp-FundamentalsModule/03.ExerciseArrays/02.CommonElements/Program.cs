namespace _02.CommonElements;

class Program
{
    static void Main(string[] args)
    {
        string[] firstArray = Console.ReadLine().Split();
        string[] secondArray = Console.ReadLine().Split();

        string commonElements = string.Empty;

        for (int i = 0; i < secondArray.Length; i++)
        {
            for (int j = firstArray.Length - 1; j >= 0; j--)
            {
                if (secondArray[i] == firstArray[j])
                {
                    commonElements += secondArray[i] + " ";
                }
            }
        }

        Console.WriteLine(commonElements.TrimEnd());
    }
}
