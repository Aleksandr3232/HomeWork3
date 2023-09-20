using HomeWork3;
using System.Reflection;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string firstName = GetFirstName();
        string lastName = GetLastName();
        Gender gender = GetGender();

        User user1 = new User(30)
        {
            FirstName = firstName,
            LastName = lastName,
            Gender = gender
        };

        Console.WriteLine(user1.ToString());
    }

    public static string GetFirstName()
    {
        Console.WriteLine("Enter first name: ");
        string firstName = Console.ReadLine();

        if (!Regex.IsMatch(firstName, @"^[a-z _'-]+$", RegexOptions.IgnoreCase))
        {
            Console.WriteLine($"Invalid {firstName}! Enter value again:");
            return GetFirstName();
        }

        return firstName;
    }

    public static string GetLastName()
    {
        Console.WriteLine("Enter last name: ");
        string lastName = Console.ReadLine();

        if (!Regex.IsMatch(lastName, @"^[a-z _'-]+$", RegexOptions.IgnoreCase))
        {
            Console.WriteLine($"Invalid {lastName}! Enter value again:");
            return GetLastName();
        }

        return lastName;
    }

    public static Gender GetGender()
    {
        Console.WriteLine("Enrer your gender: Male or Female: ");
        string gender = Console.ReadLine();

        if (!Enum.TryParse(typeof(Gender), gender, out var result))
        {
            Console.WriteLine($"Invalid {gender}! Enter value again:");
            return GetGender();
        }

        return gender == "Male" ? Gender.Male : Gender.Female;
    }

}