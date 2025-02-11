using System;

class Program
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        double lightsaberPrice = double.Parse(Console.ReadLine());
        double robePrice = double.Parse(Console.ReadLine());
        double beltPrice = double.Parse(Console.ReadLine());
        
        double percent = (double)students * 0.1;
        double lightsabers = students + Math.Ceiling(percent);
        double allSabersPrice = lightsaberPrice * lightsabers;
        
        double robes = students * robePrice;
        
        double beltsDiss = students - Math.Ceiling((double)(students / 6));
        double belts = beltPrice * beltsDiss;
        
        double total = allSabersPrice + robes + belts;

        Console.WriteLine(money >= total 
            ? $"The money is enough - it would cost {total:F2}lv."
            : $"John will need {(total - money):F2}lv more.");
    }
}
