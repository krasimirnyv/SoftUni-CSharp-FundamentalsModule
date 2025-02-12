using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());

        int biggestSnow = 0, biggestTime = 0, biggestQuality = 0;
            
        BigInteger biggestValue = 0;
    
        for (int i = 0; i < lines; i++)
        {
            int snow = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            int quality = int.Parse(Console.ReadLine());

            BigInteger value = BigInteger.Pow(snow / time, quality);
            
            if (biggestValue < value)
            {
                biggestValue = value;
                biggestSnow = snow;
                biggestTime = time;
                biggestQuality = quality;
            }
        }

        Console.WriteLine($"{biggestSnow} : {biggestTime} = {biggestValue} ({biggestQuality})");
    }
}
