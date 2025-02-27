namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            
            Dictionary<char, int> counts = new Dictionary<char, int>();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    continue;
                }
                
                if (!counts.ContainsKey(chars[i]))
                {
                    counts.Add(chars[i], 0);
                }
                
                counts[chars[i]]++;
            }

            foreach (KeyValuePair<char, int> charCount in counts)
            {
                Console.WriteLine($"{charCount.Key} -> {charCount.Value}");
            }
        }
    }
}
