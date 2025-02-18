namespace _09.PalindromeIntegers;

class Program
{
    static void Main(string[] args)
    {
        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            Console.WriteLine(IsPalindrome(input)
                .ToString()
                .ToLower());
        }
    }

    private static bool IsPalindrome(string input)
    {
        char[] array = input.ToCharArray();
        Array.Reverse(array);
        string reverse = new string(array);
        return input == reverse;
    }
}
