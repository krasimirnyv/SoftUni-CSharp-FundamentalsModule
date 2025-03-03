using System.Text;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            
            int index = 0;
            while (index < text.Length)
            {
                while (index + 1 < text.Length && text[index] == text[index + 1])
                {
                    index++;
                }
                
                result.Append(text[index]);
                index++;
            }

            Console.WriteLine(result.ToString());
        }
    }
}
