using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int cloneNum = num;
        int sum = 0;
        while (cloneNum > 0)
        {
            int digit = cloneNum % 10;
            cloneNum /= 10;
            int fact = 1;
            
            for (int i = 1; i <= digit; i++)
            {
                fact *= i;
            }
            
            sum += fact;
        }

        if (sum == num)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
