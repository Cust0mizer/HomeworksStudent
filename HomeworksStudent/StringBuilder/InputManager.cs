using System.Text;

namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public class InputManager
    {
        private StringBuilder stringBuilder = new StringBuilder();
        public readonly static InputManager Instance;

        static InputManager()
        {
            Instance = new InputManager();
        }

        public void AddNewText(string text, LineMode lineMode)
        {
            switch (lineMode)
            {
                case LineMode.Line:
                stringBuilder.Append(text);
                break;
                case LineMode.NewLine:
                stringBuilder.Append($"\n{text}");
                break;
            }
        }

        public void ReplaceText(string firstText, string secondText)
        {
            stringBuilder.Replace(firstText, secondText);
        }

        public void PrintAll()
        {
            InputHelper.PrintGoodMessage(stringBuilder.ToString());
        }

        public void Clear()
        {
            stringBuilder.Clear();
        }

        public bool ContainsInfo()
        {
            return stringBuilder.Length > 0;
        }
    }
}