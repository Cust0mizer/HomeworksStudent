using System.Text;

static class ExtensionClass
{
    public static void IntSum(this int newValue, int firstValue)
    {
        Console.WriteLine(newValue + firstValue);
    }

    public static void NewLine(this StringBuilder stringBuilder, string text)
    {
        stringBuilder.Append($"\n{text}");
    }
}