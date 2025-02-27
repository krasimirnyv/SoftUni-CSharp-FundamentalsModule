namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> users = new Dictionary<string, User>();
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string username = tokens[1];
                
                switch (tokens[0])
                {
                    case "register":
                        
                        string licencePlate = tokens[2];
                        if (!users.ContainsKey(username))
                        {
                            users.Add(username, new User(username, licencePlate));
                            Console.WriteLine($"{username} registered {licencePlate} successfully");
                            continue;
                        }
                        
                        Console.WriteLine($"ERROR: already registered with plate number {licencePlate}");
                        break;
                    case "unregister":
                        if (users.ContainsKey(username))
                        {
                            users.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                            continue;
                        }

                        Console.WriteLine($"ERROR: user {username} not found");
                        break;
                }
            }

            foreach (KeyValuePair<string,User> user in users)
            {
                Console.WriteLine(user.Value);
            }
        }
    }

    class User
    {
        public User(string userName, string licencePlateNumber)
        {
            UserName = userName;
            LicencePlateNumber = licencePlateNumber;
        }

        public string UserName { get; set; }
        public string LicencePlateNumber { get; set; }

        public override string ToString()
        {
            return $"{UserName} => {LicencePlateNumber}";
        }
    }
}