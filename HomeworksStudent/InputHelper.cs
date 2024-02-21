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


    public static bool Input(string text, int min, int max, out int inputValue)
    {
        inputValue = -1;
        bool result = false;
        Console.WriteLine(text);

        if (int.TryParse(Console.ReadLine(), out int inputResult))
        {
            if (inputResult >= min && inputResult <= max)
            {
                inputValue = inputResult;
                result = true;
            }
        }

        return result;
    }
}