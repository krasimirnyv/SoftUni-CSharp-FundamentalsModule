using System;

class Program
{
    static void Main()
    {
        int peopleCount = int.Parse(Console.ReadLine());
        string groupType = Console.ReadLine();
        string day = Console.ReadLine();

        double price = 0;
        double discount = 0;
        switch (groupType)
        {
            case "Students":
                if (day == "Friday")
                {
                    price = peopleCount * 8.45;
                }
                else if (day == "Saturday")
                {
                    price = peopleCount * 9.80;
                }
                else if (day == "Sunday")
                {
                    price = peopleCount * 10.46;
                }

                if (peopleCount >= 30)
                {
                    discount = price * 0.15;
                    price -= discount;
                }
                
                break;
            case "Business":
                if (peopleCount >= 100)
                {
                    peopleCount -= 10;
                }
                
                if (day == "Friday")
                {
                    price = peopleCount * 10.90;
                }
                else if (day == "Saturday")
                {
                    price = peopleCount * 15.60;
                }
                else if (day == "Sunday")
                {
                    price = peopleCount * 16;
                }
                
                break;
            case "Regular":
                if (day == "Friday")
                {
                    price = peopleCount * 15;
                }
                else if (day == "Saturday")
                {
                    price = peopleCount * 20;
                }
                else if (day == "Sunday")
                {
                    price = peopleCount * 22.50;
                }

                if (peopleCount >= 10 && peopleCount <= 20)
                {
                    discount = price * 0.05;
                    price -= discount;
                }
                break;
            
        }

        Console.WriteLine($"Total price: {price:F2}");
    }
}
