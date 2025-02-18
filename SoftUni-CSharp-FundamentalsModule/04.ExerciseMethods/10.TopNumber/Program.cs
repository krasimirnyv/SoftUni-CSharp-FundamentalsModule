namespace _10.TopNumber;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            bool isSumDivisibleByEight = IsSumOfDigitsDivisibleByEight(i);
            bool isHoldsOdds = IsNumHoldsOddDigit(i);

            if (isSumDivisibleByEight && isHoldsOdds)
            {
                Console.WriteLine(i);
            }
        }
    }
    
    private static bool IsSumOfDigitsDivisibleByEight(int num)
    {
        int sumOfDigits = 0;
        while (num > 0)
        {
            int digit = num % 10;
            num /= 10;
            sumOfDigits += digit;
        }

        if (sumOfDigits % 8 == 0)
        {
            return true;
        }

        return false;
    }
    
    private static bool IsNumHoldsOddDigit(int num)
    {
        while (num > 0)
        {
            int digit = num % 10;
            num /= 10;

            if (digit % 2 != 0)
            {
                return true;
            }
        }
        
        return false;
    }
}
