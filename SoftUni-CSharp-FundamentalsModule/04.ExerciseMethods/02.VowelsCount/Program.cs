namespace _02.VowelsCount;

class Program
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        VowelsCount(word);
    }

    private static void VowelsCount(string word)
    {
        char[] letters = word.ToCharArray();
        int vowelCount = 0;
        for (int i = 0; i < letters.Length; i++)
        {
            if (VowelCount(letters, i))
            {
                vowelCount++;
            }
        }

        Console.WriteLine(vowelCount);
    }

    private static bool VowelCount(char[] letters, int i)
    {
        return letters[i] == 'a' || letters[i] == 'A' ||
               letters[i] == 'e' || letters[i] == 'E' ||
               letters[i] == 'i' || letters[i] == 'I' ||
               letters[i] == 'o' || letters[i] == 'O' ||
               letters[i] == 'u' || letters[i] == 'U';
    }
}
