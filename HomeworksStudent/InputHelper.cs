using System.Text;

public static class InputHelper
{
    public static void PrintColor(string text, ConsoleColor consoleColor)
    {
        Console.ForegroundColor = consoleColor;
        PrintAndResetColor(text);
    }

    public static void PrintError(string text)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        PrintAndResetColor(text);
    }

    public static void PrintGoodMessage(string text)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        PrintAndResetColor(text);
    }

    public static void PrintWarning(string text)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        PrintAndResetColor(text);
    }

    private static void PrintAndResetColor(string text)
    {
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