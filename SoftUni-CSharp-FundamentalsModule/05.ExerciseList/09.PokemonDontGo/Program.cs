using System;

namespace _09.PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distance = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sumOfRemovedElements = 0;
            while (distance.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                index = AdjustIndexWhenNotInRange(distance, index);
                
                int element = distance[index];
                sumOfRemovedElements += element;
                distance.RemoveAt(index);
                for (int i = 0; i < distance.Count; i++)
                {
                    if (distance[i] <= element)
                    {
                        distance[i] += element;
                    }
                    else if(distance[i] > element)
                    {
                        distance[i] -= element;
                    }
                }
            }
            
            Console.WriteLine(sumOfRemovedElements);
        }

        private static int AdjustIndexWhenNotInRange(List<int> list, int index)
        {
            if (index < 0)
            {
                int copy = list[^1];
                list.Insert(1, copy);
                return 0;
            }
            
            if (index >= list.Count)
            {
                int copy = list[0];
                list.Insert(list.Count - 1, copy);
                return list.Count - 1;
            }
            
            return index;
        }
    }
}
