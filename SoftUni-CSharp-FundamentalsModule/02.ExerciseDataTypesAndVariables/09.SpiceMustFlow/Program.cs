using System;

class Program
{
    static void Main()
    {
        uint startingYield = uint.Parse(Console.ReadLine());
        
        uint totalSpices = 0;
        uint days = 0;
        uint consumedPerDay = 26; // +26 when closing

        while (startingYield >= 100)
        {
            days++;
            if (days == 1)
            {
                totalSpices += startingYield;
            }
            else // days > 1
            {
                totalSpices += startingYield;
            }
            
            if (totalSpices >= consumedPerDay)
            {
                totalSpices -= consumedPerDay;
            }
            
            startingYield -= 10;
        }

        if (totalSpices >= consumedPerDay)
        {
            totalSpices -= consumedPerDay;
        }

        Console.WriteLine(days);
        Console.WriteLine(totalSpices);
    }
}
