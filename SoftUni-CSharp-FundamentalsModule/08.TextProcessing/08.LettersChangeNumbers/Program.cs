namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            decimal result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currentWord = input[i];
                char prefix = currentWord[0];
                char suffix = currentWord[^1];
                
                decimal score = decimal.Parse(currentWord
                    .Substring(1, currentWord.Length - 2));
                
                if (char.IsUpper(prefix))
                {
                    int number = currentWord[0] - 'A' + 1;
                    score /= number;
                }
                else // char.IsLower(prefix)
                {
                    int number = currentWord[0] - 'a' + 1;
                    score *= number;
                }
                
                if (char.IsUpper(suffix))
                {
                    int number = currentWord[^1] - 'A' + 1;
                    score -= number;
                }
                else // char.IsLower(suffix)
                {
                    int number = currentWord[^1] - 'a' + 1;
                    score += number;
                }
                
                result += score;
            }

            Console.WriteLine($"{result:F2}");
        }
    }
}
