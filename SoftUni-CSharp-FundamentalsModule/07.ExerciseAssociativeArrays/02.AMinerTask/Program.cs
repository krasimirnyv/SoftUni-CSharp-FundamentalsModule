namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, uint> minerTasks = new Dictionary<string, uint>();
            
            string input = default;
            while ((input = Console.ReadLine()) != "stop")
            {
                string resource = input;
                uint quantity = uint.Parse(Console.ReadLine());

                if (!minerTasks.ContainsKey(resource))
                {
                    minerTasks.Add(resource, 0);
                }
                
                minerTasks[resource] += quantity;
            }

            foreach (KeyValuePair<string,uint> task in minerTasks)
            {
                Console.WriteLine($"{task.Key} -> {task.Value}");
            }
        }
    }
}
