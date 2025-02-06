using System;

class Program
{
    static void Main()
    {
        string username = Console.ReadLine();
        char[] charArray = username.ToCharArray();
        Array.Reverse(charArray);
        string password = new string(charArray);
        
        string tryLogIn = Console.ReadLine();
        int attempts = 3;
        while (attempts >= 0)
        {
            if (tryLogIn == password)
            {
                Console.WriteLine($"User {username} logged in.");
                return;
            }
            else if (tryLogIn != password && attempts == 0)
            {
                break;
            }    

            attempts--;
            Console.WriteLine("Incorrect password. Try again.");
            tryLogIn = Console.ReadLine();
        }

        Console.WriteLine($"User {username} blocked!");
    }
}
