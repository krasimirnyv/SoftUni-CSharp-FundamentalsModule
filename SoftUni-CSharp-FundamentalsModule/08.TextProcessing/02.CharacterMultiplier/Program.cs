namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main()
        { 
            string[] input = Console.ReadLine().Split();
            
            GetSum(input[0], input[1]);
        }

        private static void GetSum(string firstStr, string secondStr)
        {
            uint result = 0;
            
            int minLenght = Math.Min(firstStr.Length, secondStr.Length);
            for (int i = 0; i < minLenght; i++)
            {
                result += (uint)firstStr[i] * secondStr[i];
            }

            result = AddRemainning(firstStr, secondStr, minLenght, result);
            Console.WriteLine(result);
        }

        private static uint AddRemainning(string firstStr, string secondStr, int minLenght, uint result)
        {
            for (int i = minLenght; i < firstStr.Length; i++)
            {
                result += firstStr[i];
            }

            for (int i = minLenght; i < secondStr.Length; i++)
            {
                result += secondStr[i];
            }
            
            return result;
        }
    }
}
