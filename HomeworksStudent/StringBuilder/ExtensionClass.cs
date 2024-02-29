using System.Text;

static class ExtensionClass
{
    public static void NewLine(this StringBuilder stringBuilder, string text)
    {
        stringBuilder.Append($"\n{text}");
    }
}