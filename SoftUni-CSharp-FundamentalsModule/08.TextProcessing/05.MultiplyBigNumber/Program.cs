using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            if (secondNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder result = new StringBuilder(capacity: number.Length + 1);
            int remainder = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int currentSum = (number[i] - '0') * secondNumber + remainder;
                remainder = currentSum / 10;
                int currentDigit = currentSum % 10;
                
                result.Append(currentDigit);
            }

            if (remainder != 0)
            {
                result.Append(remainder);
            }
            
            ReverseString(result);
        }

        private static void ReverseString(StringBuilder result)
        {
            StringBuilder reversed = new StringBuilder(result.Length);
            for (int i = result.Length - 1; i >= 0; i--)
            {
                reversed.Append(result[i]);
            }

            Console.WriteLine(reversed);
        }
    }
}
