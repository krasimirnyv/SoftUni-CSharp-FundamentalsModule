namespace _01.Train;

class Program
{
    static void Main(string[] args)
    {
        int wagons = int.Parse(Console.ReadLine());

        int[] wagonPassengers = new int[wagons];
        int totalPassengers = 0;
        
        for (int i = 0; i < wagons; i++)
        {
            int passengers = int.Parse(Console.ReadLine());
            wagonPassengers[i] = passengers;
            totalPassengers += passengers;
        }

        Console.WriteLine($"{string.Join(" ", wagonPassengers)}\n" +
                          $"{totalPassengers}");
    }
}
