using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        double biggestKeg = double.MinValue;
        string biggestKegName = String.Empty;
        for (int i = 1; i <= n; i++)
        {
            string kegModel = Console.ReadLine();
            double kegRadius = double.Parse(Console.ReadLine());
            int kegHeight = int.Parse(Console.ReadLine());

            double kegVolume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;
            
            if (kegVolume > biggestKeg)
            {
                biggestKeg = kegVolume;
                biggestKegName = kegModel;
            }
        }
        
        Console.WriteLine(biggestKegName);
    }
}
