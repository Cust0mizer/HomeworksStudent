using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

public static class InputHelper {
    public static void PrintColor(string text, ConsoleColor consoleColor) {
        Console.ForegroundColor = consoleColor;
        PrintAndResetColor(text);
    }

    public static void PrintError(string text) {
        Console.ForegroundColor = ConsoleColor.Red;
        PrintAndResetColor(text);
    }

    public static void PrintGoodMessage(string text) {
        Console.ForegroundColor = ConsoleColor.Green;
        PrintAndResetColor(text);
    }

    public static void PrintWarning(string text) {
        Console.ForegroundColor = ConsoleColor.Yellow;
        PrintAndResetColor(text);
    }

    private static void PrintAndResetColor(string text) {
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static bool ChangeInput(string text, int min, int max, out int inputValue) {
        bool result = false;
        if (!string.IsNullOrWhiteSpace(text)) {
            Console.WriteLine(text);
        }

        if (int.TryParse(Console.ReadLine(), out inputValue)) {
            if (inputValue >= min && inputValue <= max) {
                result = true;
            }
        }

        return result;
    }

    public static bool ChangeInput(StringBuilder stringBuilder, int min, int max, out int inputValue) {
        bool result = false;

        Console.WriteLine(stringBuilder);

        if (int.TryParse(Console.ReadLine(), out inputValue)) {
            if (inputValue >= min && inputValue <= max) {
                result = true;
            }
        }

        return result;
    }

    public static bool TextInputField(string text, out string userInputText) {
        bool result = false;
        Console.WriteLine(text);

        userInputText = Console.ReadLine();

        if (!string.IsNullOrEmpty(userInputText)) {
            result = true;
        }

        return result;
    }

    public static bool FloatInputField(string text, out float userInput) {
        bool result = false;
        Console.WriteLine(text);

        if (float.TryParse(Console.ReadLine(), out userInput)) {
            result = true;
        }

        return result;
    }

    //public static bool FloatInputVector2(string text, out Vector2 vector2) {
    //    bool result = false;
    //    Console.WriteLine(text);

    //    string userInputText = Console.ReadLine();

    //    if (!string.IsNullOrEmpty(userInputText)) {
    //        Regex firstFilter = new Regex(@"\d+\s");
    //        result = true;
    //    }

    //    return result;
    //}

    public static bool ConvertEnumToType<TargetEnumType, ResultEnumType>(TargetEnumType firstEnumType, out ResultEnumType resultValue) where TargetEnumType : struct, Enum where ResultEnumType : struct, Enum {
        if (Enum.TryParse(firstEnumType.ToString(), out resultValue)) {
            return true;
        }
        else {
            throw new KeyNotFoundException($"Error parse {firstEnumType.GetType().Name} to {resultValue.GetType().Name}");
        }
    }

    //public static bool IntInputField<T>(string text, out T userInputText) where T : INumber<T>
    //{
    //    bool result = false;
    //    Console.WriteLine(text);

    //    if (T.TryParse(Console.ReadLine(), userInputText.ToString(), out userInputText))
    //    {
    //        result = true;
    //    }

    //    return result;
    //}
}


12 123