public class ButtonYesOrNo
{
    public static readonly ButtonYesOrNo Instance;

    static ButtonYesOrNo()
    {
        Instance = new ButtonYesOrNo();
    }

    public bool GetResult(string buttonText)
    {
        bool result = false;
        if (InputHelper.Input(buttonText, 1, 1, out int inputValue))
        {
            result = true;
        }
        return result;
    }
}