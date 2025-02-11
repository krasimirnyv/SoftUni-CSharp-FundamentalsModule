using System;

class Program
{
    static void Main()
    {
        uint pokePowerN = uint.Parse(Console.ReadLine());
        uint distanceBetweenTargetsM = uint.Parse(Console.ReadLine());
        uint exhaustionFactorY = uint.Parse(Console.ReadLine());

        ushort targetCount = 0;
        decimal fiftyPercentN = pokePowerN * 0.50m;
        while (pokePowerN >= distanceBetweenTargetsM)
        {
            targetCount++;
            pokePowerN -= distanceBetweenTargetsM;

            if (pokePowerN == fiftyPercentN && exhaustionFactorY != 0)
            {
                pokePowerN /= exhaustionFactorY;
            }
        }

        Console.WriteLine(pokePowerN);
        Console.WriteLine(targetCount);
    }
}
