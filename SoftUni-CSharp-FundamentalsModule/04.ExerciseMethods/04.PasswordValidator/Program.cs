namespace _04.PasswordValidator;

class Program
{
    static void Main(string[] args)
    {
        string password = Console.ReadLine();

        if (isValid(password))
        {
            Console.WriteLine("Password is valid");
        }
    }

    private static bool isValid(string password)
    {
        char[] chars = password.ToCharArray();
        bool isValid = true;

        isValid = IsInValidRange(chars, isValid);
        isValid = IsContainingOnlyLettersAndDigits(chars, isValid);
        isValid = IsContainingTwoDigits(chars, isValid);

        return isValid;
    }

    private static bool IsInValidRange(char[] chars, bool isValid)
    {
        if (chars.Length < 6 || chars.Length > 10)
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
            isValid = false;
        }

        return isValid;
    }

    private static bool IsContainingOnlyLettersAndDigits(char[] chars, bool isValid)
    {
        for (int i = 0; i < chars.Length; i++)
        {
            bool isDigit = char.IsDigit(chars[i]);
            bool isLetter = char.IsLetter(chars[i]);

            if (!isDigit && !isLetter)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
                break;
            }
        }

        return isValid;
    }

    private static bool IsContainingTwoDigits(char[] chars, bool isValid)
    {
        int digitCount = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            bool isDigit = char.IsDigit(chars[i]);
            if (isDigit)
            {
                digitCount++;
            }
        }

        if (digitCount < 2)
        {
            Console.WriteLine("Password must have at least 2 digits");
            isValid = false;
        }

        return isValid;
    }
}
