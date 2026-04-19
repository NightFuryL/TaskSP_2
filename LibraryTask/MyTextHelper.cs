using System.Text.RegularExpressions;

namespace LibraryTask;
//Зробив за допомогою Regex(тільки це із інтернетом) 
public static class MyTextHelper
{
    public static bool IsPalindrome(string text)
    {
        string t = text.ToLower().Replace(" ", "");
        char[] arr = t.ToCharArray();
        Array.Reverse(arr);
        return t == new string(arr);
    }

    public static int SentenceCount(string text)
    {
        return Regex.Matches(text, @"[.!?]").Count;
    }

    public static string Reverse(string text)
    {
        char[] arr = text.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}