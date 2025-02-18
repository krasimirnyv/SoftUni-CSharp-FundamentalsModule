namespace _05.AddAndSubtract;

class Program
{
    static void Main(string[] args)
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        int addSum = Add(first, second);
        int subtractSum = Subtract(addSum, third);
        Console.WriteLine(subtractSum);
    }
    
    private static int Add(int a, int b)
    {
        return a + b;
    }
    
    private static int Subtract(int addSum, int third)
    {
        return addSum - third;
    }
}
