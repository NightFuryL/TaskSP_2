using System.Text.RegularExpressions;

namespace LibraryTask;
//також зробив за допомогою Regex(інтернет)
public static class Validator
{
    public static bool CheckName(string name)
    {
        return Regex.IsMatch(name, @"^[a-zA-Zа-яА-ЯіїєІЇЄ\s]+$");
    }

    public static bool CheckAge(string age)
    {
        return Regex.IsMatch(age, @"^\d+$");
    }

    public static bool CheckPhone(string phone)
    {
        return Regex.IsMatch(phone, @"^\+?\d{10,15}$");
    }

    public static bool CheckEmail(string email)
    {
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }
}