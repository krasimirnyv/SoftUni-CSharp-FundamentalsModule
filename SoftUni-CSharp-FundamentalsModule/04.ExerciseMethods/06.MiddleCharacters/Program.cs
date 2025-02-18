namespace _06.MiddleCharacters;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        
        char[] inputArray = input.ToCharArray();
        
        MiddleCharInOddLengthString(inputArray);
        MiddleCharsInEvenLengthString(inputArray);
        
    }
    
    private static void MiddleCharInOddLengthString(char[] inputArray)
    {
        if (inputArray.Length % 2 != 0)
        {
            int middle = inputArray.Length / 2;
            
            Console.WriteLine(inputArray[middle]);
        }
    }
    
    private static void MiddleCharsInEvenLengthString(char[] inputArray)
    {
        if (inputArray.Length % 2 == 0)
        {
            int firstMiddle = inputArray.Length / 2 - 1;
            int secondMiddle = inputArray.Length / 2;

            Console.WriteLine($"{inputArray[firstMiddle]}" +
                              $"{inputArray[secondMiddle]}");
        }
    }
}
