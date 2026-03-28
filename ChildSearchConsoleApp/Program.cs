namespace ChildSearchConsoleApp;
//project for exercise 4
internal class Program
{
    static void Main(string[] args)
    {
        string path = args[0];
        string word = args[1];

        string text = File.ReadAllText(path);

        int count = 0;
        int index = 0;

        while ((index = text.IndexOf(word, index)) != -1)
        {
            count++;
            index += word.Length;
        }

        Console.WriteLine("Word: " + word);
        Console.WriteLine("Count: " + count);

        Console.ReadLine();
    }
}