namespace _04.ArrayRotation;

class Program
{
    static void Main(string[] args)
    {
        string[] array = Console.ReadLine().Split();
        int rotations = int.Parse(Console.ReadLine());

        while (rotations > 0)
        {
            rotations--;
            string lastElement = array[array.Length - 1];
            array[array.Length - 1] = array[0];
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[array.Length - 2])
                {
                    array[i] = lastElement;
                    break;
                }
                
                array[i] = array[i + 1];
            }
        }
        
        Console.WriteLine(string.Join(" ", array).TrimEnd());
    }
}
