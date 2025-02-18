namespace _07.NxNMatrix;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        Matrix(num);
    }

    private static void Matrix(int num)
    {
        for (int col = 1; col <= num; col++)
        {
            for (int row = 1; row <= num; row++)
            {
                Console.Write($"{num} ");
            }
            
            Console.WriteLine();
        }
    }
}
