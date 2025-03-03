namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main()
        {
            string[] path = Console.ReadLine().Split("\\");

            string fullFileMane = path[^1];
            int lastIndexDot = fullFileMane.LastIndexOf(".");

            string fileName = fullFileMane.Substring(0, lastIndexDot);
            string fileExtension = fullFileMane.Substring(lastIndexDot + 1);

            Console.WriteLine($"File name: {fileName}\n"
                + $"File extension: {fileExtension}");
        }
    }
}
