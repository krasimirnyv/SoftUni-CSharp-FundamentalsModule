using System;

class Program
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());

        int capacity = 255;
        int totalLiters = 0;
        for (int i = 1; i <= lines; i++)
        {
            int liters = int.Parse(Console.ReadLine());
            if (liters > capacity)
            {
                Console.WriteLine("Insufficient capacity!");
            }
            else // capacity <= liters
            {
                capacity -= liters;
                totalLiters += liters;
            }
        }

        Console.WriteLine(totalLiters);
    }
}
