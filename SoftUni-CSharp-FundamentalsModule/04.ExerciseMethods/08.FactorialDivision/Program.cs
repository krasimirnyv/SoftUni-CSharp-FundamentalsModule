namespace _08.FactorialDivision;

class Program
{
    static void Main(string[] args)
    {
        long firstNum = long.Parse(Console.ReadLine());
        long secondNum = long.Parse(Console.ReadLine());

        long firstNumFactorial = Factorial(firstNum);
        long secondNumFactorial = Factorial(secondNum);
        
        double result = (double)firstNumFactorial / secondNumFactorial;
        Console.WriteLine($"{result:F2}");
    }

    private static long Factorial(long n)
    {
        long factorial = 1;
        
        for (long i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}
