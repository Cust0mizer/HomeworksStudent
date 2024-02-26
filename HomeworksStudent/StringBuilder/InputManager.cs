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

        public void Print()
        {
            Console.WriteLine(stringBuilder);
        }

        public void Clear()
        {
            stringBuilder.Clear();
        }
    }
}