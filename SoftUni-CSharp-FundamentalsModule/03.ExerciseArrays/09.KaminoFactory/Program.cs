namespace _09.KaminoFactory;

class Program
{
    static void Main(string[] args)
    {
            int dnaLength = int.Parse(Console.ReadLine());

            int[] bestDNA = new int[dnaLength];
            
            int bestSequenceIndex = 0;
            int bestLength = 0;
            int bestStartingIndex = dnaLength;
            int bestDNASum = 0;
            int sampleCounter = 0;
            int bestSampleNumber = 0;

            string input;
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                sampleCounter++;
                int[] currentDNA = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentSum = currentDNA.Sum();
                int currentLength = 0;
                int currentStartingIndex = -1;

                int maxLength = 0, startIndex = -1, counter = 0;
                for (int i = 0; i < dnaLength; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        if (counter == 0)
                        {
                            startIndex = i;
                        }
                        
                        counter++;
                        if (counter > maxLength)
                        {
                            maxLength = counter;
                            currentStartingIndex = startIndex;
                        }
                    }
                    else
                    {
                        counter = 0;
                    }
                }
                currentLength = maxLength;

                if (currentLength > bestLength ||
                   (currentLength == bestLength && currentStartingIndex < bestStartingIndex) ||
                   (currentLength == bestLength && currentStartingIndex == bestStartingIndex && currentSum > bestDNASum))
                {
                    bestLength = currentLength;
                    bestStartingIndex = currentStartingIndex;
                    bestDNASum = currentSum;
                    bestSampleNumber = sampleCounter;
                    bestDNA = currentDNA.ToArray();
                }
            }

            Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {bestDNASum}\n" +
                              $"{string.Join(" ", bestDNA)}");
    }
}
