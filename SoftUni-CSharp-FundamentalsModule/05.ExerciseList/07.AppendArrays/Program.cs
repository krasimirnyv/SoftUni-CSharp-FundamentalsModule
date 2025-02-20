namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArrays = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);
            
            List<string> symbols = ExtractSymbols(stringArrays);

            Console.WriteLine(string.Join(" ", symbols));
        }

        private static List<string> ExtractSymbols(string[] arrays)
        {
            List<string> result = new List<string>();

            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                string[] array = arrays[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                result.AddRange(array);
            }
            
            return result;
        }
    }
}
