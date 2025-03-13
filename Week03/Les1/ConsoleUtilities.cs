using static System.Console;

public static class ConsoleUtilities
{
    public static readonly ConsoleColor Red;
    public static readonly ConsoleColor Green;
    public static readonly ConsoleColor Blue;

    static ConsoleUtilities()
    {
        WriteLine("ConsoleUtilities static constructor");
        Red = ConsoleColor.Red;
        Green = ConsoleColor.Green;
        Blue = ConsoleColor.Blue;
    }

    public static void PrintTextInRed(string text)
    {
        Console.ForegroundColor = Red;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static void PrintTextInGreen(string text)
    {
        Console.ForegroundColor = Green;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static void PrintTextInBlue(string text)
    {
        Console.ForegroundColor = Blue;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static void PrintTextVertical(string text)
    {
        foreach (char c in text)
        {
            Console.WriteLine(c);
        }
    }
}