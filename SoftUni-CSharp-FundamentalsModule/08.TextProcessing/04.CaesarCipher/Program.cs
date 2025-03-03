using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            StringBuilder result = new StringBuilder(capacity: text.Length);
            for (int i = 0; i < text.Length; i++)
            {
                result.Append((char)(text[i] + 3));
            }
            
            Console.WriteLine(result);
        }
    }
}
