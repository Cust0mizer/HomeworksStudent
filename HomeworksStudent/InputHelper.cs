using System.Text;

public static class InputHelper
{
    public static void PrintColor(string text, ConsoleColor consoleColor)
    {
        Console.ForegroundColor = consoleColor;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static void PrintError(string text)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static void PrintGoodMessage(string text)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static void PrintWarning(string text)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static bool Input(string text, int min, int max, out int inputValue)
    {
        bool result = false;
        Console.WriteLine(text);
        if (int.TryParse(Console.ReadLine(), out inputValue))
        {
            if (inputValue >= min && inputValue <= max)
            {
                result = true;
            }
        }

        return result;
    }

    public static bool Input(StringBuilder stringBuilder, int min, int max, out int inputValue)
    {
        bool result = false;
        Console.WriteLine(stringBuilder);

        if (int.TryParse(Console.ReadLine(), out inputValue))
        {
            if (inputValue >= min && inputValue <= max)
            {
                result = true;
            }
        }

        return result;
    }
}