namespace _07.MaxSequenceOfEqualElements;

class Program
{
    static void Main(string[] args)
    {
        string [] array = Console.ReadLine().Split();
        
        string element = String.Empty;
        int bestCount = 1;
        
        for (int i = 0; i < array.Length; i++)
        {
            int counter = 1;
            
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] != array[j])
                {
                    break;
                }

                counter++;
            }
            
            if (bestCount < counter)
            {
                bestCount = counter;
                element = array[i];
            }
        }

        string sequence = String.Empty;
        for (int i = 0; i < bestCount; i++)
        {
            sequence += $"{element} ";
        }

        Console.WriteLine(sequence.TrimEnd());
    }
}
