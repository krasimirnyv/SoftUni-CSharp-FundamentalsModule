using System;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine()
                .Split()
                .ToList();
            
            string command = String.Empty;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "merge":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);
                        startIndex = EditIndexIfSmallerThanZero(data, startIndex);
                        endIndex = EditIndexIfBiggerThanCount(data, endIndex);
                        Merge(data, startIndex, endIndex);
                        break;
                    case "divide":
                        int index = int.Parse(tokens[1]);
                        if (IsIndexOutOfRange(data, index))
                        {
                            continue;
                        }
                        
                        int parts = int.Parse(tokens[2]);
                        if (parts <= 0)
                        {
                            continue;
                        }
                        
                        Divide(data, index, parts);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", data));
        }
        
        private static void Merge(List<string> data, int startIndex, int endIndex)
        {
            int count = endIndex - startIndex + 1;
            List<string> elementsInRange = data.GetRange(startIndex, count).ToList();

            string result = "";
            for (int i = 0; i < elementsInRange.Count; i++)
            {
                result += elementsInRange[i];
            }
            
            data.RemoveRange(startIndex, count);
            data.Insert(startIndex, result);
        }

        private static void Divide(List<string> data, int index, int parts)
        {
            string element = data[index];
            if (parts > element.Length)
            {
                parts = element.Length;
            }
            
            char[] charArray = element.ToCharArray(); 
            data.RemoveAt(index);

            int divisionCounter = parts;
            string temp = string.Empty;
            for (int i = 0; i < charArray.Length; i++)
            {
                temp += charArray[i].ToString();
                if (element.Length / parts == temp.Length
                    && divisionCounter > 0)
                {
                    divisionCounter--;
                    data.Insert(index++, temp);
                    temp = string.Empty;
                }
            }

            if (temp.Length > 0)
            {
                data[--index] += temp;
            }
        }
        
        private static int EditIndexIfSmallerThanZero(List<string> list, int startIndex)
        {
            if (IsIndexOutOfRange(list, startIndex))
            {
                return 0;
            }
            
            return startIndex;
        }
        
        private static int EditIndexIfBiggerThanCount(List<string> list, int endIndex)
        {
            if (IsIndexOutOfRange(list, endIndex))
            {
                return list.Count - 1;
            }
            
            return endIndex;        
        }

        private static bool IsIndexOutOfRange(List<string> list, int index)
        {
            return index < 0 || index >= list.Count;
        }
    }
}
