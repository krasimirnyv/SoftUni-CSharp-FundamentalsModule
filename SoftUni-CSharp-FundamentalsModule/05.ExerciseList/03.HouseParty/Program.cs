
namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();
            
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split()
                    .ToArray();

                string name = commands[0];
                bool isGoing = commands[2] == "going!";
                bool isGuestInList = guestList.Exists(x => x == name);
                
                if (!isGuestInList && isGoing) // Guest is missing in the list && is going
                {
                    guestList.Add(name);
                }
                else if (isGuestInList && isGoing) // Guest is already in the list
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
                else if (isGuestInList && !isGoing) // Guest in the list is no going
                {
                    guestList.Remove(name);
                }
                else //(!!isGuestInList && !isGoing)  Guest is missing in the list
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
            }
            
            guestList.ForEach(x => Console.WriteLine(x));
        }
    }
}
