using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        uint lines = uint.Parse(Console.ReadLine());

        uint biggestSnow = 0, biggestTime = 0, biggestQuality = 0;
            
        BigInteger biggestValue = 0;
    
        for (int i = 0; i < lines; i++)
        {
            uint snow = uint.Parse(Console.ReadLine());
            uint time = uint.Parse(Console.ReadLine());
            uint quality = uint.Parse(Console.ReadLine());

            BigInteger value = (BigInteger)Math.Pow(snow / time, quality);
            
            if (value >= biggestValue)
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
