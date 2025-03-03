namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main()
        {
            string[] usernames = Console.ReadLine().Split(", ");

            for (int i = 0; i < usernames.Length; i++)
            {
                if (IsValidLength(usernames[i])
                    && IsValidSymbol(usernames[i]))
                {
                    Console.WriteLine(usernames[i]);
                }
            }
        }
        
        private static bool IsValidLength(string username)
        {
            if (username.Length > 3 && username.Length < 16)
            {
                return true;
            }
            
            return false;
        }
        
        private static bool IsValidSymbol(string username)
        {
            for (int i = 0; i < username.Length; i++)
            {
                if (!char.IsLetterOrDigit(username[i])
                    && username[i] != '_'
                    && username[i] != '-')
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}
