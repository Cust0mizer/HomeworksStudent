public class ButtonYesOrNo
{
    public bool GetResult(string buttonText)
    {
        bool result = false;
        if (InputHelper.ChangeInput(buttonText, 1, 1, out int inputValue))
        {
            result = true;
        }
        return result;
    }
}