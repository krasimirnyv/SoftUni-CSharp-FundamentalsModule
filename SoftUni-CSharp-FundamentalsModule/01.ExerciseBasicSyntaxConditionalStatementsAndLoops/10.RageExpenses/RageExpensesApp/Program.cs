using System;

class Program
{
    static void Main()
    {
        int lostGames = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        int headsetTrash = 0;
        int mouseTrash = 0;
        int keyboardTrash = 0;
        int displayTrash = 0;
        int times = 0;

        for (int currentLostGame = 1; currentLostGame <= lostGames; currentLostGame++)
        {
            if (currentLostGame % 2 == 0)
            {
                headsetTrash++;
            } 
        
            if (currentLostGame % 3 == 0)
            {
                mouseTrash++;
            }
            
            if (currentLostGame % 2 == 0 && currentLostGame % 3 == 0)
            {
                keyboardTrash++;
                times++;
                
                if (times == 2)
                {
                    displayTrash++;
                    times = 0;
                }
            } 
        }
        
        double totalHeadset = headsetPrice * headsetTrash;
        double totalMouse = mousePrice * mouseTrash;
        double totalKeyboard = keyboardPrice * keyboardTrash;
        double totalDisplay = displayPrice * displayTrash;
        
        double totalMoney = totalHeadset + totalMouse + totalKeyboard + totalDisplay;
        Console.WriteLine($"Rage expenses: {totalMoney:F2} lv.");
    }
}
