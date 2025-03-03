using System.Text;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            
            StringBuilder result = new StringBuilder();
            int strength = 0;
            for (int i = 0; i < input.Length; i++)
            { 
                if (input[i] == '>')
                {
                    strength += input[i + 1] - '0';
                    result.Append(input[i]);
                }
                else if (strength > 0)
                {
                    strength--;
                }
                else
                {
                    result.Append(input[i]);
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
